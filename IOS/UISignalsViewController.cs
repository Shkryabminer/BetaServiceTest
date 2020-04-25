using Foundation;
using System;
using UIKit;
using Portable;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IOS
{
    public partial class UISignalsViewController : UIViewController,IRecyclerView
    {
      //  UITableView _tableView;
        SignalSource _dataSource;
        List<TradingSignal> _data;
        SignalPresenter _presenter;
        public List<TradingSignal> Data
        {
            get { return _data; }
            set
            {
                _data = value;
                _dataSource.Model = _data;              
                
                 _tableView.ReloadData();
            }
        }

        public UISignalsViewController (IntPtr handle) : base (handle)
        {

        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            _presenter = new SignalPresenter(this);
                       
            _presenter.GetSignal();
            _dataSource = new SignalSource(Data);
            _dataSource.rowSelected += ShowSignal;
            _tableView.Source = _dataSource;
            _tableView.RowHeight = UITableView.AutomaticDimension;
            _tableView.EstimatedRowHeight = 80f;
            _tableView.ReloadData();

        }

        public void SetSignals(List<TradingSignal> model)
        {
            Data = model;
        }
        public override void ViewDidAppear(bool animated)
        {
            _tableView.ReloadData();
        }
        public void ShowSignal(object sender, int nomber)
        {
            var vc = Storyboard.InstantiateViewController("screenView") as ScreenViewController;
            vc.Nomber = nomber;
            vc.ModalPresentationStyle = UIModalPresentationStyle.FullScreen;
            PresentViewController(vc, true, null);
        }
        public override void ViewDidUnload()
        {
            base.ViewDidUnload();
            _dataSource.rowSelected -= ShowSignal;
        }
    }
}