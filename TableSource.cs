using System;
using UIKit;
using System.Collections.Generic;
namespace CustomCellTableview.iOS
{
	public class TableSource : UITableViewSource
	{
	


		List<string> tableItems = new List<string>();
		string cellIdentifier="TableCell";


		public TableSource ( List<string> items)
		{
			tableItems = items;
		}
		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return tableItems.Count;
		}
		public override UITableViewCell GetCell (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			var cell = tableView.DequeueReusableCell (cellIdentifier) as CustomCell;
			cell.UpdateCell(tableItems[indexPath.Row]
				, UIImage.FromFile ("Images/ic_facebook.png") );
			return cell;

		}


	}
}

