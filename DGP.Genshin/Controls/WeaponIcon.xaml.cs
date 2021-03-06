﻿using DGP.Genshin.Data.Weapon;
using System;
using System.Windows;
using System.Windows.Controls;

namespace DGP.Genshin.Controls
{
    /// <summary>
    /// WeaponIcon.xaml 的交互逻辑
    /// </summary>
    public partial class WeaponIcon : UserControl
    {
        public WeaponIcon()
        {
            DataContext = this;
            InitializeComponent();
        }

        public Weapon Weapon
        {
            get { return (Weapon)GetValue(WeaponProperty); }
            set { SetValue(WeaponProperty, value); }
        }
        public static readonly DependencyProperty WeaponProperty =
            DependencyProperty.Register("Weapon", typeof(Weapon), typeof(WeaponIcon), new PropertyMetadata(null));

        public EventHandler IconClicked;
        private void UserControl_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            IconClicked?.Invoke(this, null);
        }
    }
}
