using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace anigamer_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        IWebDriver driver = new OpenQA.Selenium.Chrome.ChromeDriver();
        ITimeouts timeouts;
        int page_num = 1;

        private void Web_Search_Button1_Click(object sender, EventArgs e)
        {
            ariticle_closed_button_Click(sender, e);

            if (web_input.Text.IndexOf("https://forum.gamer.com.tw/B.php?") == -1)
            {
                Output_Box.Text += "輸入網址錯誤\n";
                return;
                return;
            }

            int jump_page;
            if (page_box.Text != "")
            {
                if (int.TryParse(page_box.Text, out jump_page) != true)
                {
                    Output_Box.Text += "輸入頁碼錯誤\n";
                    return;
                    return;
                }

                if (jump_page < 1)
                {
                    Output_Box.Text += "輸入頁碼錯誤\n";
                    return;
                    return;
                }

                page_num = jump_page;
            }
            
            webload(page_num);
        }

        private void Output_Box_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Output_Box.Links[Output_Box.Links.IndexOf(e.Link)].Visited = true;
            string target = e.Link.LinkData.ToString();

            if(target.IndexOf("https") == -1)
            {
                driver.Navigate().GoToUrl("https://forum.gamer.com.tw/" + target);
                timeouts.ImplicitWait = new TimeSpan(0, 0, 10);

            }
            else
            {
                driver.Navigate().GoToUrl(target);
                return;
                return;
            }

            article_panel.Visible = true;
            article_output_box.Visible = true;
            article_closed_button.Visible = true;
            next_page_button.Visible = false;
            pre_page_button.Visible = false;

            var article_title = driver.FindElement(By.ClassName("c-post__header__title"));
            var article = driver.FindElement(By.ClassName("c-article__content"));
            article_output_box.Text = article_title.Text + "\n";
            article_output_box.Text += article.Text + "\n";
        }

        private void Game_search_Button1_Click(object sender, EventArgs e)
        {
            web_input.Text = "https://forum.gamer.com.tw/B.php?bsn=37505";
            title_condition.Text = "";
            title_keyword.Text = "";
            Output_Box.Text = "";
            Output_Box.Links.Clear();
        }

        private void next_page_Click(object sender, EventArgs e)
        {
            page_num++;
            webload(page_num);
        }

        private void pre_page_button_Click(object sender, EventArgs e)
        {
            page_num--;
            if(page_num == 0)
            {
                page_num = 1;
            }

            webload(page_num);
        }
        
        private void webload(int page_num)
        {
            driver.Navigate().GoToUrl(web_input.Text + "&page=" + page_num);
            timeouts = driver.Manage().Timeouts();
            timeouts.ImplicitWait = new TimeSpan(0, 0, 5);

            Output_Box.Text = "";
            Output_Box.Links.Clear();
            int output_number = 0;

            Output_Box.Text += driver.Title + "\n";
            Output_Box.Links.Add(0, driver.Title.Length, web_input.Text);
            Output_Box.Text += "\nPage " + page_num + " :\n";

            var titles = driver.FindElements(By.ClassName("b-list__main__title"));

            for (int i = 0; i < titles.Count; i++)
            {
                if (titles[i].Text.IndexOf(title_condition.Text) != -1)
                {
                    if (titles[i].Text.IndexOf(title_keyword.Text) != -1)
                    {
                        var titles_website = titles[i].GetAttribute("href");
                        Output_Box.Text += titles[i].Text + "\n";
                        Output_Box.Links.Add(Output_Box.Text.Length - titles[i].Text.Length, titles[i].Text.Length, titles_website);
                        output_number++;
                    }
                }
            }

            Output_Box.Text += "搜尋結果 : 共 " + output_number + " 項\n";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            driver.Quit();
            Application.ExitThread();
        }

        private void ariticle_closed_button_Click(object sender, EventArgs e)
        {
            driver.Navigate().Back();
            timeouts = driver.Manage().Timeouts();
            timeouts.ImplicitWait = new TimeSpan(0, 0, 5);
            article_panel.Visible = false;
            article_output_box.Visible = false;
            article_closed_button.Visible = false;
            next_page_button.Visible = true;
            pre_page_button.Visible = true;
        }
    }
}
