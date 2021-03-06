﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee
{
	public partial class ScoreboardView : UserControl
	{

		private ScoreboardController controller;
		public ScoreboardView(ScoreboardController c)
		{
			InitializeComponent();
			controller = c;
		}

		public void ChangeScore(int newScore)
		{
			lblScore.Text = "Score: " + controller.model.Score;
		}

		public void ChangeHighscore()
		{
			lblHighscore.Text = "Highscore: " + controller.model.Highscore;
		}
	}
}
