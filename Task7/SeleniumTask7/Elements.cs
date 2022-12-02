using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTask7
{
    public class Elements
    {
        public IWebElement searchButton;
        /// <summary>
        /// A search icon to search for an item.
        /// </summary>
        public IWebElement value;
        /// <summary>
        /// The name of the item to be searched.
        /// </summary>
        public string searchedValue;
        /// <summary>
        /// String text of name of item searched.
        /// </summary>
        public IWebElement findButton;
        /// <summary>
        /// A clickable button to find results of item to be searched.
        /// </summary>
        public IWebElement searchResult;
        /// <summary>
        /// Web element which displays total count of displayed search result.
        /// </summary>
        public string[] resultCount;
        /// <summary>
        /// String array to get the array of strings contained in searchResult.
        /// </summary>
        public ReadOnlyCollection<IWebElement> resultDescription;
        /// <summary>
        /// A ReadOnlyCollection of Web elements of result description.
        /// </summary>
    }
}
