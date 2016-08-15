using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace quotation
{

    public class DeckActivity : Activity
    {
        List<string> ArcherDeckList = new List<string>
        { "Archer   Mid Range   12600   +30", "Archer   Mid Range   11600   +13", "Archer   Mid Range   13100   +5" };
        List<string> AssasianDeckList = new List<string> { };
        List<string> BattleMageDeckList = new List<string> { };
        List<string> CrusaderDeckList = new List<string> { };
        List<string> MageDeckList = new List<string> { };
        List<string> MonkDeckList = new List<string> { };
        List<string> ScoutDeckList = new List<string> { };
        List<string> SorcererDeckList = new List<string> { };
        List<string> SpellswordDeckList = new List<string> { };
        List<string> WarriorDeckList = new List<string> { };

        public string selectedItem;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            selectedItem = Intent.Extras.GetString("selectedItemId");

            //var deck = FindViewById<ImageView>
            if (selectedItem == "0")


            SetContentView(Resource.Layout.Deck_Activity);

        }
    }
}