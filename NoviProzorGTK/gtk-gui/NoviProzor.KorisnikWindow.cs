
// This file has been generated by the GUI designer. Do not modify.
namespace NoviProzor
{
	public partial class KorisnikWindow
	{
		private global::Gtk.Table table3;
		
		private global::Gtk.Button button2;
		
		private global::Gtk.Entry entryIme;
		
		private global::Gtk.Entry entryPrezime;
		
		private global::Gtk.Label label3;
		
		private global::Gtk.Label label4;
		
		private global::Gtk.Label label5;
		
		private global::Gtk.Label labelID;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget NoviProzor.KorisnikWindow
			this.Name = "NoviProzor.KorisnikWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("Podaci o korisniku");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Modal = true;
			this.BorderWidth = ((uint)(20));
			// Container child NoviProzor.KorisnikWindow.Gtk.Container+ContainerChild
			this.table3 = new global::Gtk.Table (((uint)(4)), ((uint)(2)), false);
			this.table3.Name = "table3";
			this.table3.RowSpacing = ((uint)(6));
			this.table3.ColumnSpacing = ((uint)(6));
			// Container child table3.Gtk.Table+TableChild
			this.button2 = new global::Gtk.Button ();
			this.button2.CanFocus = true;
			this.button2.Name = "button2";
			this.button2.UseUnderline = true;
			this.button2.Label = global::Mono.Unix.Catalog.GetString ("Izmijeni podatke");
			this.table3.Add (this.button2);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table3 [this.button2]));
			w1.TopAttach = ((uint)(3));
			w1.BottomAttach = ((uint)(4));
			w1.RightAttach = ((uint)(2));
			w1.XOptions = ((global::Gtk.AttachOptions)(4));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.entryIme = new global::Gtk.Entry ();
			this.entryIme.WidthRequest = 200;
			this.entryIme.CanFocus = true;
			this.entryIme.Name = "entryIme";
			this.entryIme.IsEditable = true;
			this.entryIme.InvisibleChar = '●';
			this.table3.Add (this.entryIme);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table3 [this.entryIme]));
			w2.TopAttach = ((uint)(1));
			w2.BottomAttach = ((uint)(2));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.entryPrezime = new global::Gtk.Entry ();
			this.entryPrezime.WidthRequest = 200;
			this.entryPrezime.CanFocus = true;
			this.entryPrezime.Name = "entryPrezime";
			this.entryPrezime.IsEditable = true;
			this.entryPrezime.InvisibleChar = '●';
			this.table3.Add (this.entryPrezime);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table3 [this.entryPrezime]));
			w3.TopAttach = ((uint)(2));
			w3.BottomAttach = ((uint)(3));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label ();
			this.label3.WidthRequest = 150;
			this.label3.Name = "label3";
			this.label3.Xpad = 20;
			this.label3.Ypad = 10;
			this.label3.Xalign = 1F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Ime:");
			this.table3.Add (this.label3);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table3 [this.label3]));
			w4.TopAttach = ((uint)(1));
			w4.BottomAttach = ((uint)(2));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label ();
			this.label4.WidthRequest = 150;
			this.label4.Name = "label4";
			this.label4.Xpad = 20;
			this.label4.Ypad = 10;
			this.label4.Xalign = 1F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Prezime:");
			this.table3.Add (this.label4);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table3 [this.label4]));
			w5.TopAttach = ((uint)(2));
			w5.BottomAttach = ((uint)(3));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label ();
			this.label5.WidthRequest = 150;
			this.label5.Name = "label5";
			this.label5.Xpad = 20;
			this.label5.Ypad = 10;
			this.label5.Xalign = 1F;
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("ID:");
			this.table3.Add (this.label5);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table3 [this.label5]));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.labelID = new global::Gtk.Label ();
			this.labelID.Name = "labelID";
			this.labelID.Xalign = 0F;
			this.labelID.LabelProp = global::Mono.Unix.Catalog.GetString ("-");
			this.table3.Add (this.labelID);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table3 [this.labelID]));
			w7.LeftAttach = ((uint)(1));
			w7.RightAttach = ((uint)(2));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			this.Add (this.table3);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 196;
			this.Show ();
			this.button2.Clicked += new global::System.EventHandler (this.IzmijeniPodatke);
		}
	}
}
