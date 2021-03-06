﻿using Project_Kittan.Helpers;

namespace Project_Kittan.Models
{
    /// <summary>
    /// Filters class
    /// </summary>
    public class Filters : Observable
    {
        private string _table;
        public string Table
        {
            get => _table;
            set => Set(ref _table, value);
        }

        private string _page;
        public string Page
        {
            get => _page;
            set => Set(ref _page, value);
        }

        private string _form;
        public string Form
        {
            get => _form;
            set => Set(ref _form, value);
        }

        private string _report;
        public string Report
        {
            get => _report;
            set => Set(ref _report, value);
        }

        private string _codeunit;
        public string Codeunit
        {
            get => _codeunit;
            set => Set(ref _codeunit, value);
        }

        private string _query;
        public string Query
        {
            get => _query;
            set => Set(ref _query, value);
        }

        private string _XMLport;
        public string XMLport
        {
            get => _XMLport;
            set => Set(ref _XMLport, value);
        }

        private string _dataport;
        public string Dataport
        {
            get => _dataport;
            set => Set(ref _dataport, value);
        }

        private string _menuSuite;
        public string MenuSuite
        {
            get => _menuSuite;
            set => Set(ref _menuSuite, value);
        }

        /// <summary>
        /// Parameterless constructor of Filters class.
        /// </summary>
        public Filters()
        {
            Table = "";
            Page = "";
            Form = "";
            Report = "";
            Codeunit = "";
            Query = "";
            XMLport = "";
            Dataport = "";
            MenuSuite = "";
        }
    }
}
