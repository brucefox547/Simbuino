﻿using MvvmDialogs.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Simbuino.UI.ViewModel
{
	public class MessageBoxViewModel : IDialogViewModel
	{
		private string _Caption = "";
		public string Caption
		{
			get { return _Caption; }
			set { _Caption = value; }
		}

		private string _Message = "";
		public string Message
		{
			get { return _Message; }
			set { _Message = value; }
		}

		private MessageBoxButton _Buttons = MessageBoxButton.OK;
		public MessageBoxButton Buttons
		{
			get { return _Buttons; }
			set { _Buttons = value; }
		}

		private MessageBoxImage _Image = MessageBoxImage.None;
		public MessageBoxImage Image
		{
			get { return _Image; }
			set { _Image = value; }
		}

		private MessageBoxResult _Result;
		public MessageBoxResult Result
		{
			get { return _Result; }
			set { _Result = value; }
		}

		public MessageBoxViewModel(string message = "", string caption = "")
		{
			this.Message = message;
			this.Caption = caption;
		}

		public MessageBoxResult Show(IList<IDialogViewModel> collection)
		{
			collection.Add(this);
			return this.Result;
		}

	}
}
