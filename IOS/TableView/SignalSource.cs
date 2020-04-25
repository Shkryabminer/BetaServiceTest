using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using Portable;
using UIKit;

namespace IOS
{
    class SignalSource : UITableViewSource
    {
        List<TradingSignal> _model;
        public event EventHandler<int> rowSelected;
        public List<TradingSignal> Model { get { return _model;  }
            set { if (value is List<TradingSignal>)
                    _model = value;
            }
        } 
        public SignalSource(List<TradingSignal> data)
        {
            _model = data;
        }

        public override bool CanEditRow(UITableView tableView, NSIndexPath indexPath)
        {
            return false;
        }

        public override bool CanMoveRow(UITableView tableView, NSIndexPath indexPath)
        {
            return false;
        }

        public override void CommitEditingStyle(UITableView tableView, UITableViewCellEditingStyle editingStyle, NSIndexPath indexPath)
        {
            base.CommitEditingStyle(tableView, editingStyle, indexPath);
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = (SignalTVC) tableView.DequeueReusableCell("signalCell");
            var item = _model[indexPath.Row];
            if (cell == null)
            {
                cell = new SignalTVC();                
            }
            cell.UpdateCell(item);
            return cell;
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            var count = 0;
            if (_model != null)
                count = _model.Count;
            return count;
        }
        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
           // base.RowSelected(tableView, indexPath);
            if (rowSelected != null)
                rowSelected(this, indexPath.Row);
        }

    }
}