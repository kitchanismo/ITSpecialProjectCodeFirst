using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITSpecialProject.Components.Interfaces
{
    public interface IEllipseOnDefault
    {
        int EllipseOnDefault { get; set; }

        void SetEllipseOnDefault();
    }

    public interface IEllipseOnHover
    {
        int EllipseOnHover { get; set; }

        void SetEllipseOnHover();
    }

    public interface IEllipseOnClick
    {
        int EllipseOnClick { get; set; }

        void SetEllipseOnClick();
    }

    public interface IEllipseOnCheck
    {
        int EllipseOnCheck { get; set; }

        void SetEllipseOnCheck();
    }

    public interface IEllipseOnUncheck
    {
        int EllipseOnUncheck { get; set; }

        void SetEllipseUncheck();
    }
}
