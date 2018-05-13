using KinopoiskAutomation.AOP;
using KinopoiskAutomation.Workspace.PageObjects.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinopoiskAutomation.Workspace.Steps
{
    public class ResultsOfSearchSteps
    {
        IResultsOfSearch resultOfSearchPage;

        public ResultsOfSearchSteps(Guid driverId)
        {
            resultOfSearchPage = DependencyResolver.For<IResultsOfSearch>(driverId);
        }

        public void CheckFoundFilmContains(string filmName)
        {
            var sourceFilm = filmName.Replace(" ", "").ToLower();
            var targetFilm = resultOfSearchPage.GetTextOfSearchedFilm().Replace(" ", "").ToLower();            
            Assert.IsTrue(targetFilm.Contains(sourceFilm));
        }
    }
}
