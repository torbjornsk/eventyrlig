using System;
using System.Drawing;
using System.Collections.Generic;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

using SearchPartyXamarin.REST;

namespace SearchPartyXamariniOs
{


	public partial class AksjonerViewController : UITableViewController
	{


		private class TableViewDataSource : UITableViewDataSource {
			private List<Aksjon> _aksjoner;

			public TableViewDataSource() {
				_aksjoner = AksjonerService.GetAksjoner();
			}

			public override int NumberOfSections (UITableView tableView)
			{
				return 1;
			}

			public override int RowsInSection (UITableView tableView, int section)
			{
				return _aksjoner.Count;
			}

			public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
			{
				String identifier = "aksjonCell";
				UITableViewCell cell = tableView.DequeueReusableCell(identifier);

				if (cell == null) {
					cell = new UITableViewCell (UITableViewCellStyle.Subtitle, identifier);
				}

				var aksjon = _aksjoner [indexPath.Row];
				cell.TextLabel.Text = aksjon.Tittel;
				cell.DetailTextLabel.Text = aksjon.Beskrivelse;

				return cell;
			}
		}

		static bool UserInterfaceIdiomIsPhone {
			get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
		}

		public AksjonerViewController (IntPtr handle) : base (handle)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();


			this.TableView.DataSource = new TableViewDataSource ();
			// Perform any additional setup after loading the view, typically from a nib.
		}


	}
}

