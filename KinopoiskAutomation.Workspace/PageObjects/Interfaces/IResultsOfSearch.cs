using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinopoiskAutomation.Workspace.PageObjects.Interfaces
{
    public interface IResultsOfSearch
    {
        void ClickSearchedFilm();
        string GetTextOfSearchedFilm();
    }
}
