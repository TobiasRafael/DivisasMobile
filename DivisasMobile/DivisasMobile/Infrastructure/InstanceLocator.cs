﻿using DivisasMobile.ViewModels;

namespace DivisasMobile.Infrastructure
{
    public class InstanceLocator
    {

        public MainViewModel Main { get; set; }
        public InstanceLocator()
        {
            Main = new MainViewModel();

        }

    }
}
