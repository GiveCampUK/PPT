using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.Core.Logging;

namespace Ppt.DataMigration.Mvp
{
    public class HomePresenter : IPresenter
    {
        ILogger _logger = new NullLogger();
        public ILogger Logger
        {
            get
            {
                return _logger;
            }
            set
            {
                _logger = value;
            }
                
        }

        public 

        IHomeView _view;
        public HomePresenter(
            IHomeView view)
        {
            _logger.Info("Home presenter created");

            _view = view;
        }


    }
}
