﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase1
{
    public partial class homePageForm : Form
    {
        public homePageForm()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            browsePage myBrowsePage = new browsePage();
            myBrowsePage.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            searchPage mySearchPage = new searchPage();
            mySearchPage.ShowDialog();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            createPage myCreatePage = new createPage();
            myCreatePage.ShowDialog();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            updatePage myUpdatePage = new updatePage();
            myUpdatePage.ShowDialog();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            deletePage myDeletePage = new deletePage();
            myDeletePage.ShowDialog();
        }
    }
}
