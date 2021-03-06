﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin.Duo.Forms.Samples
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DualViewMapPage : DuoPage
	{
		public DualViewMapPage()
		{
			InitializeComponent();
		}

		public void UpdateMap(MapItem item)
			=> map.UpdateMap(item);
	}
}