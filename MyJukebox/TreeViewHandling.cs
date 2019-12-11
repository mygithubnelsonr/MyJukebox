using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MyJukebox
{
    public class TreeViewHandling
    {
        /// <summary>
        /// TreeView Nodes anlegen
        /// </summary>
        /// public InitTreeView(TreeView TV )
 
        internal void Init_TV_Logic(TreeView TV, ImageList IL )
        {
            init_TV_Logic(TV, IL);
        }

        private void init_TV_Logic(TreeView tv, ImageList il)
        {
            tv.Nodes.Clear();
            tv.ImageList = il;

            TreeNode tnRoot = new TreeNode("MyJukebox");
            tnRoot.ImageIndex = 0;
            TreeNode tnKatalog = new TreeNode("Katalog");
            tnKatalog.Nodes.Add("katalog_alle", "Alle");
            tnKatalog.ImageIndex = 1;
            TreeNode tnArtist = new TreeNode("Artist");
            tnArtist.Nodes.Add("artist_ alle", "Alle");
            tnArtist.ImageIndex = 2;
            TreeNode tnInterpret = new TreeNode("Interpret");
            tnInterpret.Nodes.Add("interpret_ alle", "Alle");
            tnInterpret.ImageIndex = 3;
            TreeNode tnGenre = new TreeNode("Genre");
            tnGenre.Nodes.Add("genre_ alle", "Alle");
            tnGenre.ImageIndex = 4;

            //    ' Parent Node mit Root
            //xNod = tvlogic.Nodes.Add("root", "My Jukebox", "music");
            //xNod.Tag = "My Music";

            //    ' Childnode Katalog + Child Alle
            //xNod = tvLogic.Nodes.Add ("root\\katalog", "Katalog", "katalog");   //("root", tvwChild, "katalog", "Katalog", "katalog");


            //        xNod.Tag = "alle"
            //    Set xNod = tvLogic.Nodes.Add("katalog", tvwChild, "katalog_alle", "Alle", "katalog")
            //        xNod.Tag = xNod.Text
            //    ' Childnode Album + Child ns
            //    Set xNod = tvLogic.Nodes.Add("root", tvwChild, "album", "Album", "album")
            //        xNod.Tag = "ns"
            //    Set xNod = tvLogic.Nodes.Add("album", tvwChild, "album_ns", "", "album")
            //    ' Childnode Interpret + Child ns
            //    Set xNod = tvLogic.Nodes.Add("root", tvwChild, "interpret", "Interpret", "interpret")
            //        xNod.Tag = "ns"
            //    Set xNod = tvLogic.Nodes.Add("interpret", tvwChild, "interpret_ns", "")
            //    ' Childnode Genre + Child Alle
            //    Set xNod = tvLogic.Nodes.Add("root", tvwChild, "genre", "Genre", "genre")
            //        xNod.Tag = "alle"
            //    Set xNod = tvLogic.Nodes.Add("genre", tvwChild, "genre_alle", "Alle", "genre")
            //        xNod.Expanded = True

            //    Screen.MousePointer = vbDefault

            //    bKatalogFilled = False
            //    bGenreFilled = False
            //    bInterpretFilled = False
            //    bAlbumFilled = False

            //    tvLogic.Nodes(1).Selected = True
            //    tvLogic.Tag = tvLogic.SelectedItem.Key
            //    tvLogic.Nodes(1).Selected = True
            //    tvLogic.Nodes(1).Expanded = True


        }

        internal void Fill_TV_Logic_Katalog()
        {
            //Dim i%, sText$, sPK$, sSql$, sKey$, strGenre$
            //Dim rs As New ADODB.Recordset
            //Dim xNod As Node

           const string cstrQuelle = "Fill_TV_Logic_Kataloge";
           const string cstrMainNode = "katalog";


            //    If tvLogic.Nodes("genre").Tag = "alle" Then
            //        strGenre = "%"
            //    Else
            //        strGenre = tvLogic.Nodes("genre").Tag
            //    End If

            //    sSql = "SELECT DISTINCT " & cstrMainNode & _
            //        " FROM tblMusicDb where genre like " & Chr(34) & strGenre & Chr(34) & _
            //        " order by " & cstrMainNode

            //    If de.connJukebox.state = adStateClosed Then de.connJukebox.Open

            //    With rs
            //        .ActiveConnection = de.connJukebox
            //        .Source = sSql
            //        .Open
            //        .Filter = ""
            //        i = 2

            //        On Error Resume Next

            //        While Not .EOF
            //            i = i + 1
            //            sText = !Katalog
            //            Err.Clear
            //            sKey = LCase("katalog_" & sText)
            //            Set xNod = tvLogic.Nodes.Add("katalog", tvwChild, sKey, sText, "katalog")
            //'            xNod.Tag = CStr(!ID)
            //            xNod.Tag = sText

            //            If Err Then
            //                al.FaultType = alError
            //                al.FaultSource = scQuelle
            //                al.FaultMsg = "Entry " & sText & " already exist"
            //                al.AddEntry
            //            End If
            //            Load pop_flex_sendto_katalog_entries(i)
            //            pop_flex_sendto_katalog_entries(i).Caption = sText
            //            pop_flex_sendto_katalog_entries(i).Tag = !ID
            //            .MoveNext
            //        Wend
            //        .Close
            //    End With

            //    On Error GoTo 0
            //    Set rs = Nothing
            //    Exit Sub

            //Error_Handling:
            //    al.FaultType = alError
            //    al.FaultSource = scQuelle
            //    al.FaultMsg = Err.Description
            //    al.AddEntry

            //    rs.Close
            //    Set rs = Nothing

            //End Sub
        }
    }
}