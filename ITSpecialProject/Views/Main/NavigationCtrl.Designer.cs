using System;
using ITSpecialProject.Commons.Helpers;
using ITSpecialProject.Components;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DataLayer.Core;

namespace ITSpecialProject.Views.Main
{
    public partial class NavigationView
    {
        private Module _selectedModule = new Module();

        public void Initialize(List<Module> modules)
        {
            CreateButtons(modules);
        }

        private void CreateButtons(List<Module> modules)
        {
            flowNavigation.Controls.Clear();

            flowNavigation.Controls.AddRange(ButtonList(modules).ToArray());
        }

        private IEnumerable<FlatButton> ButtonList(List<Module> modules)
        {
            foreach (var module in modules)
            {
                yield return SetButtonProperties(module);
            }
        }

        private FlatButton SetButtonProperties(Module module)
        {
            var button = new FlatButton()
            {
                Text = module.Title,
                Height = 50,
                Width = 196,
                Margin = new Padding(0, 0, 2, 2),
                TabStop = false
            };

            button.SetModule(module.Instance);

            SetDeselectedButtonProperties(button);

            SetButtonEvent(button);

            return button;
        }

        private void SetSelectedButtonProperties(FlatButton button)
        {
            button.BackColorOnDefault = ColorHelper.FlatYellowNormal;
            button.BackColorOnHover = ColorHelper.FlatYellowNormal;
            button.BackColorOnClick = ColorHelper.FlatYellowNormal; ;

            button.ForeColorOnDefault = ColorHelper.White;
            button.ForeColorOnHover = ColorHelper.White;
            button.ForeColorOnClick = ColorHelper.White;
        }

        private void SetDeselectedButtonProperties(FlatButton button)
        {
            button.BackColorOnDefault = Color.FromArgb(50, ColorHelper.FlatYellowNormal);
            button.BackColorOnHover = Color.FromArgb(50, ColorHelper.FlatYellowNormal);
            button.BackColorOnClick = Color.FromArgb(50, ColorHelper.FlatYellowNormal);

            button.ForeColorOnDefault = ColorHelper.White;
            button.ForeColorOnHover = ColorHelper.White;
            button.ForeColorOnClick = ColorHelper.White;
        }

        private void DeselectButton(FlatButton button)
        {
            foreach (var control in flowNavigation.Controls.Cast<Control>())
            {
                if (control is FlatButton nav && !nav.Equals(button))
                {
                    SetDeselectedButtonProperties(nav);
                }
            }
        }

        private void SetButtonEvent(FlatButton button)
        {
            button.Click += (s, e) =>
            {
                _selectedModule.Instance = button.GetModule();

                _selectedModule.Title = button.Text;

                SetSelectedButtonProperties(button);

                DeselectButton(button);
            };
        }

        public IModule SelectedModule
        {
            get { return _selectedModule.Instance; }
        }

        public string SelectedTitle
        {
            get { return _selectedModule.Title; }
        }

        public event EventHandler NavigationButtonClicked
        {
            add
            {
                foreach (var control in flowNavigation.Controls.Cast<Control>())
                {
                    control.Click += value;
                }
            }
            remove
            {
                foreach (var control in flowNavigation.Controls.Cast<Control>())
                {
                    control.Click -= value;
                }

            }
        }
    }
}
