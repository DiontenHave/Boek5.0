

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1

    Inherits System.Windows.Forms.Form
    'init 
    Dim objActivity As Object = New DetectActivity
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer


    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.C1SizerMainWindow = New C1.Win.C1Sizer.C1Sizer()
        Me.C1SizerTree = New C1.Win.C1Sizer.C1Sizer()
        Me.TreePanel = New System.Windows.Forms.Panel()
        Me.Tree_BBKlok_cmb = New System.Windows.Forms.ComboBox()
        Me.icon4_pbox = New System.Windows.Forms.PictureBox()
        Me.icon4_chk = New System.Windows.Forms.CheckBox()
        Me.icon3_pbox = New System.Windows.Forms.PictureBox()
        Me.icon3_chk = New System.Windows.Forms.CheckBox()
        Me.icon2_pbox = New System.Windows.Forms.PictureBox()
        Me.icon2_chk = New System.Windows.Forms.CheckBox()
        Me.icon1_pbox = New System.Windows.Forms.PictureBox()
        Me.icon1_chk = New System.Windows.Forms.CheckBox()
        Me.TreeVest2_but = New System.Windows.Forms.Button()
        Me.TreeVest1_but = New System.Windows.Forms.Button()
        Me.TreeVestTotaal_but = New System.Windows.Forms.Button()
        Me.Tree_Update_but = New System.Windows.Forms.Button()
        Me.Tree_Status_lbl = New System.Windows.Forms.Label()
        Me.Tree_Tijd_lbl = New System.Windows.Forms.Label()
        Me.Tree_Datum_lbl = New System.Windows.Forms.Label()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.IconList = New System.Windows.Forms.ImageList(Me.components)
        Me.C1Tab = New C1.Win.C1Command.C1DockingTab()
        Me.C1TabOrderInvoer = New C1.Win.C1Command.C1DockingTabPage()
        Me.C1SizerOrderTab = New C1.Win.C1Sizer.C1Sizer()
        Me.Invoer_WpsFilterCombo = New C1.Win.C1List.C1Combo()
        Me.TabOrdersPanelTop = New System.Windows.Forms.Panel()
        Me.Orders_PlusAccessoires_but = New System.Windows.Forms.Button()
        Me.TestBuild_but = New System.Windows.Forms.Button()
        Me.Order_bakstikkers_chk = New System.Windows.Forms.CheckBox()
        Me.Order_plantenpaspoort_chk = New System.Windows.Forms.CheckBox()
        Me.Order_Prijscor_plusS_but = New System.Windows.Forms.Button()
        Me.Order_Prijscor_minS_but = New System.Windows.Forms.Button()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Order_hoescat_cmb = New System.Windows.Forms.ComboBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Order_fustcat_cmb = New System.Windows.Forms.ComboBox()
        Me.Stikker_lbl = New System.Windows.Forms.Label()
        Me.StickerType_cmb = New System.Windows.Forms.ComboBox()
        Me.Order_aanvulling_chk = New System.Windows.Forms.CheckBox()
        Me.orders_opmerking_opslaan = New System.Windows.Forms.Button()
        Me.Order_OpmTab = New System.Windows.Forms.TabControl()
        Me.opmerking = New System.Windows.Forms.TabPage()
        Me.Order_opmerking_txt = New System.Windows.Forms.TextBox()
        Me.orderinfo = New System.Windows.Forms.TabPage()
        Me.Order_OpmOrderinfo_txt = New System.Windows.Forms.TextBox()
        Me.pakboninfo = New System.Windows.Forms.TabPage()
        Me.Order_Pakboninfo_txt = New System.Windows.Forms.TextBox()
        Me.koper1 = New System.Windows.Forms.TabPage()
        Me.Order_OpmKoper1_txt = New System.Windows.Forms.TextBox()
        Me.koper2 = New System.Windows.Forms.TabPage()
        Me.Order_OpmKoper2_txt = New System.Windows.Forms.TextBox()
        Me.koper3 = New System.Windows.Forms.TabPage()
        Me.Order_OpmKoper3_txt = New System.Windows.Forms.TextBox()
        Me.koper4 = New System.Windows.Forms.TabPage()
        Me.Order_OpmKoper4_txt = New System.Windows.Forms.TextBox()
        Me.koper5 = New System.Windows.Forms.TabPage()
        Me.Order_OpmKoper5_txt = New System.Windows.Forms.TextBox()
        Me.koper6 = New System.Windows.Forms.TabPage()
        Me.Order_OpmKoper6_txt = New System.Windows.Forms.TextBox()
        Me.koper7 = New System.Windows.Forms.TabPage()
        Me.Order_OpmKoper7_txt = New System.Windows.Forms.TextBox()
        Me.koper8 = New System.Windows.Forms.TabPage()
        Me.Order_OpmKoper8_txt = New System.Windows.Forms.TextBox()
        Me.kopertoevoegen = New System.Windows.Forms.TabPage()
        Me.Order_Opm_addcontactpannel = New System.Windows.Forms.Panel()
        Me.Order_Opm_addcontact_but = New System.Windows.Forms.Button()
        Me.Order_Opm_addcontact_lbl = New System.Windows.Forms.Label()
        Me.Order_Opm_addcontact_txt = New System.Windows.Forms.TextBox()
        Me.Order_Prijscor_min_but = New System.Windows.Forms.Button()
        Me.Order_Prijs_correctie_lbl = New System.Windows.Forms.Label()
        Me.Order_Prijscor_plus_but = New System.Windows.Forms.Button()
        Me.Order_Prijscor_prijs_txt = New System.Windows.Forms.TextBox()
        Me.Order_herbereken_prijzen = New System.Windows.Forms.Button()
        Me.Order_reservering_chk = New System.Windows.Forms.CheckBox()
        Me.Order_versie_lbl = New System.Windows.Forms.Label()
        Me.Order_versietxt_lbl = New System.Windows.Forms.Label()
        Me.Order_Slot_Chk = New System.Windows.Forms.CheckBox()
        Me.Order_OverMorgen_but = New System.Windows.Forms.Button()
        Me.Order_idtxt_lbl = New System.Windows.Forms.Label()
        Me.Order_id_lbl = New System.Windows.Forms.Label()
        Me.Order_admnr_txt = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.order_contacts_combo = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Order_Decorum_chk = New System.Windows.Forms.CheckBox()
        Me.Order_koper_combo = New System.Windows.Forms.ComboBox()
        Me.Order_groep5_but = New System.Windows.Forms.Button()
        Me.Order_groep4_but = New System.Windows.Forms.Button()
        Me.Order_groep3_but = New System.Windows.Forms.Button()
        Me.Order_groep2_but = New System.Windows.Forms.Button()
        Me.Order_AflevertijdZA_but = New System.Windows.Forms.Button()
        Me.Order_Vandaag_but = New System.Windows.Forms.Button()
        Me.Order_groep1_but = New System.Windows.Forms.Button()
        Me.Order_InstelOpslaan_but = New System.Windows.Forms.Button()
        Me.Order_Opslaan_but = New System.Windows.Forms.Button()
        Me.Order_prijsopslag_txt = New System.Windows.Forms.TextBox()
        Me.Order_vervoerder_combo = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Order_veilingbrief_combo = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Order_kar_combo = New System.Windows.Forms.ComboBox()
        Me.Order_afleverloc_combo = New System.Windows.Forms.ComboBox()
        Me.Order_admnr_lbl = New System.Windows.Forms.Label()
        Me.Order_ean_lbl = New System.Windows.Forms.Label()
        Me.Order_Aflevertijd17_but = New System.Windows.Forms.Button()
        Me.Order_Aflevertijd12_but = New System.Windows.Forms.Button()
        Me.Order_Aflevertijd9_but = New System.Windows.Forms.Button()
        Me.Order_Aflevertijd_combo = New System.Windows.Forms.ComboBox()
        Me.Order_Morgen_but = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OrderDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Order_invoer_FlexGrid = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1TabKarindeling = New C1.Win.C1Command.C1DockingTabPage()
        Me.C1SizerKarIndeling = New C1.Win.C1Sizer.C1Sizer()
        Me.PanelKarindelingOnder = New System.Windows.Forms.Panel()
        Me.Kar_markeer_chk = New System.Windows.Forms.CheckBox()
        Me.Kar_SortMartin_but = New System.Windows.Forms.Button()
        Me.Kar_opnieuwberekeneninvoer_but = New System.Windows.Forms.Button()
        Me.Kar_verdelenals2_but = New System.Windows.Forms.Button()
        Me.Kar_allesop1_but = New System.Windows.Forms.Button()
        Me.Kar_opnieuwberekenen_but = New System.Windows.Forms.Button()
        Me.Kar_opslaan2_but = New System.Windows.Forms.Button()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.PanelKarindelingMidden = New System.Windows.Forms.Panel()
        Me.Kar_Kartype4_cmb = New System.Windows.Forms.ComboBox()
        Me.Kar_Kartype3_cmb = New System.Windows.Forms.ComboBox()
        Me.Kar_Kartype2_cmb = New System.Windows.Forms.ComboBox()
        Me.Kar_Kartype1_cmb = New System.Windows.Forms.ComboBox()
        Me.Kar_fdverzonden4_chk = New System.Windows.Forms.CheckBox()
        Me.Kar_fdverzonden3_chk = New System.Windows.Forms.CheckBox()
        Me.Kar_fdverzonden2_chk = New System.Windows.Forms.CheckBox()
        Me.Kar_fdverzonden1_chk = New System.Windows.Forms.CheckBox()
        Me.KarCommand4_but = New System.Windows.Forms.Button()
        Me.KarCommand4_cmb = New System.Windows.Forms.ComboBox()
        Me.KarCommand3_but = New System.Windows.Forms.Button()
        Me.KarCommand3_cmb = New System.Windows.Forms.ComboBox()
        Me.KarCommand2_but = New System.Windows.Forms.Button()
        Me.KarCommand2_cmb = New System.Windows.Forms.ComboBox()
        Me.KarCommand1_but = New System.Windows.Forms.Button()
        Me.KarCommand1_cmb = New System.Windows.Forms.ComboBox()
        Me.kar_overgooien4_wis_but = New System.Windows.Forms.Button()
        Me.kar_overgooien4_hierop_but = New System.Windows.Forms.Button()
        Me.kar_overgooien4_naar_but = New System.Windows.Forms.Button()
        Me.kar_overgooien3_wis_but = New System.Windows.Forms.Button()
        Me.kar_overgooien3_hierop_but = New System.Windows.Forms.Button()
        Me.kar_overgooien3_naar_but = New System.Windows.Forms.Button()
        Me.kar_overgooien2_wis_but = New System.Windows.Forms.Button()
        Me.kar_overgooien2_hierop_but = New System.Windows.Forms.Button()
        Me.kar_overgooien2_naar_but = New System.Windows.Forms.Button()
        Me.kar_overgooien1_wis_but = New System.Windows.Forms.Button()
        Me.kar_overgooien1_hierop_but = New System.Windows.Forms.Button()
        Me.kar_overgooien1_naar_but = New System.Windows.Forms.Button()
        Me.kar_aanvulling4_but = New System.Windows.Forms.Button()
        Me.kar_aanvulling3_but = New System.Windows.Forms.Button()
        Me.kar_aanvulling2_but = New System.Windows.Forms.Button()
        Me.kar_aanvulling1_but = New System.Windows.Forms.Button()
        Me.Kar_lagenlock4_but = New System.Windows.Forms.Button()
        Me.Kar_lagenlock3_but = New System.Windows.Forms.Button()
        Me.Kar_lagenlock2_but = New System.Windows.Forms.Button()
        Me.Kar_lagenlock1_but = New System.Windows.Forms.Button()
        Me.Kar_autosamenvoegen4_chk = New System.Windows.Forms.CheckBox()
        Me.Kar_autosamenvoegen3_chk = New System.Windows.Forms.CheckBox()
        Me.Kar_autosamenvoegen2_chk = New System.Windows.Forms.CheckBox()
        Me.Kar_autosamenvoegen1_chk = New System.Windows.Forms.CheckBox()
        Me.Kar_nummer4_lbl = New System.Windows.Forms.Label()
        Me.Kar_nummer3_lbl = New System.Windows.Forms.Label()
        Me.Kar_nummer2_lbl = New System.Windows.Forms.Label()
        Me.Kar_nummer1_lbl = New System.Windows.Forms.Label()
        Me.Kar_lagen4_lbl = New System.Windows.Forms.Label()
        Me.Kar_lagen4_txt = New System.Windows.Forms.TextBox()
        Me.Kar_vervoer4_chk = New System.Windows.Forms.CheckBox()
        Me.Kar_sdfverzonden4_chk = New System.Windows.Forms.CheckBox()
        Me.Kar_flexgrid4 = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Kar_rfid4_lbl = New System.Windows.Forms.Label()
        Me.Kar_barcode4_lbl = New System.Windows.Forms.Label()
        Me.Kar_rfid4_txt = New System.Windows.Forms.TextBox()
        Me.Kar_barcode4_txt = New System.Windows.Forms.TextBox()
        Me.Kar_aantaltotaal4_lbl = New System.Windows.Forms.Label()
        Me.Kar_down4_but = New System.Windows.Forms.Button()
        Me.Kar_up4_but = New System.Windows.Forms.Button()
        Me.Kar_plus4_but = New System.Windows.Forms.Button()
        Me.Kar_lagen3_lbl = New System.Windows.Forms.Label()
        Me.Kar_lagen3_txt = New System.Windows.Forms.TextBox()
        Me.Kar_vervoer3_chk = New System.Windows.Forms.CheckBox()
        Me.Kar_sdfverzonden3_chk = New System.Windows.Forms.CheckBox()
        Me.Kar_flexgrid3 = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Kar_rfid3_lbl = New System.Windows.Forms.Label()
        Me.Kar_barcode3_lbl = New System.Windows.Forms.Label()
        Me.Kar_rfid3_txt = New System.Windows.Forms.TextBox()
        Me.Kar_barcode3_txt = New System.Windows.Forms.TextBox()
        Me.Kar_aantaltotaal3_lbl = New System.Windows.Forms.Label()
        Me.Kar_down3_but = New System.Windows.Forms.Button()
        Me.Kar_up3_but = New System.Windows.Forms.Button()
        Me.Kar_plus3_but = New System.Windows.Forms.Button()
        Me.Kar_lagen2_lbl = New System.Windows.Forms.Label()
        Me.Kar_lagen2_txt = New System.Windows.Forms.TextBox()
        Me.Kar_vervoer2_chk = New System.Windows.Forms.CheckBox()
        Me.Kar_sdfverzonden2_chk = New System.Windows.Forms.CheckBox()
        Me.Kar_flexgrid2 = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Kar_rfid2_lbl = New System.Windows.Forms.Label()
        Me.Kar_barcode2_lbl = New System.Windows.Forms.Label()
        Me.Kar_rfid2_txt = New System.Windows.Forms.TextBox()
        Me.Kar_barcode2_txt = New System.Windows.Forms.TextBox()
        Me.Kar_aantaltotaal2_lbl = New System.Windows.Forms.Label()
        Me.Kar_down2_but = New System.Windows.Forms.Button()
        Me.Kar_up2_but = New System.Windows.Forms.Button()
        Me.Kar_plus2_but = New System.Windows.Forms.Button()
        Me.Kar_lagen1_lbl = New System.Windows.Forms.Label()
        Me.Kar_lagen1_txt = New System.Windows.Forms.TextBox()
        Me.Kar_vervoer1_chk = New System.Windows.Forms.CheckBox()
        Me.Kar_sdfverzonden1_chk = New System.Windows.Forms.CheckBox()
        Me.Kar_flexgrid1 = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Kar_rfid1_lbl = New System.Windows.Forms.Label()
        Me.Kar_barcode1_lbl = New System.Windows.Forms.Label()
        Me.Kar_rfid1_txt = New System.Windows.Forms.TextBox()
        Me.Kar_barcode1_txt = New System.Windows.Forms.TextBox()
        Me.Kar_aantaltotaal1_lbl = New System.Windows.Forms.Label()
        Me.Kar_down1_but = New System.Windows.Forms.Button()
        Me.Kar_up1_but = New System.Windows.Forms.Button()
        Me.Kar_plus1_but = New System.Windows.Forms.Button()
        Me.PanelKarIndelingBoven = New System.Windows.Forms.Panel()
        Me.KarBut40 = New System.Windows.Forms.Button()
        Me.KarBut35 = New System.Windows.Forms.Button()
        Me.kar_wissel_vestiging_but = New System.Windows.Forms.Button()
        Me.Kar_vestiging_lbl = New System.Windows.Forms.Label()
        Me.KarOrder_versie_lbl = New System.Windows.Forms.Label()
        Me.Kar_karvoorkeur_lbl = New System.Windows.Forms.Label()
        Me.Kar_selectietot_lbl = New System.Windows.Forms.Label()
        Me.Kar_selectie_txt = New System.Windows.Forms.TextBox()
        Me.KarBut20 = New System.Windows.Forms.Button()
        Me.KarBut16 = New System.Windows.Forms.Button()
        Me.KarBut12 = New System.Windows.Forms.Button()
        Me.KarBut10 = New System.Windows.Forms.Button()
        Me.KarBut9 = New System.Windows.Forms.Button()
        Me.KarBut8 = New System.Windows.Forms.Button()
        Me.KarBut7 = New System.Windows.Forms.Button()
        Me.KarBut6 = New System.Windows.Forms.Button()
        Me.KarBut5 = New System.Windows.Forms.Button()
        Me.KarBut4 = New System.Windows.Forms.Button()
        Me.KarBut3 = New System.Windows.Forms.Button()
        Me.KarBut2 = New System.Windows.Forms.Button()
        Me.KarBut1 = New System.Windows.Forms.Button()
        Me.KarBut100 = New System.Windows.Forms.Button()
        Me.Kar_kopernaam_lbl = New System.Windows.Forms.Label()
        Me.C1TabFloriday = New C1.Win.C1Command.C1DockingTabPage()
        Me.C1SizerFloriday = New C1.Win.C1Sizer.C1Sizer()
        Me.PanelFloridayorders = New System.Windows.Forms.Panel()
        Me.Floriday_Filterstoepassen_but = New System.Windows.Forms.Button()
        Me.Floriday_orderlineherstellen_but = New System.Windows.Forms.Button()
        Me.FDLineCombo = New C1.Win.C1List.C1Combo()
        Me.FloridayOrderInfo_flx = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.FloridayOrderLines_flx = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.FloridayOrders_flx = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1TabFlorecom = New C1.Win.C1Command.C1DockingTabPage()
        Me.C1SizerFlorecom = New C1.Win.C1Sizer.C1Sizer()
        Me.Fc_ContactCombo = New C1.Win.C1List.C1Combo()
        Me.Fc_LineCombo = New C1.Win.C1List.C1Combo()
        Me.Fc_Flexgrid_LineData = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.FC_Flexgrid_contactdata = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.FC_Flexgrid_orderlines = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.FC_Flexgrid_orderlijst = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.FlorecomDel_menuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteFlorecomMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.C1TabVervoer = New C1.Win.C1Command.C1DockingTabPage()
        Me.SizerVervoer = New C1.Win.C1Sizer.C1Sizer()
        Me.Vervoer_Listbox = New System.Windows.Forms.ListBox()
        Me.Vervoer_Treeview = New System.Windows.Forms.TreeView()
        Me.Vervoer_PanelRechts = New System.Windows.Forms.Panel()
        Me.vervoer_vervoerder_klant_but = New System.Windows.Forms.Button()
        Me.vervoer_afleverloc_klant_but = New System.Windows.Forms.Button()
        Me.vervoer_omboek_vervoerder_cmb = New System.Windows.Forms.ComboBox()
        Me.vervoer_omboek_afleverloc_cmb = New System.Windows.Forms.ComboBox()
        Me.vervoer_vervoerder_order_but = New System.Windows.Forms.Button()
        Me.vervoer_afleverloc_order_but = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Vervoer_MonthCalendar = New System.Windows.Forms.MonthCalendar()
        Me.Vervoer_PanelLinks = New System.Windows.Forms.Panel()
        Me.Vervoer_OphalenSelectie_but = New System.Windows.Forms.Button()
        Me.vervoer_karrentotaal_lbl = New System.Windows.Forms.Label()
        Me.Vervoer_OverzichtDeSelectAll = New System.Windows.Forms.Button()
        Me.Vervoer_OverzichtSelectAll = New System.Windows.Forms.Button()
        Me.vervoer_wordtopgehaald_but = New System.Windows.Forms.Button()
        Me.Vervoer_VervoerderMail_but = New System.Windows.Forms.Button()
        Me.Vervoer_OverzichtPrint_but = New System.Windows.Forms.Button()
        Me.Vervoer_Vervoerder_cmb = New System.Windows.Forms.ComboBox()
        Me.Vervoer_OphalenBrieven_but = New System.Windows.Forms.Button()
        Me.C1TabOverzichten = New C1.Win.C1Command.C1DockingTabPage()
        Me.OverzichtSizer1 = New C1.Win.C1Sizer.C1Sizer()
        Me.OverzichtSizer2 = New C1.Win.C1Sizer.C1Sizer()
        Me.Overzicht_FlexGrid = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Overzicht_Panel = New System.Windows.Forms.Panel()
        Me.Overzicht_ExcelExport_but = New System.Windows.Forms.Button()
        Me.overzicht_week_lbl = New System.Windows.Forms.Label()
        Me.Overzicht_soortgroep_chk = New System.Windows.Forms.CheckBox()
        Me.Overzicht_TotaalNieuw_cmb = New System.Windows.Forms.ComboBox()
        Me.Overzicht_Soortgroep_cmb = New System.Windows.Forms.ComboBox()
        Me.Overzicht_gegevensophalen_but = New System.Windows.Forms.Button()
        Me.Overzicht_klantspecifiek_chk = New System.Windows.Forms.CheckBox()
        Me.Overzicht_klantspecifiek_cmb = New System.Windows.Forms.ComboBox()
        Me.Overzicht_MonthCalendar = New System.Windows.Forms.MonthCalendar()
        Me.Overzicht_PictureBox = New System.Windows.Forms.PictureBox()
        Me.C1TabDatabase = New C1.Win.C1Command.C1DockingTabPage()
        Me.C1Sizer1 = New C1.Win.C1Sizer.C1Sizer()
        Me.DatabaseComboWpsFilter = New C1.Win.C1List.C1Combo()
        Me.DatabaseFlexGridEdit = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.DatabaseFlexGridShow = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1TabInstellingen = New C1.Win.C1Command.C1DockingTabPage()
        Me.Inst_paspoortb2_txt = New System.Windows.Forms.TextBox()
        Me.Inst_paspoortb1_txt = New System.Windows.Forms.TextBox()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Inst_paspoort2_txt = New System.Windows.Forms.TextBox()
        Me.Inst_paspoort1_txt = New System.Windows.Forms.TextBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.inst_dfdkleinprint = New System.Windows.Forms.CheckBox()
        Me.inst_database_boekjenp = New System.Windows.Forms.CheckBox()
        Me.inst_boekreload_lbl = New System.Windows.Forms.Label()
        Me.ActivityTimer_lbl = New System.Windows.Forms.Label()
        Me.Inst_printerselect_chk = New System.Windows.Forms.CheckBox()
        Me.Inst_printerip_txt = New System.Windows.Forms.TextBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Inst_Login8_T_chk = New System.Windows.Forms.CheckBox()
        Me.Inst_Login7_T_chk = New System.Windows.Forms.CheckBox()
        Me.Inst_Login6_T_chk = New System.Windows.Forms.CheckBox()
        Me.Inst_Login5_T_chk = New System.Windows.Forms.CheckBox()
        Me.Inst_Login4_T_chk = New System.Windows.Forms.CheckBox()
        Me.Inst_Login3_T_chk = New System.Windows.Forms.CheckBox()
        Me.Inst_Login2_T_chk = New System.Windows.Forms.CheckBox()
        Me.Inst_Login1_T_chk = New System.Windows.Forms.CheckBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Inst_Login8_v2_chk = New System.Windows.Forms.CheckBox()
        Me.Inst_Login7_v2_chk = New System.Windows.Forms.CheckBox()
        Me.Inst_Login6_v2_chk = New System.Windows.Forms.CheckBox()
        Me.Inst_Login5_v2_chk = New System.Windows.Forms.CheckBox()
        Me.Inst_Login4_v2_chk = New System.Windows.Forms.CheckBox()
        Me.Inst_Login3_v2_chk = New System.Windows.Forms.CheckBox()
        Me.Inst_Login2_v2_chk = New System.Windows.Forms.CheckBox()
        Me.Inst_Login1_v2_chk = New System.Windows.Forms.CheckBox()
        Me.Inst_Overig_GB = New System.Windows.Forms.GroupBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Inst_oboektijd7_txt = New System.Windows.Forms.TextBox()
        Me.Inst_odag7_ud = New System.Windows.Forms.NumericUpDown()
        Me.Inst_o7_chk = New System.Windows.Forms.CheckBox()
        Me.Inst_ochktijd7_txt = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Inst_oboektijd6_txt = New System.Windows.Forms.TextBox()
        Me.Inst_odag6_ud = New System.Windows.Forms.NumericUpDown()
        Me.Inst_o6_chk = New System.Windows.Forms.CheckBox()
        Me.Inst_ochktijd6_txt = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Inst_oboektijd5_txt = New System.Windows.Forms.TextBox()
        Me.Inst_odag5_ud = New System.Windows.Forms.NumericUpDown()
        Me.Inst_o5_chk = New System.Windows.Forms.CheckBox()
        Me.Inst_ochktijd5_txt = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Inst_oboektijd4_txt = New System.Windows.Forms.TextBox()
        Me.Inst_odag4_ud = New System.Windows.Forms.NumericUpDown()
        Me.Inst_o4_chk = New System.Windows.Forms.CheckBox()
        Me.Inst_ochktijd4_txt = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Inst_oboektijd3_txt = New System.Windows.Forms.TextBox()
        Me.Inst_odag3_ud = New System.Windows.Forms.NumericUpDown()
        Me.Inst_o3_chk = New System.Windows.Forms.CheckBox()
        Me.Inst_ochktijd3_txt = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Inst_oboektijd2_txt = New System.Windows.Forms.TextBox()
        Me.Inst_odag2_ud = New System.Windows.Forms.NumericUpDown()
        Me.Inst_o2_chk = New System.Windows.Forms.CheckBox()
        Me.Inst_ochktijd2_txt = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Inst_oboektijd1_txt = New System.Windows.Forms.TextBox()
        Me.Inst_odag1_ud = New System.Windows.Forms.NumericUpDown()
        Me.Inst_o1_chk = New System.Windows.Forms.CheckBox()
        Me.Inst_ochktijd1_txt = New System.Windows.Forms.TextBox()
        Me.Inst_Vervoer_annuleren_but = New System.Windows.Forms.Button()
        Me.Inst_Vervoer_opslaan_but = New System.Windows.Forms.Button()
        Me.Inst_Westland_GB = New System.Windows.Forms.GroupBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Inst_wboektijd7_txt = New System.Windows.Forms.TextBox()
        Me.Inst_wdag7_ud = New System.Windows.Forms.NumericUpDown()
        Me.Inst_w7_chk = New System.Windows.Forms.CheckBox()
        Me.Inst_wchktijd7_txt = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Inst_wboektijd6_txt = New System.Windows.Forms.TextBox()
        Me.Inst_wdag6_ud = New System.Windows.Forms.NumericUpDown()
        Me.Inst_w6_chk = New System.Windows.Forms.CheckBox()
        Me.Inst_wchktijd6_txt = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Inst_wboektijd5_txt = New System.Windows.Forms.TextBox()
        Me.Inst_wdag5_ud = New System.Windows.Forms.NumericUpDown()
        Me.Inst_w5_chk = New System.Windows.Forms.CheckBox()
        Me.Inst_wchktijd5_txt = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Inst_wboektijd4_txt = New System.Windows.Forms.TextBox()
        Me.Inst_wdag4_ud = New System.Windows.Forms.NumericUpDown()
        Me.Inst_w4_chk = New System.Windows.Forms.CheckBox()
        Me.Inst_wchktijd4_txt = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Inst_wboektijd3_txt = New System.Windows.Forms.TextBox()
        Me.Inst_wdag3_ud = New System.Windows.Forms.NumericUpDown()
        Me.Inst_w3_chk = New System.Windows.Forms.CheckBox()
        Me.Inst_wchktijd3_txt = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Inst_wboektijd2_txt = New System.Windows.Forms.TextBox()
        Me.Inst_wdag2_ud = New System.Windows.Forms.NumericUpDown()
        Me.Inst_w2_chk = New System.Windows.Forms.CheckBox()
        Me.Inst_wchktijd2_txt = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Inst_wboektijd1_txt = New System.Windows.Forms.TextBox()
        Me.Inst_wdag1_ud = New System.Windows.Forms.NumericUpDown()
        Me.Inst_w1_chk = New System.Windows.Forms.CheckBox()
        Me.Inst_wchktijd1_txt = New System.Windows.Forms.TextBox()
        Me.Inst_Vervoer_aanpassen_but = New System.Windows.Forms.Button()
        Me.Inst_dag_lbl = New System.Windows.Forms.Label()
        Me.Inst_vervoerstijden_lbl = New System.Windows.Forms.Label()
        Me.Inst_weekdag_cmb = New System.Windows.Forms.ComboBox()
        Me.Inst_barcodeserver = New System.Windows.Forms.CheckBox()
        Me.Inst_Login8_v1_chk = New System.Windows.Forms.CheckBox()
        Me.Inst_Login7_v1_chk = New System.Windows.Forms.CheckBox()
        Me.Inst_Login6_v1_chk = New System.Windows.Forms.CheckBox()
        Me.Inst_Login5_v1_chk = New System.Windows.Forms.CheckBox()
        Me.Inst_Login4_v1_chk = New System.Windows.Forms.CheckBox()
        Me.Inst_Login3_v1_chk = New System.Windows.Forms.CheckBox()
        Me.Inst_Login2_v1_chk = New System.Windows.Forms.CheckBox()
        Me.Inst_Login1_v1_chk = New System.Windows.Forms.CheckBox()
        Me.Inst_test_server = New System.Windows.Forms.Button()
        Me.Inst_Login8_Txt = New System.Windows.Forms.TextBox()
        Me.SettingsLogin8 = New System.Windows.Forms.Label()
        Me.Inst_Login7_Txt = New System.Windows.Forms.TextBox()
        Me.SettingsLogin7 = New System.Windows.Forms.Label()
        Me.Inst_Login6_Txt = New System.Windows.Forms.TextBox()
        Me.SettingsLogin6 = New System.Windows.Forms.Label()
        Me.Inst_Login5_Txt = New System.Windows.Forms.TextBox()
        Me.SettingsLogin5 = New System.Windows.Forms.Label()
        Me.Inst_Login4_Txt = New System.Windows.Forms.TextBox()
        Me.SettingsLogin4 = New System.Windows.Forms.Label()
        Me.Inst_Login3_Txt = New System.Windows.Forms.TextBox()
        Me.SettingsLogin3 = New System.Windows.Forms.Label()
        Me.Inst_Login2_Txt = New System.Windows.Forms.TextBox()
        Me.SettingsLogin2 = New System.Windows.Forms.Label()
        Me.Inst_Login1_Txt = New System.Windows.Forms.TextBox()
        Me.SettingsLogin1 = New System.Windows.Forms.Label()
        Me.Inst_MySQLPass_Txt = New System.Windows.Forms.TextBox()
        Me.SettingsMySQL_lbl4 = New System.Windows.Forms.Label()
        Me.Inst_MySQLUser_Txt = New System.Windows.Forms.TextBox()
        Me.SettingsMySQL_lbl3 = New System.Windows.Forms.Label()
        Me.Inst_MySQLServer_Txt = New System.Windows.Forms.TextBox()
        Me.SettingsMySQL_lbl2 = New System.Windows.Forms.Label()
        Me.Inst_MySQLODBC_Txt = New System.Windows.Forms.TextBox()
        Me.SettingsMySQL_lbl1 = New System.Windows.Forms.Label()
        Me.C1TabPrijzen = New C1.Win.C1Command.C1DockingTabPage()
        Me.Prijzen_sizer = New C1.Win.C1Sizer.C1Sizer()
        Me.C1prijzensizer3 = New C1.Win.C1Sizer.C1Sizer()
        Me.prijzenpanelmidleft = New System.Windows.Forms.Panel()
        Me.prijzen_actiecode = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.prijzen_accessoire_chk = New System.Windows.Forms.CheckBox()
        Me.prijzen_id_lbl = New System.Windows.Forms.Label()
        Me.prijzen_jaar_lbl = New System.Windows.Forms.Label()
        Me.prijzen_jaar_updown = New System.Windows.Forms.NumericUpDown()
        Me.prijzen_actief_check = New System.Windows.Forms.CheckBox()
        Me.prijzen_naam_txt = New System.Windows.Forms.TextBox()
        Me.prijzen_soort_combo = New System.Windows.Forms.ComboBox()
        Me.prijzen_naam_lbl = New System.Windows.Forms.Label()
        Me.prijzen_koper_combo = New System.Windows.Forms.ComboBox()
        Me.prijzen_soort_lbl = New System.Windows.Forms.Label()
        Me.prijzen_klant_rb = New System.Windows.Forms.RadioButton()
        Me.prijzen_kopergroep_combo = New System.Windows.Forms.ComboBox()
        Me.prijzen_algemeen_rb = New System.Windows.Forms.RadioButton()
        Me.prijzen_klantgroep_rb = New System.Windows.Forms.RadioButton()
        Me.prijzenpanelmidright = New System.Windows.Forms.Panel()
        Me.prijzen_idsel_lbl = New System.Windows.Forms.Label()
        Me.prijzen_verwijderdatum_but = New System.Windows.Forms.Button()
        Me.prijzen_toevoegendatum_but = New System.Windows.Forms.Button()
        Me.prijzen_prijs_lbl = New System.Windows.Forms.Label()
        Me.prijzen_prijs_txt = New System.Windows.Forms.TextBox()
        Me.prijzen_datum_pick = New System.Windows.Forms.DateTimePicker()
        Me.Prijzen_PictureBox = New System.Windows.Forms.PictureBox()
        Me.Prijzen_Sizer2 = New C1.Win.C1Sizer.C1Sizer()
        Me.Prijzen_flexgrid_soorten = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.prijzen_flexgrid_datums = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1TabVoorraad = New C1.Win.C1Command.C1DockingTabPage()
        Me.C1SizerVoorraad = New C1.Win.C1Sizer.C1Sizer()
        Me.Voorraad_Flexgrid = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.PanelVoorraad = New System.Windows.Forms.Panel()
        Me.Voorraad_aanpassen_but = New System.Windows.Forms.Button()
        Me.voorraad_nieuw_but = New System.Windows.Forms.Button()
        Me.GroupBoxVoorraad = New System.Windows.Forms.GroupBox()
        Me.voorraad_annuleer_but = New System.Windows.Forms.Button()
        Me.Voorraad_Besteld_chk = New System.Windows.Forms.CheckBox()
        Me.voorraad_koppelingfust5_cmb = New System.Windows.Forms.ComboBox()
        Me.voorraad_koppelingacce3_cmb = New System.Windows.Forms.ComboBox()
        Me.voorraad_koppelingacce2_cmb = New System.Windows.Forms.ComboBox()
        Me.voorraad_koppelingfust4_cmb = New System.Windows.Forms.ComboBox()
        Me.voorraad_koppelingfust3_cmb = New System.Windows.Forms.ComboBox()
        Me.voorraad_koppelingfust2_cmb = New System.Windows.Forms.ComboBox()
        Me.voorraad_id = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.voorraad_opslaan_but = New System.Windows.Forms.Button()
        Me.voorraad_inkoopstuks_but = New System.Windows.Forms.Button()
        Me.voorraad_inkooppallets_but = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.voorraad_koppelingacce1_cmb = New System.Windows.Forms.ComboBox()
        Me.voorraad_koppelingfust1_cmb = New System.Windows.Forms.ComboBox()
        Me.voorraad_koppelingacce_radio = New System.Windows.Forms.RadioButton()
        Me.voorraad_koppelingfust_radio = New System.Windows.Forms.RadioButton()
        Me.voorraad_besteltijd_txt = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.voorraad_aantalperpallet_txt = New System.Windows.Forms.TextBox()
        Me.voorraad_minimum_txt = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.voorraad_waarschuwing_chk = New System.Windows.Forms.CheckBox()
        Me.voorraad_voorraad_txt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.voorraad_inkoopstuks_txt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.voorraad_inkooppallets_txt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.voorraad_artikelnaam_txt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.voorraad_bereken_but = New System.Windows.Forms.Button()
        Me.C1TabWPS = New C1.Win.C1Command.C1DockingTabPage()
        Me.C1SizerWpsFilters = New C1.Win.C1Sizer.C1Sizer()
        Me.WpsFilter_flexcombo = New C1.Win.C1List.C1Combo()
        Me.PanelWpsFilterMidBar = New System.Windows.Forms.Panel()
        Me.WpsFilter_filternaam_lbl = New System.Windows.Forms.Label()
        Me.WpsFilter_filternaam_txt = New System.Windows.Forms.TextBox()
        Me.WpsFilter_FilterOpslaan_but = New System.Windows.Forms.Button()
        Me.PanelWpsFilterTopBar = New System.Windows.Forms.Panel()
        Me.WpsFilter_koperIndelingOphalen_but = New System.Windows.Forms.Button()
        Me.PanelWpsFilter = New System.Windows.Forms.Panel()
        Me.WpsFilter_Scrollbar = New System.Windows.Forms.HScrollBar()
        Me.WpsFilter_Instel5_but = New System.Windows.Forms.Button()
        Me.WpsFilter_Instel4_but = New System.Windows.Forms.Button()
        Me.WpsFilter_Instel3_but = New System.Windows.Forms.Button()
        Me.WpsFilter_Instel2_but = New System.Windows.Forms.Button()
        Me.WpsFilter_Instel1_but = New System.Windows.Forms.Button()
        Me.WpsFilter_ChkList5_lst = New System.Windows.Forms.CheckedListBox()
        Me.WpsFilter_ChkList4_lst = New System.Windows.Forms.CheckedListBox()
        Me.WpsFilter_ChkList3_lst = New System.Windows.Forms.CheckedListBox()
        Me.WpsFilter_ChkList2_lst = New System.Windows.Forms.CheckedListBox()
        Me.WpsFilter_ChkList1_lst = New System.Windows.Forms.CheckedListBox()
        Me.WpsFilter_Add5_but = New System.Windows.Forms.Button()
        Me.WpsFilter_Add4_but = New System.Windows.Forms.Button()
        Me.WpsFilter_Add3_but = New System.Windows.Forms.Button()
        Me.WpsFilter_Add2_but = New System.Windows.Forms.Button()
        Me.WpsFilter_Add1_but = New System.Windows.Forms.Button()
        Me.WpsFilter_FilterFlex = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1TabInloggen = New C1.Win.C1Command.C1DockingTabPage()
        Me.C1SizerInloggen = New C1.Win.C1Sizer.C1Sizer()
        Me.LoginPanelDown = New System.Windows.Forms.Panel()
        Me.AgendaFlexGrid = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.LoginPanelup = New System.Windows.Forms.Panel()
        Me.Inloglijst_lst = New System.Windows.Forms.ListBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Inlog_agenda_invullen_txt = New System.Windows.Forms.TextBox()
        Me.Inlog_opslaan_agenda_but = New System.Windows.Forms.Button()
        Me.Tdebug = New System.Windows.Forms.Label()
        Me.Inlog_Datum_but = New System.Windows.Forms.Button()
        Me.InlogAgendaDatum = New System.Windows.Forms.DateTimePicker()
        Me.inlogdatum_lbl = New System.Windows.Forms.Label()
        Me.LoginNaam1_but = New System.Windows.Forms.Button()
        Me.LoginNaam8_but = New System.Windows.Forms.Button()
        Me.LoginNaam2_but = New System.Windows.Forms.Button()
        Me.LoginNaam7_but = New System.Windows.Forms.Button()
        Me.LoginNaam3_but = New System.Windows.Forms.Button()
        Me.LoginNaam6_but = New System.Windows.Forms.Button()
        Me.LoginNaam4_but = New System.Windows.Forms.Button()
        Me.LoginNaam5_but = New System.Windows.Forms.Button()
        Me.C1NavBar1 = New C1.Win.C1Command.C1NavBar()
        Me.C1NavBarPanelOrders = New C1.Win.C1Command.C1NavBarPanel()
        Me.C1NavPanelOrders2 = New System.Windows.Forms.Panel()
        Me.OrdersMenuBekijken = New System.Windows.Forms.Button()
        Me.Orders_pakbonnenprinten = New System.Windows.Forms.Button()
        Me.OrdersMenuVerzamelkar = New System.Windows.Forms.Button()
        Me.Order_PrintBriefFloriday = New System.Windows.Forms.Button()
        Me.OrdersMenuAanvulling = New System.Windows.Forms.Button()
        Me.Orders_WpsXML_but = New System.Windows.Forms.Button()
        Me.Orders_Mark = New System.Windows.Forms.Button()
        Me.Orders_WpsKlaar = New System.Windows.Forms.Button()
        Me.Orders_SdfVersturen = New System.Windows.Forms.Button()
        Me.Orders_WpsVersturen = New System.Windows.Forms.Button()
        Me.Orders_Karindeling = New System.Windows.Forms.Button()
        Me.Order_zoek_but = New System.Windows.Forms.Button()
        Me.Order_zoek_txt = New System.Windows.Forms.TextBox()
        Me.Order_zoeken_chk = New System.Windows.Forms.CheckBox()
        Me.OrdersMenuAnnuleren = New System.Windows.Forms.Button()
        Me.OrdersMenuSamenvoegen = New System.Windows.Forms.Button()
        Me.OrdersMenuAanpassen = New System.Windows.Forms.Button()
        Me.OrdersMenuNieuw = New System.Windows.Forms.Button()
        Me.C1NavPanelOrders1 = New System.Windows.Forms.Panel()
        Me.Order_MonthCalendar = New System.Windows.Forms.MonthCalendar()
        Me.C1NavBarFloriday = New C1.Win.C1Command.C1NavBarPanel()
        Me.FdMenu_Nietverwerken_but = New System.Windows.Forms.Button()
        Me.FdMenu_ordernr_chk = New System.Windows.Forms.CheckBox()
        Me.fd_updatelist_but = New System.Windows.Forms.Button()
        Me.Fd_archief_rb = New System.Windows.Forms.RadioButton()
        Me.Fd_nieuweOrders_rb = New System.Windows.Forms.RadioButton()
        Me.Floriday_Calendar = New System.Windows.Forms.MonthCalendar()
        Me.FdMenu_Zoek_chk = New System.Windows.Forms.CheckBox()
        Me.FdMenu_Zoek_txt = New System.Windows.Forms.TextBox()
        Me.FdMenu_floridaynr_txt = New System.Windows.Forms.TextBox()
        Me.FdMenu_Verwerk_but = New System.Windows.Forms.Button()
        Me.C1NavBarFlorecom = New C1.Win.C1Command.C1NavBarPanel()
        Me.C1NavPanelFlorecom = New System.Windows.Forms.Panel()
        Me.FCMenu_Nietverwerken_but = New System.Windows.Forms.Button()
        Me.FcMenu_fczoek_chk = New System.Windows.Forms.CheckBox()
        Me.FcMenu_fczoek_txt = New System.Windows.Forms.TextBox()
        Me.FcMenu_fcnummer_txt = New System.Windows.Forms.TextBox()
        Me.FcMenu_fcnummer_lbl = New System.Windows.Forms.Label()
        Me.FcMenu_Verwerk_but = New System.Windows.Forms.Button()
        Me.FcMenu_Archief = New System.Windows.Forms.Button()
        Me.Fc_DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FcMenu_vandaag_but = New System.Windows.Forms.Button()
        Me.FcMenu_nieuw_but = New System.Windows.Forms.Button()
        Me.C1NavBarPanelDatabase = New C1.Win.C1Command.C1NavBarPanel()
        Me.C1NavPanelDatabase1 = New System.Windows.Forms.Panel()
        Me.DBOverzichten_but = New System.Windows.Forms.Button()
        Me.DatabaseMenuCopy_but = New System.Windows.Forms.Button()
        Me.DatabaseMenuHerladen_but = New System.Windows.Forms.Button()
        Me.Database_preselect_cmb = New System.Windows.Forms.ComboBox()
        Me.DatabaseMenuSDFPL_but = New System.Windows.Forms.Button()
        Me.database_lbl = New System.Windows.Forms.Label()
        Me.DatabaseMenuOpslaan = New System.Windows.Forms.Button()
        Me.DatabaseMenuAanpassen = New System.Windows.Forms.Button()
        Me.DatabaseMenuNieuw = New System.Windows.Forms.Button()
        Me.Database_Combo = New System.Windows.Forms.ComboBox()
        Me.C1NavBarPanelInstellingen = New C1.Win.C1Command.C1NavBarPanel()
        Me.C1NavPanelInstel = New System.Windows.Forms.Panel()
        Me.Inst_run_update_but = New System.Windows.Forms.Button()
        Me.Settings_Cancel_But = New System.Windows.Forms.Button()
        Me.Settings_Save_But = New System.Windows.Forms.Button()
        Me.C1NavBarPrijzen = New C1.Win.C1Command.C1NavBarPanel()
        Me.C1NavPanelPrijzen = New System.Windows.Forms.Panel()
        Me.Prijzen_opslaan_but = New System.Windows.Forms.Button()
        Me.prijzen_aanpassen_but = New System.Windows.Forms.Button()
        Me.prijzen_verwijderen_but = New System.Windows.Forms.Button()
        Me.prijzen_nieuw_but = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Timer_Activity = New System.Windows.Forms.Timer(Me.components)
        Me.Tree_MenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TreeMenu_Selectie = New System.Windows.Forms.ToolStripMenuItem()
        Me.TreeMenu_OrderAanpassen = New System.Windows.Forms.ToolStripMenuItem()
        Me.TreeMenu_Karindeling = New System.Windows.Forms.ToolStripMenuItem()
        Me.WpsVersturenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrderKopierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrderResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrderStikkersVerzamelkarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabelberichtStatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrderNaar900VolgendeDagToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OvergooienHieropAanvullenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PakbonSamenvatting = New System.Windows.Forms.ToolStripMenuItem()
        Me.FloridayOrderAanpassenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TreeMenu_SortInvoer = New System.Windows.Forms.ToolStripMenuItem()
        Me.TreeMenu_SortStatus = New System.Windows.Forms.ToolStripMenuItem()
        Me.TreeMenu_SortAlfabet = New System.Windows.Forms.ToolStripMenuItem()
        Me.TreeMenu_SortLoc = New System.Windows.Forms.ToolStripMenuItem()
        Me.TreeMenu_TijdAlles = New System.Windows.Forms.ToolStripMenuItem()
        Me.TreeMenu_Tijd10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TreeMenu_Tijd13 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TreeMenu_StatusAlles = New System.Windows.Forms.ToolStripMenuItem()
        Me.TreeMenu_StatusVerkort = New System.Windows.Forms.ToolStripMenuItem()
        Me.TreeMenu_StatusNieuw = New System.Windows.Forms.ToolStripMenuItem()
        Me.TreeMenu_StatusNenI = New System.Windows.Forms.ToolStripMenuItem()
        Me.TreeMenu_StatusIngepakt = New System.Windows.Forms.ToolStripMenuItem()
        Me.TreeMenu_StatusVracht = New System.Windows.Forms.ToolStripMenuItem()
        Me.TreeMenu_StatusGeannuleerd = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTipKar = New System.Windows.Forms.ToolTip(Me.components)
        Me.Florecom_MenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FC_Toolstrip_Soort = New System.Windows.Forms.ToolStripMenuItem()
        Me.FC_Toolstrip_SoortOpmerking = New System.Windows.Forms.ToolStripMenuItem()
        Me.FC_Toolstrip_Opmerking = New System.Windows.Forms.ToolStripMenuItem()
        Me.FC_Toolstrip_PrijsKoperSet = New System.Windows.Forms.ToolStripMenuItem()
        Me.Order_MenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GP2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GP3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Order_ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CodeInvoerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Order_ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Order_ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Order_ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Order_ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Order_ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.C1PrintDocument1 = New C1.C1Preview.C1PrintDocument()
        Me.TimerBarcodeServer = New System.Windows.Forms.Timer(Me.components)
        Me.TimerFlorecom = New System.Windows.Forms.Timer(Me.components)
        Me.InlogTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.C1SizerMainWindow, System.ComponentModel.ISupportInitialize).BeginInit
        Me.C1SizerMainWindow.SuspendLayout
        CType(Me.C1SizerTree, System.ComponentModel.ISupportInitialize).BeginInit
        Me.C1SizerTree.SuspendLayout
        Me.TreePanel.SuspendLayout
        CType(Me.icon4_pbox, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.icon3_pbox, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.icon2_pbox, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.icon1_pbox, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.C1Tab, System.ComponentModel.ISupportInitialize).BeginInit
        Me.C1Tab.SuspendLayout
        Me.C1TabOrderInvoer.SuspendLayout
        CType(Me.C1SizerOrderTab, System.ComponentModel.ISupportInitialize).BeginInit
        Me.C1SizerOrderTab.SuspendLayout
        CType(Me.Invoer_WpsFilterCombo, System.ComponentModel.ISupportInitialize).BeginInit
        Me.TabOrdersPanelTop.SuspendLayout
        Me.Order_OpmTab.SuspendLayout
        Me.opmerking.SuspendLayout
        Me.orderinfo.SuspendLayout
        Me.pakboninfo.SuspendLayout
        Me.koper1.SuspendLayout
        Me.koper2.SuspendLayout
        Me.koper3.SuspendLayout
        Me.koper4.SuspendLayout
        Me.koper5.SuspendLayout
        Me.koper6.SuspendLayout
        Me.koper7.SuspendLayout
        Me.koper8.SuspendLayout
        Me.kopertoevoegen.SuspendLayout
        Me.Order_Opm_addcontactpannel.SuspendLayout
        CType(Me.Order_invoer_FlexGrid, System.ComponentModel.ISupportInitialize).BeginInit
        Me.C1TabKarindeling.SuspendLayout
        CType(Me.C1SizerKarIndeling, System.ComponentModel.ISupportInitialize).BeginInit
        Me.C1SizerKarIndeling.SuspendLayout
        Me.PanelKarindelingOnder.SuspendLayout
        Me.PanelKarindelingMidden.SuspendLayout
        CType(Me.Kar_flexgrid4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Kar_flexgrid3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Kar_flexgrid2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Kar_flexgrid1, System.ComponentModel.ISupportInitialize).BeginInit
        Me.PanelKarIndelingBoven.SuspendLayout
        Me.C1TabFloriday.SuspendLayout
        CType(Me.C1SizerFloriday, System.ComponentModel.ISupportInitialize).BeginInit
        Me.C1SizerFloriday.SuspendLayout
        Me.PanelFloridayorders.SuspendLayout
        CType(Me.FDLineCombo, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.FloridayOrderInfo_flx, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.FloridayOrderLines_flx, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.FloridayOrders_flx, System.ComponentModel.ISupportInitialize).BeginInit
        Me.C1TabFlorecom.SuspendLayout
        CType(Me.C1SizerFlorecom, System.ComponentModel.ISupportInitialize).BeginInit
        Me.C1SizerFlorecom.SuspendLayout
        CType(Me.Fc_ContactCombo, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Fc_LineCombo, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Fc_Flexgrid_LineData, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.FC_Flexgrid_contactdata, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.FC_Flexgrid_orderlines, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.FC_Flexgrid_orderlijst, System.ComponentModel.ISupportInitialize).BeginInit
        Me.FlorecomDel_menuStrip.SuspendLayout
        Me.C1TabVervoer.SuspendLayout
        CType(Me.SizerVervoer, System.ComponentModel.ISupportInitialize).BeginInit
        Me.SizerVervoer.SuspendLayout
        Me.Vervoer_PanelRechts.SuspendLayout
        Me.Vervoer_PanelLinks.SuspendLayout
        Me.C1TabOverzichten.SuspendLayout
        CType(Me.OverzichtSizer1, System.ComponentModel.ISupportInitialize).BeginInit
        Me.OverzichtSizer1.SuspendLayout
        CType(Me.OverzichtSizer2, System.ComponentModel.ISupportInitialize).BeginInit
        Me.OverzichtSizer2.SuspendLayout
        CType(Me.Overzicht_FlexGrid, System.ComponentModel.ISupportInitialize).BeginInit
        Me.Overzicht_Panel.SuspendLayout
        CType(Me.Overzicht_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit
        Me.C1TabDatabase.SuspendLayout
        CType(Me.C1Sizer1, System.ComponentModel.ISupportInitialize).BeginInit
        Me.C1Sizer1.SuspendLayout
        CType(Me.DatabaseComboWpsFilter, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DatabaseFlexGridEdit, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DatabaseFlexGridShow, System.ComponentModel.ISupportInitialize).BeginInit
        Me.C1TabInstellingen.SuspendLayout
        Me.Inst_Overig_GB.SuspendLayout
        CType(Me.Inst_odag7_ud, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Inst_odag6_ud, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Inst_odag5_ud, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Inst_odag4_ud, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Inst_odag3_ud, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Inst_odag2_ud, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Inst_odag1_ud, System.ComponentModel.ISupportInitialize).BeginInit
        Me.Inst_Westland_GB.SuspendLayout
        CType(Me.Inst_wdag7_ud, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Inst_wdag6_ud, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Inst_wdag5_ud, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Inst_wdag4_ud, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Inst_wdag3_ud, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Inst_wdag2_ud, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Inst_wdag1_ud, System.ComponentModel.ISupportInitialize).BeginInit
        Me.C1TabPrijzen.SuspendLayout
        CType(Me.Prijzen_sizer, System.ComponentModel.ISupportInitialize).BeginInit
        Me.Prijzen_sizer.SuspendLayout
        CType(Me.C1prijzensizer3, System.ComponentModel.ISupportInitialize).BeginInit
        Me.C1prijzensizer3.SuspendLayout
        Me.prijzenpanelmidleft.SuspendLayout
        CType(Me.prijzen_jaar_updown, System.ComponentModel.ISupportInitialize).BeginInit
        Me.prijzenpanelmidright.SuspendLayout
        CType(Me.Prijzen_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Prijzen_Sizer2, System.ComponentModel.ISupportInitialize).BeginInit
        Me.Prijzen_Sizer2.SuspendLayout
        CType(Me.Prijzen_flexgrid_soorten, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.prijzen_flexgrid_datums, System.ComponentModel.ISupportInitialize).BeginInit
        Me.C1TabVoorraad.SuspendLayout
        CType(Me.C1SizerVoorraad, System.ComponentModel.ISupportInitialize).BeginInit
        Me.C1SizerVoorraad.SuspendLayout
        CType(Me.Voorraad_Flexgrid, System.ComponentModel.ISupportInitialize).BeginInit
        Me.PanelVoorraad.SuspendLayout
        Me.GroupBoxVoorraad.SuspendLayout
        Me.C1TabWPS.SuspendLayout
        CType(Me.C1SizerWpsFilters, System.ComponentModel.ISupportInitialize).BeginInit
        Me.C1SizerWpsFilters.SuspendLayout
        CType(Me.WpsFilter_flexcombo, System.ComponentModel.ISupportInitialize).BeginInit
        Me.PanelWpsFilterMidBar.SuspendLayout
        Me.PanelWpsFilterTopBar.SuspendLayout
        Me.PanelWpsFilter.SuspendLayout
        CType(Me.WpsFilter_FilterFlex, System.ComponentModel.ISupportInitialize).BeginInit
        Me.C1TabInloggen.SuspendLayout
        CType(Me.C1SizerInloggen, System.ComponentModel.ISupportInitialize).BeginInit
        Me.C1SizerInloggen.SuspendLayout
        Me.LoginPanelDown.SuspendLayout
        CType(Me.AgendaFlexGrid, System.ComponentModel.ISupportInitialize).BeginInit
        Me.LoginPanelup.SuspendLayout
        CType(Me.C1NavBar1, System.ComponentModel.ISupportInitialize).BeginInit
        Me.C1NavBar1.SuspendLayout
        Me.C1NavBarPanelOrders.SuspendLayout
        Me.C1NavPanelOrders2.SuspendLayout
        Me.C1NavPanelOrders1.SuspendLayout
        Me.C1NavBarFloriday.SuspendLayout
        Me.C1NavBarFlorecom.SuspendLayout
        Me.C1NavPanelFlorecom.SuspendLayout
        Me.C1NavBarPanelDatabase.SuspendLayout
        Me.C1NavPanelDatabase1.SuspendLayout
        Me.C1NavBarPanelInstellingen.SuspendLayout
        Me.C1NavPanelInstel.SuspendLayout
        Me.C1NavBarPrijzen.SuspendLayout
        Me.C1NavPanelPrijzen.SuspendLayout
        Me.Tree_MenuStrip.SuspendLayout
        Me.Florecom_MenuStrip.SuspendLayout
        Me.Order_MenuStrip.SuspendLayout
        CType(Me.C1PrintDocument1, System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'C1SizerMainWindow
        '
        Me.C1SizerMainWindow.Controls.Add(Me.C1SizerTree)
        Me.C1SizerMainWindow.Controls.Add(Me.C1Tab)
        Me.C1SizerMainWindow.Controls.Add(Me.C1NavBar1)
        Me.C1SizerMainWindow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1SizerMainWindow.GridDefinition = "99.1778006166495:False:False;" & Global.Microsoft.VisualBasic.ChrW(9) & "24.9322493224932:True:False;14.0243902439024:True:T" &
    "rue;59.9593495934959:True:False;"
        Me.C1SizerMainWindow.Location = New System.Drawing.Point(0, 0)
        Me.C1SizerMainWindow.Name = "C1SizerMainWindow"
        Me.C1SizerMainWindow.Size = New System.Drawing.Size(1476, 973)
        Me.C1SizerMainWindow.TabIndex = 0
        Me.C1SizerMainWindow.Text = "C1Sizer1MainWindow"
        '
        'C1SizerTree
        '
        Me.C1SizerTree.Controls.Add(Me.TreePanel)
        Me.C1SizerTree.Controls.Add(Me.TreeView1)
        Me.C1SizerTree.GridDefinition = "10.7772020725389:False:True;87.979274611399:False:False;" & Global.Microsoft.VisualBasic.ChrW(9) & "97.8260869565217:False:F" &
    "alse;"
        Me.C1SizerTree.Location = New System.Drawing.Point(4, 4)
        Me.C1SizerTree.Name = "C1SizerTree"
        Me.C1SizerTree.Size = New System.Drawing.Size(368, 965)
        Me.C1SizerTree.TabIndex = 3
        Me.C1SizerTree.Text = "C1Sizer2"
        '
        'TreePanel
        '
        Me.TreePanel.Controls.Add(Me.Tree_BBKlok_cmb)
        Me.TreePanel.Controls.Add(Me.icon4_pbox)
        Me.TreePanel.Controls.Add(Me.icon4_chk)
        Me.TreePanel.Controls.Add(Me.icon3_pbox)
        Me.TreePanel.Controls.Add(Me.icon3_chk)
        Me.TreePanel.Controls.Add(Me.icon2_pbox)
        Me.TreePanel.Controls.Add(Me.icon2_chk)
        Me.TreePanel.Controls.Add(Me.icon1_pbox)
        Me.TreePanel.Controls.Add(Me.icon1_chk)
        Me.TreePanel.Controls.Add(Me.TreeVest2_but)
        Me.TreePanel.Controls.Add(Me.TreeVest1_but)
        Me.TreePanel.Controls.Add(Me.TreeVestTotaal_but)
        Me.TreePanel.Controls.Add(Me.Tree_Update_but)
        Me.TreePanel.Controls.Add(Me.Tree_Status_lbl)
        Me.TreePanel.Controls.Add(Me.Tree_Tijd_lbl)
        Me.TreePanel.Controls.Add(Me.Tree_Datum_lbl)
        Me.TreePanel.Location = New System.Drawing.Point(4, 4)
        Me.TreePanel.Name = "TreePanel"
        Me.TreePanel.Size = New System.Drawing.Size(360, 104)
        Me.TreePanel.TabIndex = 1
        '
        'Tree_BBKlok_cmb
        '
        Me.Tree_BBKlok_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Tree_BBKlok_cmb.FormattingEnabled = True
        Me.Tree_BBKlok_cmb.Items.AddRange(New Object() {"Totaal", "BB", "Klok"})
        Me.Tree_BBKlok_cmb.Location = New System.Drawing.Point(243, 80)
        Me.Tree_BBKlok_cmb.Name = "Tree_BBKlok_cmb"
        Me.Tree_BBKlok_cmb.Size = New System.Drawing.Size(72, 21)
        Me.Tree_BBKlok_cmb.TabIndex = 16
        '
        'icon4_pbox
        '
        Me.icon4_pbox.Location = New System.Drawing.Point(185, 81)
        Me.icon4_pbox.Name = "icon4_pbox"
        Me.icon4_pbox.Size = New System.Drawing.Size(16, 16)
        Me.icon4_pbox.TabIndex = 15
        Me.icon4_pbox.TabStop = False
        '
        'icon4_chk
        '
        Me.icon4_chk.AutoSize = True
        Me.icon4_chk.Location = New System.Drawing.Point(207, 83)
        Me.icon4_chk.Name = "icon4_chk"
        Me.icon4_chk.Size = New System.Drawing.Size(15, 14)
        Me.icon4_chk.TabIndex = 14
        Me.icon4_chk.UseVisualStyleBackColor = True
        '
        'icon3_pbox
        '
        Me.icon3_pbox.Location = New System.Drawing.Point(130, 81)
        Me.icon3_pbox.Name = "icon3_pbox"
        Me.icon3_pbox.Size = New System.Drawing.Size(16, 16)
        Me.icon3_pbox.TabIndex = 13
        Me.icon3_pbox.TabStop = False
        '
        'icon3_chk
        '
        Me.icon3_chk.AutoSize = True
        Me.icon3_chk.Location = New System.Drawing.Point(152, 83)
        Me.icon3_chk.Name = "icon3_chk"
        Me.icon3_chk.Size = New System.Drawing.Size(15, 14)
        Me.icon3_chk.TabIndex = 12
        Me.icon3_chk.UseVisualStyleBackColor = True
        '
        'icon2_pbox
        '
        Me.icon2_pbox.Location = New System.Drawing.Point(70, 81)
        Me.icon2_pbox.Name = "icon2_pbox"
        Me.icon2_pbox.Size = New System.Drawing.Size(16, 16)
        Me.icon2_pbox.TabIndex = 11
        Me.icon2_pbox.TabStop = False
        '
        'icon2_chk
        '
        Me.icon2_chk.AutoSize = True
        Me.icon2_chk.Location = New System.Drawing.Point(92, 83)
        Me.icon2_chk.Name = "icon2_chk"
        Me.icon2_chk.Size = New System.Drawing.Size(15, 14)
        Me.icon2_chk.TabIndex = 10
        Me.icon2_chk.UseVisualStyleBackColor = True
        '
        'icon1_pbox
        '
        Me.icon1_pbox.Location = New System.Drawing.Point(17, 81)
        Me.icon1_pbox.Name = "icon1_pbox"
        Me.icon1_pbox.Size = New System.Drawing.Size(16, 16)
        Me.icon1_pbox.TabIndex = 9
        Me.icon1_pbox.TabStop = False
        '
        'icon1_chk
        '
        Me.icon1_chk.AutoSize = True
        Me.icon1_chk.Location = New System.Drawing.Point(39, 83)
        Me.icon1_chk.Name = "icon1_chk"
        Me.icon1_chk.Size = New System.Drawing.Size(15, 14)
        Me.icon1_chk.TabIndex = 8
        Me.icon1_chk.UseVisualStyleBackColor = True
        '
        'TreeVest2_but
        '
        Me.TreeVest2_but.Enabled = False
        Me.TreeVest2_but.Location = New System.Drawing.Point(217, 50)
        Me.TreeVest2_but.Name = "TreeVest2_but"
        Me.TreeVest2_but.Size = New System.Drawing.Size(98, 27)
        Me.TreeVest2_but.TabIndex = 7
        Me.TreeVest2_but.Text = "Vestiging 2"
        Me.TreeVest2_but.UseVisualStyleBackColor = True
        Me.TreeVest2_but.Visible = False
        '
        'TreeVest1_but
        '
        Me.TreeVest1_but.Enabled = False
        Me.TreeVest1_but.Location = New System.Drawing.Point(113, 50)
        Me.TreeVest1_but.Name = "TreeVest1_but"
        Me.TreeVest1_but.Size = New System.Drawing.Size(98, 27)
        Me.TreeVest1_but.TabIndex = 6
        Me.TreeVest1_but.Text = "Vestiging 1"
        Me.TreeVest1_but.UseVisualStyleBackColor = True
        Me.TreeVest1_but.Visible = False
        '
        'TreeVestTotaal_but
        '
        Me.TreeVestTotaal_but.Enabled = False
        Me.TreeVestTotaal_but.Location = New System.Drawing.Point(9, 50)
        Me.TreeVestTotaal_but.Name = "TreeVestTotaal_but"
        Me.TreeVestTotaal_but.Size = New System.Drawing.Size(98, 27)
        Me.TreeVestTotaal_but.TabIndex = 5
        Me.TreeVestTotaal_but.Text = "Totaal"
        Me.TreeVestTotaal_but.UseVisualStyleBackColor = True
        Me.TreeVestTotaal_but.Visible = False
        '
        'Tree_Update_but
        '
        Me.Tree_Update_but.Location = New System.Drawing.Point(258, 24)
        Me.Tree_Update_but.Name = "Tree_Update_but"
        Me.Tree_Update_but.Size = New System.Drawing.Size(57, 23)
        Me.Tree_Update_but.TabIndex = 4
        Me.Tree_Update_but.Text = "Update"
        Me.Tree_Update_but.UseVisualStyleBackColor = True
        '
        'Tree_Status_lbl
        '
        Me.Tree_Status_lbl.AutoSize = True
        Me.Tree_Status_lbl.Location = New System.Drawing.Point(140, 34)
        Me.Tree_Status_lbl.Name = "Tree_Status_lbl"
        Me.Tree_Status_lbl.Size = New System.Drawing.Size(99, 13)
        Me.Tree_Status_lbl.TabIndex = 3
        Me.Tree_Status_lbl.Text = "Status: Alles Tonen"
        '
        'Tree_Tijd_lbl
        '
        Me.Tree_Tijd_lbl.AutoSize = True
        Me.Tree_Tijd_lbl.Location = New System.Drawing.Point(25, 34)
        Me.Tree_Tijd_lbl.Name = "Tree_Tijd_lbl"
        Me.Tree_Tijd_lbl.Size = New System.Drawing.Size(82, 13)
        Me.Tree_Tijd_lbl.TabIndex = 2
        Me.Tree_Tijd_lbl.Text = "Tijd: Alles tonen"
        '
        'Tree_Datum_lbl
        '
        Me.Tree_Datum_lbl.AutoSize = True
        Me.Tree_Datum_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tree_Datum_lbl.Location = New System.Drawing.Point(4, 1)
        Me.Tree_Datum_lbl.Name = "Tree_Datum_lbl"
        Me.Tree_Datum_lbl.Size = New System.Drawing.Size(264, 25)
        Me.Tree_Datum_lbl.TabIndex = 0
        Me.Tree_Datum_lbl.Text = "Donderdag 31 Jan 2011"
        '
        'TreeView1
        '
        Me.TreeView1.ImageIndex = 0
        Me.TreeView1.ImageList = Me.IconList
        Me.TreeView1.Location = New System.Drawing.Point(4, 112)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.SelectedImageIndex = 0
        Me.TreeView1.Size = New System.Drawing.Size(360, 849)
        Me.TreeView1.TabIndex = 0
        '
        'IconList
        '
        Me.IconList.ImageStream = CType(resources.GetObject("IconList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IconList.TransparentColor = System.Drawing.Color.Transparent
        Me.IconList.Images.SetKeyName(0, "stippel.jpg")
        Me.IconList.Images.SetKeyName(1, "plussimple.bmp")
        Me.IconList.Images.SetKeyName(2, "letter d.ico")
        Me.IconList.Images.SetKeyName(3, "blank.ico")
        Me.IconList.Images.SetKeyName(4, "dots.ico")
        Me.IconList.Images.SetKeyName(5, "globe.ico")
        Me.IconList.Images.SetKeyName(6, "clock.ico")
        Me.IconList.Images.SetKeyName(7, "file.ico")
        Me.IconList.Images.SetKeyName(8, "person2.ico")
        Me.IconList.Images.SetKeyName(9, "cross.ico")
        Me.IconList.Images.SetKeyName(10, "Select.ico")
        Me.IconList.Images.SetKeyName(11, "tick.ico")
        Me.IconList.Images.SetKeyName(12, "ok.ico")
        Me.IconList.Images.SetKeyName(13, "data file.ico")
        Me.IconList.Images.SetKeyName(14, "data sdfpart.ico")
        Me.IconList.Images.SetKeyName(15, "data sdfwps.ico")
        Me.IconList.Images.SetKeyName(16, "pin.ico")
        Me.IconList.Images.SetKeyName(17, "transfer.ico")
        Me.IconList.Images.SetKeyName(18, "transfer.ico")
        Me.IconList.Images.SetKeyName(19, "transfer.ico")
        Me.IconList.Images.SetKeyName(20, "wpsyellow.ico")
        Me.IconList.Images.SetKeyName(21, "wpsblue.ico")
        Me.IconList.Images.SetKeyName(22, "wpsgreen.ico")
        Me.IconList.Images.SetKeyName(23, "wpspurple.ico")
        Me.IconList.Images.SetKeyName(24, "wpsred.ico")
        Me.IconList.Images.SetKeyName(25, "invoeren.ico")
        Me.IconList.Images.SetKeyName(26, "box_blobgreen1.ico")
        Me.IconList.Images.SetKeyName(27, "wpsbluegreen.ico")
        Me.IconList.Images.SetKeyName(28, "wpspurplegreen.ico")
        Me.IconList.Images.SetKeyName(29, "flash.ico")
        Me.IconList.Images.SetKeyName(30, "blank.ico")
        Me.IconList.Images.SetKeyName(31, "label.ico")
        Me.IconList.Images.SetKeyName(32, "labelhelp.ico")
        Me.IconList.Images.SetKeyName(33, "labelhelpdone.ico")
        Me.IconList.Images.SetKeyName(34, "labelbericht.ico")
        Me.IconList.Images.SetKeyName(35, "sdfattach.ico")
        Me.IconList.Images.SetKeyName(36, "floriday_yellow.ico")
        Me.IconList.Images.SetKeyName(37, "floriday_blue.ico")
        Me.IconList.Images.SetKeyName(38, "docs.ico")
        Me.IconList.Images.SetKeyName(39, "label2.ico")
        Me.IconList.Images.SetKeyName(40, "labelhelp2.ico")
        Me.IconList.Images.SetKeyName(41, "labelhelpdone2.ico")
        Me.IconList.Images.SetKeyName(42, "box_blobblue1.ico")
        Me.IconList.Images.SetKeyName(43, "tickblue.ico")
        Me.IconList.Images.SetKeyName(44, "blank.ico")
        Me.IconList.Images.SetKeyName(45, "overgooiernieuw.ico")
        Me.IconList.Images.SetKeyName(46, "overgooierblue.ico")
        Me.IconList.Images.SetKeyName(47, "overgooiergreen.ico")
        Me.IconList.Images.SetKeyName(48, "cross_blue.ico")
        Me.IconList.Images.SetKeyName(49, "cross_green.ico")
        Me.IconList.Images.SetKeyName(50, "nieuwsdfdone1.ico")
        Me.IconList.Images.SetKeyName(51, "nieuwsdfdone2.ico")
        Me.IconList.Images.SetKeyName(52, "reload.ico")
        Me.IconList.Images.SetKeyName(53, "labelophoes1.ico")
        Me.IconList.Images.SetKeyName(54, "labelophoes2.ico")
        Me.IconList.Images.SetKeyName(55, "floriday_red.ico")
        Me.IconList.Images.SetKeyName(56, "ticksdfgreen.ico")
        Me.IconList.Images.SetKeyName(57, "tickbluesdf.ico")
        '
        'C1Tab
        '
        Me.C1Tab.Controls.Add(Me.C1TabOrderInvoer)
        Me.C1Tab.Controls.Add(Me.C1TabKarindeling)
        Me.C1Tab.Controls.Add(Me.C1TabFloriday)
        Me.C1Tab.Controls.Add(Me.C1TabFlorecom)
        Me.C1Tab.Controls.Add(Me.C1TabVervoer)
        Me.C1Tab.Controls.Add(Me.C1TabOverzichten)
        Me.C1Tab.Controls.Add(Me.C1TabDatabase)
        Me.C1Tab.Controls.Add(Me.C1TabInstellingen)
        Me.C1Tab.Controls.Add(Me.C1TabPrijzen)
        Me.C1Tab.Controls.Add(Me.C1TabVoorraad)
        Me.C1Tab.Controls.Add(Me.C1TabWPS)
        Me.C1Tab.Controls.Add(Me.C1TabInloggen)
        Me.C1Tab.Location = New System.Drawing.Point(587, 4)
        Me.C1Tab.Name = "C1Tab"
        Me.C1Tab.SelectedIndex = 11
        Me.C1Tab.Size = New System.Drawing.Size(885, 965)
        Me.C1Tab.TabIndex = 1
        Me.C1Tab.TabsSpacing = 0
        '
        'C1TabOrderInvoer
        '
        Me.C1TabOrderInvoer.Controls.Add(Me.C1SizerOrderTab)
        Me.C1TabOrderInvoer.Location = New System.Drawing.Point(1, 24)
        Me.C1TabOrderInvoer.Name = "C1TabOrderInvoer"
        Me.C1TabOrderInvoer.Size = New System.Drawing.Size(883, 940)
        Me.C1TabOrderInvoer.TabIndex = 0
        Me.C1TabOrderInvoer.Text = "Order invoer"
        '
        'C1SizerOrderTab
        '
        Me.C1SizerOrderTab.Controls.Add(Me.Invoer_WpsFilterCombo)
        Me.C1SizerOrderTab.Controls.Add(Me.TabOrdersPanelTop)
        Me.C1SizerOrderTab.Controls.Add(Me.Order_invoer_FlexGrid)
        Me.C1SizerOrderTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1SizerOrderTab.GridDefinition = "37.7659574468085:False:True;60.9574468085106:False:False;" & Global.Microsoft.VisualBasic.ChrW(9) & "99.0939977349943:False:" &
    "False;"
        Me.C1SizerOrderTab.Location = New System.Drawing.Point(0, 0)
        Me.C1SizerOrderTab.Name = "C1SizerOrderTab"
        Me.C1SizerOrderTab.Size = New System.Drawing.Size(883, 940)
        Me.C1SizerOrderTab.TabIndex = 0
        Me.C1SizerOrderTab.Text = "C1Sizer1"
        '
        'Invoer_WpsFilterCombo
        '
        Me.Invoer_WpsFilterCombo.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.Invoer_WpsFilterCombo.Caption = ""
        Me.Invoer_WpsFilterCombo.CaptionHeight = 17
        Me.Invoer_WpsFilterCombo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Invoer_WpsFilterCombo.ColumnCaptionHeight = 17
        Me.Invoer_WpsFilterCombo.ColumnFooterHeight = 17
        Me.Invoer_WpsFilterCombo.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.Invoer_WpsFilterCombo.EditorBackColor = System.Drawing.SystemColors.Window
        Me.Invoer_WpsFilterCombo.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.Invoer_WpsFilterCombo.Images.Add(CType(resources.GetObject("Invoer_WpsFilterCombo.Images"), System.Drawing.Image))
        Me.Invoer_WpsFilterCombo.ItemHeight = 15
        Me.Invoer_WpsFilterCombo.Location = New System.Drawing.Point(4, 363)
        Me.Invoer_WpsFilterCombo.MatchEntryTimeout = CType(2000, Long)
        Me.Invoer_WpsFilterCombo.MaxDropDownItems = CType(5, Short)
        Me.Invoer_WpsFilterCombo.MaxLength = 32767
        Me.Invoer_WpsFilterCombo.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.Invoer_WpsFilterCombo.Name = "Invoer_WpsFilterCombo"
        Me.Invoer_WpsFilterCombo.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.Invoer_WpsFilterCombo.Size = New System.Drawing.Size(875, 21)
        Me.Invoer_WpsFilterCombo.TabIndex = 35
        Me.Invoer_WpsFilterCombo.Visible = False
        Me.Invoer_WpsFilterCombo.PropBag = resources.GetString("Invoer_WpsFilterCombo.PropBag")
        '
        'TabOrdersPanelTop
        '
        Me.TabOrdersPanelTop.Controls.Add(Me.Orders_PlusAccessoires_but)
        Me.TabOrdersPanelTop.Controls.Add(Me.TestBuild_but)
        Me.TabOrdersPanelTop.Controls.Add(Me.Order_bakstikkers_chk)
        Me.TabOrdersPanelTop.Controls.Add(Me.Order_plantenpaspoort_chk)
        Me.TabOrdersPanelTop.Controls.Add(Me.Order_Prijscor_plusS_but)
        Me.TabOrdersPanelTop.Controls.Add(Me.Order_Prijscor_minS_but)
        Me.TabOrdersPanelTop.Controls.Add(Me.Label49)
        Me.TabOrdersPanelTop.Controls.Add(Me.Order_hoescat_cmb)
        Me.TabOrdersPanelTop.Controls.Add(Me.Label48)
        Me.TabOrdersPanelTop.Controls.Add(Me.Order_fustcat_cmb)
        Me.TabOrdersPanelTop.Controls.Add(Me.Stikker_lbl)
        Me.TabOrdersPanelTop.Controls.Add(Me.StickerType_cmb)
        Me.TabOrdersPanelTop.Controls.Add(Me.Order_aanvulling_chk)
        Me.TabOrdersPanelTop.Controls.Add(Me.orders_opmerking_opslaan)
        Me.TabOrdersPanelTop.Controls.Add(Me.Order_OpmTab)
        Me.TabOrdersPanelTop.Controls.Add(Me.Order_Prijscor_min_but)
        Me.TabOrdersPanelTop.Controls.Add(Me.Order_Prijs_correctie_lbl)
        Me.TabOrdersPanelTop.Controls.Add(Me.Order_Prijscor_plus_but)
        Me.TabOrdersPanelTop.Controls.Add(Me.Order_Prijscor_prijs_txt)
        Me.TabOrdersPanelTop.Controls.Add(Me.Order_herbereken_prijzen)
        Me.TabOrdersPanelTop.Controls.Add(Me.Order_reservering_chk)
        Me.TabOrdersPanelTop.Controls.Add(Me.Order_versie_lbl)
        Me.TabOrdersPanelTop.Controls.Add(Me.Order_versietxt_lbl)
        Me.TabOrdersPanelTop.Controls.Add(Me.Order_Slot_Chk)
        Me.TabOrdersPanelTop.Controls.Add(Me.Order_OverMorgen_but)
        Me.TabOrdersPanelTop.Controls.Add(Me.Order_idtxt_lbl)
        Me.TabOrdersPanelTop.Controls.Add(Me.Order_id_lbl)
        Me.TabOrdersPanelTop.Controls.Add(Me.Order_admnr_txt)
        Me.TabOrdersPanelTop.Controls.Add(Me.Label16)
        Me.TabOrdersPanelTop.Controls.Add(Me.order_contacts_combo)
        Me.TabOrdersPanelTop.Controls.Add(Me.Label15)
        Me.TabOrdersPanelTop.Controls.Add(Me.Order_Decorum_chk)
        Me.TabOrdersPanelTop.Controls.Add(Me.Order_koper_combo)
        Me.TabOrdersPanelTop.Controls.Add(Me.Order_groep5_but)
        Me.TabOrdersPanelTop.Controls.Add(Me.Order_groep4_but)
        Me.TabOrdersPanelTop.Controls.Add(Me.Order_groep3_but)
        Me.TabOrdersPanelTop.Controls.Add(Me.Order_groep2_but)
        Me.TabOrdersPanelTop.Controls.Add(Me.Order_AflevertijdZA_but)
        Me.TabOrdersPanelTop.Controls.Add(Me.Order_Vandaag_but)
        Me.TabOrdersPanelTop.Controls.Add(Me.Order_groep1_but)
        Me.TabOrdersPanelTop.Controls.Add(Me.Order_InstelOpslaan_but)
        Me.TabOrdersPanelTop.Controls.Add(Me.Order_Opslaan_but)
        Me.TabOrdersPanelTop.Controls.Add(Me.Order_prijsopslag_txt)
        Me.TabOrdersPanelTop.Controls.Add(Me.Order_vervoerder_combo)
        Me.TabOrdersPanelTop.Controls.Add(Me.Label19)
        Me.TabOrdersPanelTop.Controls.Add(Me.Label18)
        Me.TabOrdersPanelTop.Controls.Add(Me.Order_veilingbrief_combo)
        Me.TabOrdersPanelTop.Controls.Add(Me.Label17)
        Me.TabOrdersPanelTop.Controls.Add(Me.Order_kar_combo)
        Me.TabOrdersPanelTop.Controls.Add(Me.Order_afleverloc_combo)
        Me.TabOrdersPanelTop.Controls.Add(Me.Order_admnr_lbl)
        Me.TabOrdersPanelTop.Controls.Add(Me.Order_ean_lbl)
        Me.TabOrdersPanelTop.Controls.Add(Me.Order_Aflevertijd17_but)
        Me.TabOrdersPanelTop.Controls.Add(Me.Order_Aflevertijd12_but)
        Me.TabOrdersPanelTop.Controls.Add(Me.Order_Aflevertijd9_but)
        Me.TabOrdersPanelTop.Controls.Add(Me.Order_Aflevertijd_combo)
        Me.TabOrdersPanelTop.Controls.Add(Me.Order_Morgen_but)
        Me.TabOrdersPanelTop.Controls.Add(Me.Button1)
        Me.TabOrdersPanelTop.Controls.Add(Me.OrderDateTimePicker)
        Me.TabOrdersPanelTop.Controls.Add(Me.Label12)
        Me.TabOrdersPanelTop.Controls.Add(Me.Label11)
        Me.TabOrdersPanelTop.Controls.Add(Me.Label10)
        Me.TabOrdersPanelTop.Controls.Add(Me.Label9)
        Me.TabOrdersPanelTop.Controls.Add(Me.Label8)
        Me.TabOrdersPanelTop.Location = New System.Drawing.Point(4, 4)
        Me.TabOrdersPanelTop.Name = "TabOrdersPanelTop"
        Me.TabOrdersPanelTop.Size = New System.Drawing.Size(875, 355)
        Me.TabOrdersPanelTop.TabIndex = 3
        '
        'Orders_PlusAccessoires_but
        '
        Me.Orders_PlusAccessoires_but.Location = New System.Drawing.Point(798, 301)
        Me.Orders_PlusAccessoires_but.Name = "Orders_PlusAccessoires_but"
        Me.Orders_PlusAccessoires_but.Size = New System.Drawing.Size(74, 49)
        Me.Orders_PlusAccessoires_but.TabIndex = 71
        Me.Orders_PlusAccessoires_but.Text = "+ Accessoires"
        Me.Orders_PlusAccessoires_but.UseVisualStyleBackColor = True
        '
        'TestBuild_but
        '
        Me.TestBuild_but.Location = New System.Drawing.Point(656, 187)
        Me.TestBuild_but.Name = "TestBuild_but"
        Me.TestBuild_but.Size = New System.Drawing.Size(81, 38)
        Me.TestBuild_but.TabIndex = 70
        Me.TestBuild_but.Text = "Build"
        Me.TestBuild_but.UseVisualStyleBackColor = True
        '
        'Order_bakstikkers_chk
        '
        Me.Order_bakstikkers_chk.AutoSize = True
        Me.Order_bakstikkers_chk.Location = New System.Drawing.Point(654, 128)
        Me.Order_bakstikkers_chk.Name = "Order_bakstikkers_chk"
        Me.Order_bakstikkers_chk.Size = New System.Drawing.Size(81, 17)
        Me.Order_bakstikkers_chk.TabIndex = 69
        Me.Order_bakstikkers_chk.Text = "Bakstikkers"
        Me.Order_bakstikkers_chk.UseVisualStyleBackColor = True
        Me.Order_bakstikkers_chk.Visible = False
        '
        'Order_plantenpaspoort_chk
        '
        Me.Order_plantenpaspoort_chk.AutoSize = True
        Me.Order_plantenpaspoort_chk.Location = New System.Drawing.Point(654, 148)
        Me.Order_plantenpaspoort_chk.Name = "Order_plantenpaspoort_chk"
        Me.Order_plantenpaspoort_chk.Size = New System.Drawing.Size(80, 17)
        Me.Order_plantenpaspoort_chk.TabIndex = 68
        Me.Order_plantenpaspoort_chk.Text = "Pl.Paspoort"
        Me.Order_plantenpaspoort_chk.UseVisualStyleBackColor = True
        Me.Order_plantenpaspoort_chk.Visible = False
        '
        'Order_Prijscor_plusS_but
        '
        Me.Order_Prijscor_plusS_but.Location = New System.Drawing.Point(734, 328)
        Me.Order_Prijscor_plusS_but.Name = "Order_Prijscor_plusS_but"
        Me.Order_Prijscor_plusS_but.Size = New System.Drawing.Size(27, 21)
        Me.Order_Prijscor_plusS_but.TabIndex = 67
        Me.Order_Prijscor_plusS_but.Text = "s+"
        Me.Order_Prijscor_plusS_but.UseVisualStyleBackColor = True
        '
        'Order_Prijscor_minS_but
        '
        Me.Order_Prijscor_minS_but.Location = New System.Drawing.Point(664, 328)
        Me.Order_Prijscor_minS_but.Name = "Order_Prijscor_minS_but"
        Me.Order_Prijscor_minS_but.Size = New System.Drawing.Size(25, 21)
        Me.Order_Prijscor_minS_but.TabIndex = 66
        Me.Order_Prijscor_minS_but.Text = "s-"
        Me.Order_Prijscor_minS_but.UseVisualStyleBackColor = True
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(314, 185)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(32, 13)
        Me.Label49.TabIndex = 65
        Me.Label49.Text = "Hoes"
        '
        'Order_hoescat_cmb
        '
        Me.Order_hoescat_cmb.FormattingEnabled = True
        Me.Order_hoescat_cmb.Location = New System.Drawing.Point(377, 182)
        Me.Order_hoescat_cmb.Name = "Order_hoescat_cmb"
        Me.Order_hoescat_cmb.Size = New System.Drawing.Size(165, 21)
        Me.Order_hoescat_cmb.TabIndex = 64
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(12, 161)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(54, 13)
        Me.Label48.TabIndex = 63
        Me.Label48.Text = "Fustgroep"
        '
        'Order_fustcat_cmb
        '
        Me.Order_fustcat_cmb.FormattingEnabled = True
        Me.Order_fustcat_cmb.Location = New System.Drawing.Point(72, 157)
        Me.Order_fustcat_cmb.Name = "Order_fustcat_cmb"
        Me.Order_fustcat_cmb.Size = New System.Drawing.Size(230, 21)
        Me.Order_fustcat_cmb.TabIndex = 62
        '
        'Stikker_lbl
        '
        Me.Stikker_lbl.AutoSize = True
        Me.Stikker_lbl.Location = New System.Drawing.Point(556, 104)
        Me.Stikker_lbl.Name = "Stikker_lbl"
        Me.Stikker_lbl.Size = New System.Drawing.Size(43, 13)
        Me.Stikker_lbl.TabIndex = 61
        Me.Stikker_lbl.Text = "Stikker:"
        '
        'StickerType_cmb
        '
        Me.StickerType_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StickerType_cmb.FormattingEnabled = True
        Me.StickerType_cmb.Items.AddRange(New Object() {"Nee", "Ja", "Voorbereiden (potcover/label)", "Floraconnect", "Floraconnect voorbereiden", "Nep order voor stikkers", "Lb: Voorbereiden", "Lb: Op pot plakken", "Wachten op labelbericht", "Document toevoegen", "Document toevoegen+stickeren", "Stikker op hoes", "DFD geprint"})
        Me.StickerType_cmb.Location = New System.Drawing.Point(601, 101)
        Me.StickerType_cmb.Name = "StickerType_cmb"
        Me.StickerType_cmb.Size = New System.Drawing.Size(146, 21)
        Me.StickerType_cmb.TabIndex = 60
        '
        'Order_aanvulling_chk
        '
        Me.Order_aanvulling_chk.AutoSize = True
        Me.Order_aanvulling_chk.Location = New System.Drawing.Point(558, 166)
        Me.Order_aanvulling_chk.Name = "Order_aanvulling_chk"
        Me.Order_aanvulling_chk.Size = New System.Drawing.Size(75, 17)
        Me.Order_aanvulling_chk.TabIndex = 59
        Me.Order_aanvulling_chk.Text = "Aanvulling"
        Me.Order_aanvulling_chk.UseVisualStyleBackColor = True
        '
        'orders_opmerking_opslaan
        '
        Me.orders_opmerking_opslaan.Location = New System.Drawing.Point(748, 225)
        Me.orders_opmerking_opslaan.Name = "orders_opmerking_opslaan"
        Me.orders_opmerking_opslaan.Size = New System.Drawing.Size(25, 96)
        Me.orders_opmerking_opslaan.TabIndex = 58
        Me.orders_opmerking_opslaan.Text = "Opslaan"
        Me.orders_opmerking_opslaan.UseVisualStyleBackColor = True
        '
        'Order_OpmTab
        '
        Me.Order_OpmTab.Controls.Add(Me.opmerking)
        Me.Order_OpmTab.Controls.Add(Me.orderinfo)
        Me.Order_OpmTab.Controls.Add(Me.pakboninfo)
        Me.Order_OpmTab.Controls.Add(Me.koper1)
        Me.Order_OpmTab.Controls.Add(Me.koper2)
        Me.Order_OpmTab.Controls.Add(Me.koper3)
        Me.Order_OpmTab.Controls.Add(Me.koper4)
        Me.Order_OpmTab.Controls.Add(Me.koper5)
        Me.Order_OpmTab.Controls.Add(Me.koper6)
        Me.Order_OpmTab.Controls.Add(Me.koper7)
        Me.Order_OpmTab.Controls.Add(Me.koper8)
        Me.Order_OpmTab.Controls.Add(Me.kopertoevoegen)
        Me.Order_OpmTab.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Order_OpmTab.Location = New System.Drawing.Point(15, 218)
        Me.Order_OpmTab.Name = "Order_OpmTab"
        Me.Order_OpmTab.SelectedIndex = 0
        Me.Order_OpmTab.Size = New System.Drawing.Size(727, 95)
        Me.Order_OpmTab.TabIndex = 57
        '
        'opmerking
        '
        Me.opmerking.Controls.Add(Me.Order_opmerking_txt)
        Me.opmerking.Location = New System.Drawing.Point(4, 22)
        Me.opmerking.Name = "opmerking"
        Me.opmerking.Padding = New System.Windows.Forms.Padding(3)
        Me.opmerking.Size = New System.Drawing.Size(719, 69)
        Me.opmerking.TabIndex = 0
        Me.opmerking.Text = "Koper info"
        Me.opmerking.UseVisualStyleBackColor = True
        '
        'Order_opmerking_txt
        '
        Me.Order_opmerking_txt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Order_opmerking_txt.Location = New System.Drawing.Point(3, 3)
        Me.Order_opmerking_txt.Multiline = True
        Me.Order_opmerking_txt.Name = "Order_opmerking_txt"
        Me.Order_opmerking_txt.Size = New System.Drawing.Size(713, 63)
        Me.Order_opmerking_txt.TabIndex = 27
        '
        'orderinfo
        '
        Me.orderinfo.Controls.Add(Me.Order_OpmOrderinfo_txt)
        Me.orderinfo.Location = New System.Drawing.Point(4, 22)
        Me.orderinfo.Name = "orderinfo"
        Me.orderinfo.Padding = New System.Windows.Forms.Padding(3)
        Me.orderinfo.Size = New System.Drawing.Size(719, 69)
        Me.orderinfo.TabIndex = 1
        Me.orderinfo.Text = "Order info"
        Me.orderinfo.UseVisualStyleBackColor = True
        '
        'Order_OpmOrderinfo_txt
        '
        Me.Order_OpmOrderinfo_txt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Order_OpmOrderinfo_txt.Location = New System.Drawing.Point(3, 3)
        Me.Order_OpmOrderinfo_txt.Multiline = True
        Me.Order_OpmOrderinfo_txt.Name = "Order_OpmOrderinfo_txt"
        Me.Order_OpmOrderinfo_txt.Size = New System.Drawing.Size(713, 63)
        Me.Order_OpmOrderinfo_txt.TabIndex = 1
        '
        'pakboninfo
        '
        Me.pakboninfo.Controls.Add(Me.Order_Pakboninfo_txt)
        Me.pakboninfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pakboninfo.Location = New System.Drawing.Point(4, 22)
        Me.pakboninfo.Name = "pakboninfo"
        Me.pakboninfo.Size = New System.Drawing.Size(719, 69)
        Me.pakboninfo.TabIndex = 2
        Me.pakboninfo.Text = "Pakbon info"
        Me.pakboninfo.UseVisualStyleBackColor = True
        '
        'Order_Pakboninfo_txt
        '
        Me.Order_Pakboninfo_txt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Order_Pakboninfo_txt.Location = New System.Drawing.Point(0, 0)
        Me.Order_Pakboninfo_txt.Multiline = True
        Me.Order_Pakboninfo_txt.Name = "Order_Pakboninfo_txt"
        Me.Order_Pakboninfo_txt.Size = New System.Drawing.Size(719, 69)
        Me.Order_Pakboninfo_txt.TabIndex = 2
        '
        'koper1
        '
        Me.koper1.Controls.Add(Me.Order_OpmKoper1_txt)
        Me.koper1.Location = New System.Drawing.Point(4, 22)
        Me.koper1.Name = "koper1"
        Me.koper1.Size = New System.Drawing.Size(719, 69)
        Me.koper1.TabIndex = 3
        Me.koper1.Tag = "koper"
        Me.koper1.Text = "koper1"
        Me.koper1.UseVisualStyleBackColor = True
        '
        'Order_OpmKoper1_txt
        '
        Me.Order_OpmKoper1_txt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Order_OpmKoper1_txt.Location = New System.Drawing.Point(0, 0)
        Me.Order_OpmKoper1_txt.Multiline = True
        Me.Order_OpmKoper1_txt.Name = "Order_OpmKoper1_txt"
        Me.Order_OpmKoper1_txt.Size = New System.Drawing.Size(719, 69)
        Me.Order_OpmKoper1_txt.TabIndex = 0
        '
        'koper2
        '
        Me.koper2.Controls.Add(Me.Order_OpmKoper2_txt)
        Me.koper2.Location = New System.Drawing.Point(4, 22)
        Me.koper2.Name = "koper2"
        Me.koper2.Size = New System.Drawing.Size(719, 69)
        Me.koper2.TabIndex = 4
        Me.koper2.Tag = "koper"
        Me.koper2.Text = "koper2"
        Me.koper2.UseVisualStyleBackColor = True
        '
        'Order_OpmKoper2_txt
        '
        Me.Order_OpmKoper2_txt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Order_OpmKoper2_txt.Location = New System.Drawing.Point(0, 0)
        Me.Order_OpmKoper2_txt.Multiline = True
        Me.Order_OpmKoper2_txt.Name = "Order_OpmKoper2_txt"
        Me.Order_OpmKoper2_txt.Size = New System.Drawing.Size(719, 69)
        Me.Order_OpmKoper2_txt.TabIndex = 1
        '
        'koper3
        '
        Me.koper3.Controls.Add(Me.Order_OpmKoper3_txt)
        Me.koper3.Location = New System.Drawing.Point(4, 22)
        Me.koper3.Name = "koper3"
        Me.koper3.Size = New System.Drawing.Size(719, 69)
        Me.koper3.TabIndex = 5
        Me.koper3.Tag = "koper"
        Me.koper3.Text = "koper3"
        Me.koper3.UseVisualStyleBackColor = True
        '
        'Order_OpmKoper3_txt
        '
        Me.Order_OpmKoper3_txt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Order_OpmKoper3_txt.Location = New System.Drawing.Point(0, 0)
        Me.Order_OpmKoper3_txt.Multiline = True
        Me.Order_OpmKoper3_txt.Name = "Order_OpmKoper3_txt"
        Me.Order_OpmKoper3_txt.Size = New System.Drawing.Size(719, 69)
        Me.Order_OpmKoper3_txt.TabIndex = 1
        '
        'koper4
        '
        Me.koper4.Controls.Add(Me.Order_OpmKoper4_txt)
        Me.koper4.Location = New System.Drawing.Point(4, 22)
        Me.koper4.Name = "koper4"
        Me.koper4.Size = New System.Drawing.Size(719, 69)
        Me.koper4.TabIndex = 6
        Me.koper4.Tag = "koper"
        Me.koper4.Text = "koper4"
        Me.koper4.UseVisualStyleBackColor = True
        '
        'Order_OpmKoper4_txt
        '
        Me.Order_OpmKoper4_txt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Order_OpmKoper4_txt.Location = New System.Drawing.Point(0, 0)
        Me.Order_OpmKoper4_txt.Multiline = True
        Me.Order_OpmKoper4_txt.Name = "Order_OpmKoper4_txt"
        Me.Order_OpmKoper4_txt.Size = New System.Drawing.Size(719, 69)
        Me.Order_OpmKoper4_txt.TabIndex = 1
        '
        'koper5
        '
        Me.koper5.Controls.Add(Me.Order_OpmKoper5_txt)
        Me.koper5.Location = New System.Drawing.Point(4, 22)
        Me.koper5.Name = "koper5"
        Me.koper5.Size = New System.Drawing.Size(719, 69)
        Me.koper5.TabIndex = 7
        Me.koper5.Tag = "koper"
        Me.koper5.Text = "koper5"
        Me.koper5.UseVisualStyleBackColor = True
        '
        'Order_OpmKoper5_txt
        '
        Me.Order_OpmKoper5_txt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Order_OpmKoper5_txt.Location = New System.Drawing.Point(0, 0)
        Me.Order_OpmKoper5_txt.Multiline = True
        Me.Order_OpmKoper5_txt.Name = "Order_OpmKoper5_txt"
        Me.Order_OpmKoper5_txt.Size = New System.Drawing.Size(719, 69)
        Me.Order_OpmKoper5_txt.TabIndex = 1
        '
        'koper6
        '
        Me.koper6.Controls.Add(Me.Order_OpmKoper6_txt)
        Me.koper6.Location = New System.Drawing.Point(4, 22)
        Me.koper6.Name = "koper6"
        Me.koper6.Size = New System.Drawing.Size(719, 69)
        Me.koper6.TabIndex = 8
        Me.koper6.Tag = "koper"
        Me.koper6.Text = "koper6"
        Me.koper6.UseVisualStyleBackColor = True
        '
        'Order_OpmKoper6_txt
        '
        Me.Order_OpmKoper6_txt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Order_OpmKoper6_txt.Location = New System.Drawing.Point(0, 0)
        Me.Order_OpmKoper6_txt.Multiline = True
        Me.Order_OpmKoper6_txt.Name = "Order_OpmKoper6_txt"
        Me.Order_OpmKoper6_txt.Size = New System.Drawing.Size(719, 69)
        Me.Order_OpmKoper6_txt.TabIndex = 1
        '
        'koper7
        '
        Me.koper7.Controls.Add(Me.Order_OpmKoper7_txt)
        Me.koper7.Location = New System.Drawing.Point(4, 22)
        Me.koper7.Name = "koper7"
        Me.koper7.Size = New System.Drawing.Size(719, 69)
        Me.koper7.TabIndex = 9
        Me.koper7.Tag = "koper"
        Me.koper7.Text = "koper7"
        Me.koper7.UseVisualStyleBackColor = True
        '
        'Order_OpmKoper7_txt
        '
        Me.Order_OpmKoper7_txt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Order_OpmKoper7_txt.Location = New System.Drawing.Point(0, 0)
        Me.Order_OpmKoper7_txt.Multiline = True
        Me.Order_OpmKoper7_txt.Name = "Order_OpmKoper7_txt"
        Me.Order_OpmKoper7_txt.Size = New System.Drawing.Size(719, 69)
        Me.Order_OpmKoper7_txt.TabIndex = 1
        '
        'koper8
        '
        Me.koper8.Controls.Add(Me.Order_OpmKoper8_txt)
        Me.koper8.Location = New System.Drawing.Point(4, 22)
        Me.koper8.Name = "koper8"
        Me.koper8.Size = New System.Drawing.Size(719, 69)
        Me.koper8.TabIndex = 10
        Me.koper8.Tag = "koper"
        Me.koper8.Text = "koper8"
        Me.koper8.UseVisualStyleBackColor = True
        '
        'Order_OpmKoper8_txt
        '
        Me.Order_OpmKoper8_txt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Order_OpmKoper8_txt.Location = New System.Drawing.Point(0, 0)
        Me.Order_OpmKoper8_txt.Multiline = True
        Me.Order_OpmKoper8_txt.Name = "Order_OpmKoper8_txt"
        Me.Order_OpmKoper8_txt.Size = New System.Drawing.Size(719, 69)
        Me.Order_OpmKoper8_txt.TabIndex = 1
        '
        'kopertoevoegen
        '
        Me.kopertoevoegen.Controls.Add(Me.Order_Opm_addcontactpannel)
        Me.kopertoevoegen.Location = New System.Drawing.Point(4, 22)
        Me.kopertoevoegen.Name = "kopertoevoegen"
        Me.kopertoevoegen.Size = New System.Drawing.Size(719, 69)
        Me.kopertoevoegen.TabIndex = 11
        Me.kopertoevoegen.Text = "   +"
        Me.kopertoevoegen.UseVisualStyleBackColor = True
        '
        'Order_Opm_addcontactpannel
        '
        Me.Order_Opm_addcontactpannel.Controls.Add(Me.Order_Opm_addcontact_but)
        Me.Order_Opm_addcontactpannel.Controls.Add(Me.Order_Opm_addcontact_lbl)
        Me.Order_Opm_addcontactpannel.Controls.Add(Me.Order_Opm_addcontact_txt)
        Me.Order_Opm_addcontactpannel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Order_Opm_addcontactpannel.Location = New System.Drawing.Point(0, 0)
        Me.Order_Opm_addcontactpannel.Name = "Order_Opm_addcontactpannel"
        Me.Order_Opm_addcontactpannel.Size = New System.Drawing.Size(719, 69)
        Me.Order_Opm_addcontactpannel.TabIndex = 0
        '
        'Order_Opm_addcontact_but
        '
        Me.Order_Opm_addcontact_but.Location = New System.Drawing.Point(335, 7)
        Me.Order_Opm_addcontact_but.Name = "Order_Opm_addcontact_but"
        Me.Order_Opm_addcontact_but.Size = New System.Drawing.Size(91, 27)
        Me.Order_Opm_addcontact_but.TabIndex = 2
        Me.Order_Opm_addcontact_but.Text = "Toevoegen"
        Me.Order_Opm_addcontact_but.UseVisualStyleBackColor = True
        '
        'Order_Opm_addcontact_lbl
        '
        Me.Order_Opm_addcontact_lbl.AutoSize = True
        Me.Order_Opm_addcontact_lbl.Location = New System.Drawing.Point(15, 14)
        Me.Order_Opm_addcontact_lbl.Name = "Order_Opm_addcontact_lbl"
        Me.Order_Opm_addcontact_lbl.Size = New System.Drawing.Size(101, 13)
        Me.Order_Opm_addcontact_lbl.TabIndex = 1
        Me.Order_Opm_addcontact_lbl.Text = "Contact toevoegen:"
        '
        'Order_Opm_addcontact_txt
        '
        Me.Order_Opm_addcontact_txt.Location = New System.Drawing.Point(126, 12)
        Me.Order_Opm_addcontact_txt.Name = "Order_Opm_addcontact_txt"
        Me.Order_Opm_addcontact_txt.Size = New System.Drawing.Size(201, 20)
        Me.Order_Opm_addcontact_txt.TabIndex = 0
        '
        'Order_Prijscor_min_but
        '
        Me.Order_Prijscor_min_but.Location = New System.Drawing.Point(633, 328)
        Me.Order_Prijscor_min_but.Name = "Order_Prijscor_min_but"
        Me.Order_Prijscor_min_but.Size = New System.Drawing.Size(25, 21)
        Me.Order_Prijscor_min_but.TabIndex = 56
        Me.Order_Prijscor_min_but.Text = "-"
        Me.Order_Prijscor_min_but.UseVisualStyleBackColor = True
        '
        'Order_Prijs_correctie_lbl
        '
        Me.Order_Prijs_correctie_lbl.AutoSize = True
        Me.Order_Prijs_correctie_lbl.Location = New System.Drawing.Point(669, 313)
        Me.Order_Prijs_correctie_lbl.Name = "Order_Prijs_correctie_lbl"
        Me.Order_Prijs_correctie_lbl.Size = New System.Drawing.Size(67, 13)
        Me.Order_Prijs_correctie_lbl.TabIndex = 55
        Me.Order_Prijs_correctie_lbl.Text = "Prijscorrectie"
        '
        'Order_Prijscor_plus_but
        '
        Me.Order_Prijscor_plus_but.Location = New System.Drawing.Point(767, 328)
        Me.Order_Prijscor_plus_but.Name = "Order_Prijscor_plus_but"
        Me.Order_Prijscor_plus_but.Size = New System.Drawing.Size(25, 21)
        Me.Order_Prijscor_plus_but.TabIndex = 54
        Me.Order_Prijscor_plus_but.Text = "+"
        Me.Order_Prijscor_plus_but.UseVisualStyleBackColor = True
        '
        'Order_Prijscor_prijs_txt
        '
        Me.Order_Prijscor_prijs_txt.Location = New System.Drawing.Point(695, 329)
        Me.Order_Prijscor_prijs_txt.Name = "Order_Prijscor_prijs_txt"
        Me.Order_Prijscor_prijs_txt.Size = New System.Drawing.Size(33, 20)
        Me.Order_Prijscor_prijs_txt.TabIndex = 53
        Me.Order_Prijscor_prijs_txt.Text = "0.05"
        '
        'Order_herbereken_prijzen
        '
        Me.Order_herbereken_prijzen.Location = New System.Drawing.Point(727, 72)
        Me.Order_herbereken_prijzen.Name = "Order_herbereken_prijzen"
        Me.Order_herbereken_prijzen.Size = New System.Drawing.Size(20, 20)
        Me.Order_herbereken_prijzen.TabIndex = 52
        Me.Order_herbereken_prijzen.Text = "H"
        Me.Order_herbereken_prijzen.UseVisualStyleBackColor = True
        '
        'Order_reservering_chk
        '
        Me.Order_reservering_chk.AutoSize = True
        Me.Order_reservering_chk.Location = New System.Drawing.Point(558, 148)
        Me.Order_reservering_chk.Name = "Order_reservering_chk"
        Me.Order_reservering_chk.Size = New System.Drawing.Size(83, 17)
        Me.Order_reservering_chk.TabIndex = 51
        Me.Order_reservering_chk.Text = "Reservering"
        Me.Order_reservering_chk.UseVisualStyleBackColor = True
        '
        'Order_versie_lbl
        '
        Me.Order_versie_lbl.AutoSize = True
        Me.Order_versie_lbl.Location = New System.Drawing.Point(759, 32)
        Me.Order_versie_lbl.Name = "Order_versie_lbl"
        Me.Order_versie_lbl.Size = New System.Drawing.Size(13, 13)
        Me.Order_versie_lbl.TabIndex = 50
        Me.Order_versie_lbl.Text = "0"
        '
        'Order_versietxt_lbl
        '
        Me.Order_versietxt_lbl.AutoSize = True
        Me.Order_versietxt_lbl.Location = New System.Drawing.Point(706, 32)
        Me.Order_versietxt_lbl.Name = "Order_versietxt_lbl"
        Me.Order_versietxt_lbl.Size = New System.Drawing.Size(39, 13)
        Me.Order_versietxt_lbl.TabIndex = 49
        Me.Order_versietxt_lbl.Text = "Versie:"
        '
        'Order_Slot_Chk
        '
        Me.Order_Slot_Chk.AutoSize = True
        Me.Order_Slot_Chk.Location = New System.Drawing.Point(152, 327)
        Me.Order_Slot_Chk.Name = "Order_Slot_Chk"
        Me.Order_Slot_Chk.Size = New System.Drawing.Size(44, 17)
        Me.Order_Slot_Chk.TabIndex = 48
        Me.Order_Slot_Chk.Text = "Slot"
        Me.Order_Slot_Chk.UseVisualStyleBackColor = True
        '
        'Order_OverMorgen_but
        '
        Me.Order_OverMorgen_but.Location = New System.Drawing.Point(372, 12)
        Me.Order_OverMorgen_but.Name = "Order_OverMorgen_but"
        Me.Order_OverMorgen_but.Size = New System.Drawing.Size(88, 24)
        Me.Order_OverMorgen_but.TabIndex = 47
        Me.Order_OverMorgen_but.Text = "Overmorgen"
        Me.Order_OverMorgen_but.UseVisualStyleBackColor = True
        '
        'Order_idtxt_lbl
        '
        Me.Order_idtxt_lbl.AutoSize = True
        Me.Order_idtxt_lbl.Location = New System.Drawing.Point(706, 10)
        Me.Order_idtxt_lbl.Name = "Order_idtxt_lbl"
        Me.Order_idtxt_lbl.Size = New System.Drawing.Size(50, 13)
        Me.Order_idtxt_lbl.TabIndex = 46
        Me.Order_idtxt_lbl.Text = "Order ID:"
        '
        'Order_id_lbl
        '
        Me.Order_id_lbl.AutoSize = True
        Me.Order_id_lbl.Location = New System.Drawing.Point(759, 10)
        Me.Order_id_lbl.Name = "Order_id_lbl"
        Me.Order_id_lbl.Size = New System.Drawing.Size(13, 13)
        Me.Order_id_lbl.TabIndex = 45
        Me.Order_id_lbl.Text = "0"
        '
        'Order_admnr_txt
        '
        Me.Order_admnr_txt.Location = New System.Drawing.Point(500, 72)
        Me.Order_admnr_txt.Name = "Order_admnr_txt"
        Me.Order_admnr_txt.Size = New System.Drawing.Size(71, 20)
        Me.Order_admnr_txt.TabIndex = 17
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(314, 76)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(32, 13)
        Me.Label16.TabIndex = 43
        Me.Label16.Text = "EAN:"
        '
        'order_contacts_combo
        '
        Me.order_contacts_combo.FormattingEnabled = True
        Me.order_contacts_combo.Location = New System.Drawing.Point(377, 155)
        Me.order_contacts_combo.Name = "order_contacts_combo"
        Me.order_contacts_combo.Size = New System.Drawing.Size(165, 21)
        Me.order_contacts_combo.TabIndex = 24
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(313, 161)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(44, 13)
        Me.Label15.TabIndex = 41
        Me.Label15.Text = "Contact"
        '
        'Order_Decorum_chk
        '
        Me.Order_Decorum_chk.AutoSize = True
        Me.Order_Decorum_chk.Enabled = False
        Me.Order_Decorum_chk.Location = New System.Drawing.Point(558, 128)
        Me.Order_Decorum_chk.Name = "Order_Decorum_chk"
        Me.Order_Decorum_chk.Size = New System.Drawing.Size(69, 17)
        Me.Order_Decorum_chk.TabIndex = 25
        Me.Order_Decorum_chk.Text = "Decorum"
        Me.Order_Decorum_chk.UseVisualStyleBackColor = True
        '
        'Order_koper_combo
        '
        Me.Order_koper_combo.FormattingEnabled = True
        Me.Order_koper_combo.Location = New System.Drawing.Point(72, 73)
        Me.Order_koper_combo.Name = "Order_koper_combo"
        Me.Order_koper_combo.Size = New System.Drawing.Size(229, 21)
        Me.Order_koper_combo.TabIndex = 16
        '
        'Order_groep5_but
        '
        Me.Order_groep5_but.Location = New System.Drawing.Point(548, 319)
        Me.Order_groep5_but.Name = "Order_groep5_but"
        Me.Order_groep5_but.Size = New System.Drawing.Size(81, 31)
        Me.Order_groep5_but.TabIndex = 33
        Me.Order_groep5_but.Text = "Groep 5"
        Me.Order_groep5_but.UseVisualStyleBackColor = True
        '
        'Order_groep4_but
        '
        Me.Order_groep4_but.Location = New System.Drawing.Point(461, 319)
        Me.Order_groep4_but.Name = "Order_groep4_but"
        Me.Order_groep4_but.Size = New System.Drawing.Size(81, 31)
        Me.Order_groep4_but.TabIndex = 32
        Me.Order_groep4_but.Text = "Groep 4"
        Me.Order_groep4_but.UseVisualStyleBackColor = True
        '
        'Order_groep3_but
        '
        Me.Order_groep3_but.Location = New System.Drawing.Point(374, 319)
        Me.Order_groep3_but.Name = "Order_groep3_but"
        Me.Order_groep3_but.Size = New System.Drawing.Size(81, 31)
        Me.Order_groep3_but.TabIndex = 31
        Me.Order_groep3_but.Text = "Groep 3"
        Me.Order_groep3_but.UseVisualStyleBackColor = True
        '
        'Order_groep2_but
        '
        Me.Order_groep2_but.Location = New System.Drawing.Point(287, 319)
        Me.Order_groep2_but.Name = "Order_groep2_but"
        Me.Order_groep2_but.Size = New System.Drawing.Size(81, 31)
        Me.Order_groep2_but.TabIndex = 30
        Me.Order_groep2_but.Text = "Groep 2"
        Me.Order_groep2_but.UseVisualStyleBackColor = True
        '
        'Order_AflevertijdZA_but
        '
        Me.Order_AflevertijdZA_but.Location = New System.Drawing.Point(370, 42)
        Me.Order_AflevertijdZA_but.Name = "Order_AflevertijdZA_but"
        Me.Order_AflevertijdZA_but.Size = New System.Drawing.Size(56, 24)
        Me.Order_AflevertijdZA_but.TabIndex = 15
        Me.Order_AflevertijdZA_but.Text = "ZA"
        Me.Order_AflevertijdZA_but.UseVisualStyleBackColor = True
        '
        'Order_Vandaag_but
        '
        Me.Order_Vandaag_but.Location = New System.Drawing.Point(186, 12)
        Me.Order_Vandaag_but.Name = "Order_Vandaag_but"
        Me.Order_Vandaag_but.Size = New System.Drawing.Size(87, 24)
        Me.Order_Vandaag_but.TabIndex = 9
        Me.Order_Vandaag_but.Text = "Vandaag"
        Me.Order_Vandaag_but.UseVisualStyleBackColor = True
        '
        'Order_groep1_but
        '
        Me.Order_groep1_but.Location = New System.Drawing.Point(200, 319)
        Me.Order_groep1_but.Name = "Order_groep1_but"
        Me.Order_groep1_but.Size = New System.Drawing.Size(81, 31)
        Me.Order_groep1_but.TabIndex = 29
        Me.Order_groep1_but.Text = "Groep 1"
        Me.Order_groep1_but.UseVisualStyleBackColor = True
        '
        'Order_InstelOpslaan_but
        '
        Me.Order_InstelOpslaan_but.Location = New System.Drawing.Point(572, 10)
        Me.Order_InstelOpslaan_but.Name = "Order_InstelOpslaan_but"
        Me.Order_InstelOpslaan_but.Size = New System.Drawing.Size(126, 29)
        Me.Order_InstelOpslaan_but.TabIndex = 27
        Me.Order_InstelOpslaan_but.Text = "Instellingen opslaan"
        Me.Order_InstelOpslaan_but.UseVisualStyleBackColor = True
        '
        'Order_Opslaan_but
        '
        Me.Order_Opslaan_but.Location = New System.Drawing.Point(5, 319)
        Me.Order_Opslaan_but.Name = "Order_Opslaan_but"
        Me.Order_Opslaan_but.Size = New System.Drawing.Size(143, 31)
        Me.Order_Opslaan_but.TabIndex = 28
        Me.Order_Opslaan_but.Text = "Opslaan"
        Me.Order_Opslaan_but.UseVisualStyleBackColor = True
        '
        'Order_prijsopslag_txt
        '
        Me.Order_prijsopslag_txt.Location = New System.Drawing.Point(661, 72)
        Me.Order_prijsopslag_txt.Name = "Order_prijsopslag_txt"
        Me.Order_prijsopslag_txt.Size = New System.Drawing.Size(57, 20)
        Me.Order_prijsopslag_txt.TabIndex = 20
        Me.Order_prijsopslag_txt.Text = "0.00"
        '
        'Order_vervoerder_combo
        '
        Me.Order_vervoerder_combo.FormattingEnabled = True
        Me.Order_vervoerder_combo.Location = New System.Drawing.Point(377, 128)
        Me.Order_vervoerder_combo.Name = "Order_vervoerder_combo"
        Me.Order_vervoerder_combo.Size = New System.Drawing.Size(165, 21)
        Me.Order_vervoerder_combo.TabIndex = 22
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(598, 72)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(57, 13)
        Me.Label19.TabIndex = 27
        Me.Label19.Text = "Prijsopslag"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(313, 134)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(59, 13)
        Me.Label18.TabIndex = 26
        Me.Label18.Text = "Vervoerder"
        '
        'Order_veilingbrief_combo
        '
        Me.Order_veilingbrief_combo.FormattingEnabled = True
        Me.Order_veilingbrief_combo.Location = New System.Drawing.Point(377, 101)
        Me.Order_veilingbrief_combo.Name = "Order_veilingbrief_combo"
        Me.Order_veilingbrief_combo.Size = New System.Drawing.Size(165, 21)
        Me.Order_veilingbrief_combo.TabIndex = 19
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(313, 104)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(58, 13)
        Me.Label17.TabIndex = 24
        Me.Label17.Text = "Veilingbrief"
        '
        'Order_kar_combo
        '
        Me.Order_kar_combo.FormattingEnabled = True
        Me.Order_kar_combo.Location = New System.Drawing.Point(72, 131)
        Me.Order_kar_combo.Name = "Order_kar_combo"
        Me.Order_kar_combo.Size = New System.Drawing.Size(230, 21)
        Me.Order_kar_combo.TabIndex = 21
        '
        'Order_afleverloc_combo
        '
        Me.Order_afleverloc_combo.FormattingEnabled = True
        Me.Order_afleverloc_combo.Location = New System.Drawing.Point(72, 101)
        Me.Order_afleverloc_combo.Name = "Order_afleverloc_combo"
        Me.Order_afleverloc_combo.Size = New System.Drawing.Size(230, 21)
        Me.Order_afleverloc_combo.TabIndex = 18
        '
        'Order_admnr_lbl
        '
        Me.Order_admnr_lbl.AutoSize = True
        Me.Order_admnr_lbl.Location = New System.Drawing.Point(442, 75)
        Me.Order_admnr_lbl.Name = "Order_admnr_lbl"
        Me.Order_admnr_lbl.Size = New System.Drawing.Size(52, 13)
        Me.Order_admnr_lbl.TabIndex = 19
        Me.Order_admnr_lbl.Text = "Admn. nr:"
        '
        'Order_ean_lbl
        '
        Me.Order_ean_lbl.AutoSize = True
        Me.Order_ean_lbl.Location = New System.Drawing.Point(351, 76)
        Me.Order_ean_lbl.Name = "Order_ean_lbl"
        Me.Order_ean_lbl.Size = New System.Drawing.Size(85, 13)
        Me.Order_ean_lbl.TabIndex = 18
        Me.Order_ean_lbl.Text = "0000000000000"
        '
        'Order_Aflevertijd17_but
        '
        Me.Order_Aflevertijd17_but.Location = New System.Drawing.Point(308, 42)
        Me.Order_Aflevertijd17_but.Name = "Order_Aflevertijd17_but"
        Me.Order_Aflevertijd17_but.Size = New System.Drawing.Size(56, 24)
        Me.Order_Aflevertijd17_but.TabIndex = 14
        Me.Order_Aflevertijd17_but.Text = "17:00"
        Me.Order_Aflevertijd17_but.UseVisualStyleBackColor = True
        '
        'Order_Aflevertijd12_but
        '
        Me.Order_Aflevertijd12_but.Location = New System.Drawing.Point(246, 42)
        Me.Order_Aflevertijd12_but.Name = "Order_Aflevertijd12_but"
        Me.Order_Aflevertijd12_but.Size = New System.Drawing.Size(56, 24)
        Me.Order_Aflevertijd12_but.TabIndex = 13
        Me.Order_Aflevertijd12_but.Text = "12:00"
        Me.Order_Aflevertijd12_but.UseVisualStyleBackColor = True
        '
        'Order_Aflevertijd9_but
        '
        Me.Order_Aflevertijd9_but.Location = New System.Drawing.Point(184, 42)
        Me.Order_Aflevertijd9_but.Name = "Order_Aflevertijd9_but"
        Me.Order_Aflevertijd9_but.Size = New System.Drawing.Size(56, 24)
        Me.Order_Aflevertijd9_but.TabIndex = 12
        Me.Order_Aflevertijd9_but.Text = "9:00"
        Me.Order_Aflevertijd9_but.UseVisualStyleBackColor = True
        '
        'Order_Aflevertijd_combo
        '
        Me.Order_Aflevertijd_combo.FormattingEnabled = True
        Me.Order_Aflevertijd_combo.Items.AddRange(New Object() {"7:00", "8:00", "9:00", "10:00", "11:00", "12:00", "13:00", "14:00", "14:30", "15:00", "16:00", "17:00"})
        Me.Order_Aflevertijd_combo.Location = New System.Drawing.Point(72, 44)
        Me.Order_Aflevertijd_combo.MaxDropDownItems = 10
        Me.Order_Aflevertijd_combo.Name = "Order_Aflevertijd_combo"
        Me.Order_Aflevertijd_combo.Size = New System.Drawing.Size(91, 21)
        Me.Order_Aflevertijd_combo.TabIndex = 11
        '
        'Order_Morgen_but
        '
        Me.Order_Morgen_but.Location = New System.Drawing.Point(279, 12)
        Me.Order_Morgen_but.Name = "Order_Morgen_but"
        Me.Order_Morgen_but.Size = New System.Drawing.Size(87, 24)
        Me.Order_Morgen_but.TabIndex = 10
        Me.Order_Morgen_but.Text = "Morgen"
        Me.Order_Morgen_but.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(184, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 24)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Vandaag"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OrderDateTimePicker
        '
        Me.OrderDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.OrderDateTimePicker.Location = New System.Drawing.Point(72, 14)
        Me.OrderDateTimePicker.Name = "OrderDateTimePicker"
        Me.OrderDateTimePicker.Size = New System.Drawing.Size(104, 20)
        Me.OrderDateTimePicker.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 139)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(23, 13)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Kar"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 109)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Afleverloc."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 75)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Koper"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Aflevertijd"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Datum"
        '
        'Order_invoer_FlexGrid
        '
        Me.Order_invoer_FlexGrid.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.Order_invoer_FlexGrid.ColumnInfo = resources.GetString("Order_invoer_FlexGrid.ColumnInfo")
        Me.Order_invoer_FlexGrid.Location = New System.Drawing.Point(4, 363)
        Me.Order_invoer_FlexGrid.Name = "Order_invoer_FlexGrid"
        Me.Order_invoer_FlexGrid.Rows.Count = 1
        Me.Order_invoer_FlexGrid.Rows.DefaultSize = 17
        Me.Order_invoer_FlexGrid.Size = New System.Drawing.Size(875, 573)
        Me.Order_invoer_FlexGrid.TabIndex = 34
        '
        'C1TabKarindeling
        '
        Me.C1TabKarindeling.Controls.Add(Me.C1SizerKarIndeling)
        Me.C1TabKarindeling.Location = New System.Drawing.Point(1, 24)
        Me.C1TabKarindeling.Name = "C1TabKarindeling"
        Me.C1TabKarindeling.Size = New System.Drawing.Size(883, 940)
        Me.C1TabKarindeling.TabIndex = 1
        Me.C1TabKarindeling.Text = "Kar indeling"
        '
        'C1SizerKarIndeling
        '
        Me.C1SizerKarIndeling.Controls.Add(Me.PanelKarindelingOnder)
        Me.C1SizerKarIndeling.Controls.Add(Me.HScrollBar1)
        Me.C1SizerKarIndeling.Controls.Add(Me.PanelKarindelingMidden)
        Me.C1SizerKarIndeling.Controls.Add(Me.PanelKarIndelingBoven)
        Me.C1SizerKarIndeling.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1SizerKarIndeling.GridDefinition = "10.6382978723404:False:True;68.0851063829787:False:True;2.12765957446809:False:Tr" &
    "ue;17.0212765957447:False:False;" & Global.Microsoft.VisualBasic.ChrW(9) & "99.0939977349943:False:False;"
        Me.C1SizerKarIndeling.Location = New System.Drawing.Point(0, 0)
        Me.C1SizerKarIndeling.Name = "C1SizerKarIndeling"
        Me.C1SizerKarIndeling.Size = New System.Drawing.Size(883, 940)
        Me.C1SizerKarIndeling.TabIndex = 0
        Me.C1SizerKarIndeling.Text = "C1Sizer2"
        '
        'PanelKarindelingOnder
        '
        Me.PanelKarindelingOnder.Controls.Add(Me.Kar_markeer_chk)
        Me.PanelKarindelingOnder.Controls.Add(Me.Kar_SortMartin_but)
        Me.PanelKarindelingOnder.Controls.Add(Me.Kar_opnieuwberekeneninvoer_but)
        Me.PanelKarindelingOnder.Controls.Add(Me.Kar_verdelenals2_but)
        Me.PanelKarindelingOnder.Controls.Add(Me.Kar_allesop1_but)
        Me.PanelKarindelingOnder.Controls.Add(Me.Kar_opnieuwberekenen_but)
        Me.PanelKarindelingOnder.Controls.Add(Me.Kar_opslaan2_but)
        Me.PanelKarindelingOnder.Location = New System.Drawing.Point(4, 776)
        Me.PanelKarindelingOnder.Name = "PanelKarindelingOnder"
        Me.PanelKarindelingOnder.Size = New System.Drawing.Size(875, 160)
        Me.PanelKarindelingOnder.TabIndex = 3
        '
        'Kar_markeer_chk
        '
        Me.Kar_markeer_chk.AutoSize = True
        Me.Kar_markeer_chk.Location = New System.Drawing.Point(247, 24)
        Me.Kar_markeer_chk.Name = "Kar_markeer_chk"
        Me.Kar_markeer_chk.Size = New System.Drawing.Size(65, 17)
        Me.Kar_markeer_chk.TabIndex = 29
        Me.Kar_markeer_chk.Text = "Markeer"
        Me.Kar_markeer_chk.UseVisualStyleBackColor = True
        '
        'Kar_SortMartin_but
        '
        Me.Kar_SortMartin_but.Location = New System.Drawing.Point(13, 112)
        Me.Kar_SortMartin_but.Name = "Kar_SortMartin_but"
        Me.Kar_SortMartin_but.Size = New System.Drawing.Size(170, 37)
        Me.Kar_SortMartin_but.TabIndex = 28
        Me.Kar_SortMartin_but.Text = "Karindeling Martin "
        Me.Kar_SortMartin_but.UseVisualStyleBackColor = True
        '
        'Kar_opnieuwberekeneninvoer_but
        '
        Me.Kar_opnieuwberekeneninvoer_but.Location = New System.Drawing.Point(367, 69)
        Me.Kar_opnieuwberekeneninvoer_but.Name = "Kar_opnieuwberekeneninvoer_but"
        Me.Kar_opnieuwberekeneninvoer_but.Size = New System.Drawing.Size(170, 37)
        Me.Kar_opnieuwberekeneninvoer_but.TabIndex = 27
        Me.Kar_opnieuwberekeneninvoer_but.Text = "Karindeling opnieuw berekenen volgens invoer volgorde"
        Me.Kar_opnieuwberekeneninvoer_but.UseVisualStyleBackColor = True
        '
        'Kar_verdelenals2_but
        '
        Me.Kar_verdelenals2_but.Location = New System.Drawing.Point(191, 69)
        Me.Kar_verdelenals2_but.Name = "Kar_verdelenals2_but"
        Me.Kar_verdelenals2_but.Size = New System.Drawing.Size(170, 37)
        Me.Kar_verdelenals2_but.TabIndex = 26
        Me.Kar_verdelenals2_but.Text = "Verdelen zoals kar 2"
        Me.Kar_verdelenals2_but.UseVisualStyleBackColor = True
        '
        'Kar_allesop1_but
        '
        Me.Kar_allesop1_but.Location = New System.Drawing.Point(13, 69)
        Me.Kar_allesop1_but.Name = "Kar_allesop1_but"
        Me.Kar_allesop1_but.Size = New System.Drawing.Size(168, 37)
        Me.Kar_allesop1_but.TabIndex = 25
        Me.Kar_allesop1_but.Text = "Alles op één kar"
        Me.Kar_allesop1_but.UseVisualStyleBackColor = True
        '
        'Kar_opnieuwberekenen_but
        '
        Me.Kar_opnieuwberekenen_but.Location = New System.Drawing.Point(191, 112)
        Me.Kar_opnieuwberekenen_but.Name = "Kar_opnieuwberekenen_but"
        Me.Kar_opnieuwberekenen_but.Size = New System.Drawing.Size(170, 37)
        Me.Kar_opnieuwberekenen_but.TabIndex = 24
        Me.Kar_opnieuwberekenen_but.Text = "Karindeling opnieuw berekenen"
        Me.Kar_opnieuwberekenen_but.UseVisualStyleBackColor = True
        '
        'Kar_opslaan2_but
        '
        Me.Kar_opslaan2_but.Location = New System.Drawing.Point(13, 13)
        Me.Kar_opslaan2_but.Name = "Kar_opslaan2_but"
        Me.Kar_opslaan2_but.Size = New System.Drawing.Size(225, 37)
        Me.Kar_opslaan2_but.TabIndex = 23
        Me.Kar_opslaan2_but.Text = "Karindeling opslaan"
        Me.Kar_opslaan2_but.UseVisualStyleBackColor = True
        '
        'HScrollBar1
        '
        Me.HScrollBar1.LargeChange = 4
        Me.HScrollBar1.Location = New System.Drawing.Point(4, 752)
        Me.HScrollBar1.Maximum = 99
        Me.HScrollBar1.Minimum = 1
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(875, 20)
        Me.HScrollBar1.TabIndex = 2
        Me.HScrollBar1.Value = 1
        '
        'PanelKarindelingMidden
        '
        Me.PanelKarindelingMidden.AutoScroll = True
        Me.PanelKarindelingMidden.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_Kartype4_cmb)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_Kartype3_cmb)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_Kartype2_cmb)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_Kartype1_cmb)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_fdverzonden4_chk)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_fdverzonden3_chk)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_fdverzonden2_chk)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_fdverzonden1_chk)
        Me.PanelKarindelingMidden.Controls.Add(Me.KarCommand4_but)
        Me.PanelKarindelingMidden.Controls.Add(Me.KarCommand4_cmb)
        Me.PanelKarindelingMidden.Controls.Add(Me.KarCommand3_but)
        Me.PanelKarindelingMidden.Controls.Add(Me.KarCommand3_cmb)
        Me.PanelKarindelingMidden.Controls.Add(Me.KarCommand2_but)
        Me.PanelKarindelingMidden.Controls.Add(Me.KarCommand2_cmb)
        Me.PanelKarindelingMidden.Controls.Add(Me.KarCommand1_but)
        Me.PanelKarindelingMidden.Controls.Add(Me.KarCommand1_cmb)
        Me.PanelKarindelingMidden.Controls.Add(Me.kar_overgooien4_wis_but)
        Me.PanelKarindelingMidden.Controls.Add(Me.kar_overgooien4_hierop_but)
        Me.PanelKarindelingMidden.Controls.Add(Me.kar_overgooien4_naar_but)
        Me.PanelKarindelingMidden.Controls.Add(Me.kar_overgooien3_wis_but)
        Me.PanelKarindelingMidden.Controls.Add(Me.kar_overgooien3_hierop_but)
        Me.PanelKarindelingMidden.Controls.Add(Me.kar_overgooien3_naar_but)
        Me.PanelKarindelingMidden.Controls.Add(Me.kar_overgooien2_wis_but)
        Me.PanelKarindelingMidden.Controls.Add(Me.kar_overgooien2_hierop_but)
        Me.PanelKarindelingMidden.Controls.Add(Me.kar_overgooien2_naar_but)
        Me.PanelKarindelingMidden.Controls.Add(Me.kar_overgooien1_wis_but)
        Me.PanelKarindelingMidden.Controls.Add(Me.kar_overgooien1_hierop_but)
        Me.PanelKarindelingMidden.Controls.Add(Me.kar_overgooien1_naar_but)
        Me.PanelKarindelingMidden.Controls.Add(Me.kar_aanvulling4_but)
        Me.PanelKarindelingMidden.Controls.Add(Me.kar_aanvulling3_but)
        Me.PanelKarindelingMidden.Controls.Add(Me.kar_aanvulling2_but)
        Me.PanelKarindelingMidden.Controls.Add(Me.kar_aanvulling1_but)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_lagenlock4_but)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_lagenlock3_but)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_lagenlock2_but)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_lagenlock1_but)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_autosamenvoegen4_chk)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_autosamenvoegen3_chk)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_autosamenvoegen2_chk)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_autosamenvoegen1_chk)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_nummer4_lbl)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_nummer3_lbl)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_nummer2_lbl)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_nummer1_lbl)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_lagen4_lbl)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_lagen4_txt)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_vervoer4_chk)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_sdfverzonden4_chk)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_flexgrid4)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_rfid4_lbl)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_barcode4_lbl)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_rfid4_txt)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_barcode4_txt)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_aantaltotaal4_lbl)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_down4_but)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_up4_but)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_plus4_but)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_lagen3_lbl)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_lagen3_txt)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_vervoer3_chk)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_sdfverzonden3_chk)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_flexgrid3)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_rfid3_lbl)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_barcode3_lbl)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_rfid3_txt)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_barcode3_txt)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_aantaltotaal3_lbl)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_down3_but)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_up3_but)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_plus3_but)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_lagen2_lbl)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_lagen2_txt)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_vervoer2_chk)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_sdfverzonden2_chk)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_flexgrid2)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_rfid2_lbl)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_barcode2_lbl)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_rfid2_txt)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_barcode2_txt)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_aantaltotaal2_lbl)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_down2_but)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_up2_but)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_plus2_but)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_lagen1_lbl)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_lagen1_txt)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_vervoer1_chk)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_sdfverzonden1_chk)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_flexgrid1)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_rfid1_lbl)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_barcode1_lbl)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_rfid1_txt)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_barcode1_txt)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_aantaltotaal1_lbl)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_down1_but)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_up1_but)
        Me.PanelKarindelingMidden.Controls.Add(Me.Kar_plus1_but)
        Me.PanelKarindelingMidden.Location = New System.Drawing.Point(4, 108)
        Me.PanelKarindelingMidden.Name = "PanelKarindelingMidden"
        Me.PanelKarindelingMidden.Size = New System.Drawing.Size(875, 640)
        Me.PanelKarindelingMidden.TabIndex = 1
        '
        'Kar_Kartype4_cmb
        '
        Me.Kar_Kartype4_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Kar_Kartype4_cmb.FormattingEnabled = True
        Me.Kar_Kartype4_cmb.Items.AddRange(New Object() {"deense lagen", "extra platen en 1 FH Kar", "N.V.T.", "deense lagen (geen CC)", "Euro Trolley", "Pallet", "Euro Pallet"})
        Me.Kar_Kartype4_cmb.Location = New System.Drawing.Point(772, 438)
        Me.Kar_Kartype4_cmb.Name = "Kar_Kartype4_cmb"
        Me.Kar_Kartype4_cmb.Size = New System.Drawing.Size(142, 21)
        Me.Kar_Kartype4_cmb.TabIndex = 116
        Me.Kar_Kartype4_cmb.Tag = "4"
        '
        'Kar_Kartype3_cmb
        '
        Me.Kar_Kartype3_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Kar_Kartype3_cmb.FormattingEnabled = True
        Me.Kar_Kartype3_cmb.Items.AddRange(New Object() {"deense lagen", "extra platen en 1 FH Kar", "N.V.T.", "deense lagen (geen CC)", "Euro Trolley", "Pallet", "Euro Pallet"})
        Me.Kar_Kartype3_cmb.Location = New System.Drawing.Point(539, 435)
        Me.Kar_Kartype3_cmb.Name = "Kar_Kartype3_cmb"
        Me.Kar_Kartype3_cmb.Size = New System.Drawing.Size(142, 21)
        Me.Kar_Kartype3_cmb.TabIndex = 115
        Me.Kar_Kartype3_cmb.Tag = "3"
        '
        'Kar_Kartype2_cmb
        '
        Me.Kar_Kartype2_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Kar_Kartype2_cmb.FormattingEnabled = True
        Me.Kar_Kartype2_cmb.Items.AddRange(New Object() {"deense lagen", "extra platen en 1 FH Kar", "N.V.T.", "deense lagen (geen CC)", "Euro Trolley", "Pallet", "Euro Pallet"})
        Me.Kar_Kartype2_cmb.Location = New System.Drawing.Point(310, 436)
        Me.Kar_Kartype2_cmb.Name = "Kar_Kartype2_cmb"
        Me.Kar_Kartype2_cmb.Size = New System.Drawing.Size(142, 21)
        Me.Kar_Kartype2_cmb.TabIndex = 114
        Me.Kar_Kartype2_cmb.Tag = "2"
        '
        'Kar_Kartype1_cmb
        '
        Me.Kar_Kartype1_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Kar_Kartype1_cmb.FormattingEnabled = True
        Me.Kar_Kartype1_cmb.Items.AddRange(New Object() {"deense lagen", "extra platen en 1 FH Kar", "N.V.T.", "deense lagen (geen CC)", "Euro Trolley", "Pallet", "Euro Pallet"})
        Me.Kar_Kartype1_cmb.Location = New System.Drawing.Point(76, 438)
        Me.Kar_Kartype1_cmb.Name = "Kar_Kartype1_cmb"
        Me.Kar_Kartype1_cmb.Size = New System.Drawing.Size(142, 21)
        Me.Kar_Kartype1_cmb.TabIndex = 113
        Me.Kar_Kartype1_cmb.Tag = "1"
        '
        'Kar_fdverzonden4_chk
        '
        Me.Kar_fdverzonden4_chk.AutoCheck = False
        Me.Kar_fdverzonden4_chk.AutoSize = True
        Me.Kar_fdverzonden4_chk.Location = New System.Drawing.Point(705, 507)
        Me.Kar_fdverzonden4_chk.Name = "Kar_fdverzonden4_chk"
        Me.Kar_fdverzonden4_chk.Size = New System.Drawing.Size(115, 17)
        Me.Kar_fdverzonden4_chk.TabIndex = 112
        Me.Kar_fdverzonden4_chk.Tag = "1"
        Me.Kar_fdverzonden4_chk.Text = "Floriday verzonden"
        Me.Kar_fdverzonden4_chk.UseVisualStyleBackColor = True
        '
        'Kar_fdverzonden3_chk
        '
        Me.Kar_fdverzonden3_chk.AutoCheck = False
        Me.Kar_fdverzonden3_chk.AutoSize = True
        Me.Kar_fdverzonden3_chk.Location = New System.Drawing.Point(474, 507)
        Me.Kar_fdverzonden3_chk.Name = "Kar_fdverzonden3_chk"
        Me.Kar_fdverzonden3_chk.Size = New System.Drawing.Size(115, 17)
        Me.Kar_fdverzonden3_chk.TabIndex = 111
        Me.Kar_fdverzonden3_chk.Tag = "1"
        Me.Kar_fdverzonden3_chk.Text = "Floriday verzonden"
        Me.Kar_fdverzonden3_chk.UseVisualStyleBackColor = True
        '
        'Kar_fdverzonden2_chk
        '
        Me.Kar_fdverzonden2_chk.AutoCheck = False
        Me.Kar_fdverzonden2_chk.AutoSize = True
        Me.Kar_fdverzonden2_chk.Location = New System.Drawing.Point(245, 507)
        Me.Kar_fdverzonden2_chk.Name = "Kar_fdverzonden2_chk"
        Me.Kar_fdverzonden2_chk.Size = New System.Drawing.Size(115, 17)
        Me.Kar_fdverzonden2_chk.TabIndex = 110
        Me.Kar_fdverzonden2_chk.Tag = "1"
        Me.Kar_fdverzonden2_chk.Text = "Floriday verzonden"
        Me.Kar_fdverzonden2_chk.UseVisualStyleBackColor = True
        '
        'Kar_fdverzonden1_chk
        '
        Me.Kar_fdverzonden1_chk.AutoCheck = False
        Me.Kar_fdverzonden1_chk.AutoSize = True
        Me.Kar_fdverzonden1_chk.Location = New System.Drawing.Point(17, 507)
        Me.Kar_fdverzonden1_chk.Name = "Kar_fdverzonden1_chk"
        Me.Kar_fdverzonden1_chk.Size = New System.Drawing.Size(115, 17)
        Me.Kar_fdverzonden1_chk.TabIndex = 109
        Me.Kar_fdverzonden1_chk.Tag = "1"
        Me.Kar_fdverzonden1_chk.Text = "Floriday verzonden"
        Me.Kar_fdverzonden1_chk.UseVisualStyleBackColor = True
        '
        'KarCommand4_but
        '
        Me.KarCommand4_but.Location = New System.Drawing.Point(877, 463)
        Me.KarCommand4_but.Name = "KarCommand4_but"
        Me.KarCommand4_but.Size = New System.Drawing.Size(40, 21)
        Me.KarCommand4_but.TabIndex = 108
        Me.KarCommand4_but.Tag = "4"
        Me.KarCommand4_but.Text = "OK"
        Me.KarCommand4_but.UseVisualStyleBackColor = True
        '
        'KarCommand4_cmb
        '
        Me.KarCommand4_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.KarCommand4_cmb.FormattingEnabled = True
        Me.KarCommand4_cmb.Items.AddRange(New Object() {"Print pakbon", "Print brief via Floriday", "Print brief via SDF"})
        Me.KarCommand4_cmb.Location = New System.Drawing.Point(705, 463)
        Me.KarCommand4_cmb.Name = "KarCommand4_cmb"
        Me.KarCommand4_cmb.Size = New System.Drawing.Size(168, 21)
        Me.KarCommand4_cmb.TabIndex = 107
        Me.KarCommand4_cmb.Tag = "4"
        '
        'KarCommand3_but
        '
        Me.KarCommand3_but.Location = New System.Drawing.Point(646, 465)
        Me.KarCommand3_but.Name = "KarCommand3_but"
        Me.KarCommand3_but.Size = New System.Drawing.Size(40, 21)
        Me.KarCommand3_but.TabIndex = 106
        Me.KarCommand3_but.Tag = "3"
        Me.KarCommand3_but.Text = "OK"
        Me.KarCommand3_but.UseVisualStyleBackColor = True
        '
        'KarCommand3_cmb
        '
        Me.KarCommand3_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.KarCommand3_cmb.FormattingEnabled = True
        Me.KarCommand3_cmb.Items.AddRange(New Object() {"Print pakbon", "Print brief via Floriday", "Print brief via SDF"})
        Me.KarCommand3_cmb.Location = New System.Drawing.Point(474, 465)
        Me.KarCommand3_cmb.Name = "KarCommand3_cmb"
        Me.KarCommand3_cmb.Size = New System.Drawing.Size(168, 21)
        Me.KarCommand3_cmb.TabIndex = 105
        Me.KarCommand3_cmb.Tag = "3"
        '
        'KarCommand2_but
        '
        Me.KarCommand2_but.Location = New System.Drawing.Point(417, 466)
        Me.KarCommand2_but.Name = "KarCommand2_but"
        Me.KarCommand2_but.Size = New System.Drawing.Size(40, 21)
        Me.KarCommand2_but.TabIndex = 104
        Me.KarCommand2_but.Tag = "2"
        Me.KarCommand2_but.Text = "OK"
        Me.KarCommand2_but.UseVisualStyleBackColor = True
        '
        'KarCommand2_cmb
        '
        Me.KarCommand2_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.KarCommand2_cmb.FormattingEnabled = True
        Me.KarCommand2_cmb.Items.AddRange(New Object() {"Print pakbon", "Print brief via Floriday", "Print brief via SDF"})
        Me.KarCommand2_cmb.Location = New System.Drawing.Point(245, 466)
        Me.KarCommand2_cmb.Name = "KarCommand2_cmb"
        Me.KarCommand2_cmb.Size = New System.Drawing.Size(168, 21)
        Me.KarCommand2_cmb.TabIndex = 103
        Me.KarCommand2_cmb.Tag = "2"
        '
        'KarCommand1_but
        '
        Me.KarCommand1_but.Location = New System.Drawing.Point(183, 465)
        Me.KarCommand1_but.Name = "KarCommand1_but"
        Me.KarCommand1_but.Size = New System.Drawing.Size(40, 21)
        Me.KarCommand1_but.TabIndex = 102
        Me.KarCommand1_but.Tag = "1"
        Me.KarCommand1_but.Text = "OK"
        Me.KarCommand1_but.UseVisualStyleBackColor = True
        '
        'KarCommand1_cmb
        '
        Me.KarCommand1_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.KarCommand1_cmb.FormattingEnabled = True
        Me.KarCommand1_cmb.Items.AddRange(New Object() {"Print pakbon", "Print brief via Floriday", "Print brief via SDF"})
        Me.KarCommand1_cmb.Location = New System.Drawing.Point(11, 465)
        Me.KarCommand1_cmb.Name = "KarCommand1_cmb"
        Me.KarCommand1_cmb.Size = New System.Drawing.Size(168, 21)
        Me.KarCommand1_cmb.TabIndex = 101
        Me.KarCommand1_cmb.Tag = "1"
        '
        'kar_overgooien4_wis_but
        '
        Me.kar_overgooien4_wis_but.Location = New System.Drawing.Point(861, 581)
        Me.kar_overgooien4_wis_but.Name = "kar_overgooien4_wis_but"
        Me.kar_overgooien4_wis_but.Size = New System.Drawing.Size(45, 46)
        Me.kar_overgooien4_wis_but.TabIndex = 100
        Me.kar_overgooien4_wis_but.Tag = "4"
        Me.kar_overgooien4_wis_but.Text = "Wis"
        Me.kar_overgooien4_wis_but.UseVisualStyleBackColor = True
        Me.kar_overgooien4_wis_but.Visible = False
        '
        'kar_overgooien4_hierop_but
        '
        Me.kar_overgooien4_hierop_but.Location = New System.Drawing.Point(705, 605)
        Me.kar_overgooien4_hierop_but.Name = "kar_overgooien4_hierop_but"
        Me.kar_overgooien4_hierop_but.Size = New System.Drawing.Size(150, 23)
        Me.kar_overgooien4_hierop_but.TabIndex = 99
        Me.kar_overgooien4_hierop_but.Tag = "4"
        Me.kar_overgooien4_hierop_but.Text = "Overgooien hierop"
        Me.kar_overgooien4_hierop_but.UseVisualStyleBackColor = True
        Me.kar_overgooien4_hierop_but.Visible = False
        '
        'kar_overgooien4_naar_but
        '
        Me.kar_overgooien4_naar_but.Location = New System.Drawing.Point(705, 581)
        Me.kar_overgooien4_naar_but.Name = "kar_overgooien4_naar_but"
        Me.kar_overgooien4_naar_but.Size = New System.Drawing.Size(150, 23)
        Me.kar_overgooien4_naar_but.TabIndex = 98
        Me.kar_overgooien4_naar_but.Tag = "4"
        Me.kar_overgooien4_naar_but.Text = "Overgooien naar"
        Me.kar_overgooien4_naar_but.UseVisualStyleBackColor = True
        Me.kar_overgooien4_naar_but.Visible = False
        '
        'kar_overgooien3_wis_but
        '
        Me.kar_overgooien3_wis_but.Location = New System.Drawing.Point(630, 581)
        Me.kar_overgooien3_wis_but.Name = "kar_overgooien3_wis_but"
        Me.kar_overgooien3_wis_but.Size = New System.Drawing.Size(45, 47)
        Me.kar_overgooien3_wis_but.TabIndex = 96
        Me.kar_overgooien3_wis_but.Tag = "3"
        Me.kar_overgooien3_wis_but.Text = "Wis"
        Me.kar_overgooien3_wis_but.UseVisualStyleBackColor = True
        Me.kar_overgooien3_wis_but.Visible = False
        '
        'kar_overgooien3_hierop_but
        '
        Me.kar_overgooien3_hierop_but.Location = New System.Drawing.Point(474, 605)
        Me.kar_overgooien3_hierop_but.Name = "kar_overgooien3_hierop_but"
        Me.kar_overgooien3_hierop_but.Size = New System.Drawing.Size(150, 23)
        Me.kar_overgooien3_hierop_but.TabIndex = 95
        Me.kar_overgooien3_hierop_but.Tag = "3"
        Me.kar_overgooien3_hierop_but.Text = "Overgooien hierop"
        Me.kar_overgooien3_hierop_but.UseVisualStyleBackColor = True
        Me.kar_overgooien3_hierop_but.Visible = False
        '
        'kar_overgooien3_naar_but
        '
        Me.kar_overgooien3_naar_but.Location = New System.Drawing.Point(474, 581)
        Me.kar_overgooien3_naar_but.Name = "kar_overgooien3_naar_but"
        Me.kar_overgooien3_naar_but.Size = New System.Drawing.Size(150, 23)
        Me.kar_overgooien3_naar_but.TabIndex = 94
        Me.kar_overgooien3_naar_but.Tag = "3"
        Me.kar_overgooien3_naar_but.Text = "Overgooien naar"
        Me.kar_overgooien3_naar_but.UseVisualStyleBackColor = True
        Me.kar_overgooien3_naar_but.Visible = False
        '
        'kar_overgooien2_wis_but
        '
        Me.kar_overgooien2_wis_but.Location = New System.Drawing.Point(401, 580)
        Me.kar_overgooien2_wis_but.Name = "kar_overgooien2_wis_but"
        Me.kar_overgooien2_wis_but.Size = New System.Drawing.Size(45, 47)
        Me.kar_overgooien2_wis_but.TabIndex = 92
        Me.kar_overgooien2_wis_but.Tag = "2"
        Me.kar_overgooien2_wis_but.Text = "Wis"
        Me.kar_overgooien2_wis_but.UseVisualStyleBackColor = True
        Me.kar_overgooien2_wis_but.Visible = False
        '
        'kar_overgooien2_hierop_but
        '
        Me.kar_overgooien2_hierop_but.Location = New System.Drawing.Point(245, 604)
        Me.kar_overgooien2_hierop_but.Name = "kar_overgooien2_hierop_but"
        Me.kar_overgooien2_hierop_but.Size = New System.Drawing.Size(150, 23)
        Me.kar_overgooien2_hierop_but.TabIndex = 91
        Me.kar_overgooien2_hierop_but.Tag = "2"
        Me.kar_overgooien2_hierop_but.Text = "Overgooien hierop"
        Me.kar_overgooien2_hierop_but.UseVisualStyleBackColor = True
        Me.kar_overgooien2_hierop_but.Visible = False
        '
        'kar_overgooien2_naar_but
        '
        Me.kar_overgooien2_naar_but.Location = New System.Drawing.Point(245, 580)
        Me.kar_overgooien2_naar_but.Name = "kar_overgooien2_naar_but"
        Me.kar_overgooien2_naar_but.Size = New System.Drawing.Size(150, 23)
        Me.kar_overgooien2_naar_but.TabIndex = 90
        Me.kar_overgooien2_naar_but.Tag = "2"
        Me.kar_overgooien2_naar_but.Text = "Overgooien naar"
        Me.kar_overgooien2_naar_but.UseVisualStyleBackColor = True
        Me.kar_overgooien2_naar_but.Visible = False
        '
        'kar_overgooien1_wis_but
        '
        Me.kar_overgooien1_wis_but.Location = New System.Drawing.Point(173, 583)
        Me.kar_overgooien1_wis_but.Name = "kar_overgooien1_wis_but"
        Me.kar_overgooien1_wis_but.Size = New System.Drawing.Size(45, 47)
        Me.kar_overgooien1_wis_but.TabIndex = 88
        Me.kar_overgooien1_wis_but.Tag = "1"
        Me.kar_overgooien1_wis_but.Text = "Wis"
        Me.kar_overgooien1_wis_but.UseVisualStyleBackColor = True
        Me.kar_overgooien1_wis_but.Visible = False
        '
        'kar_overgooien1_hierop_but
        '
        Me.kar_overgooien1_hierop_but.Location = New System.Drawing.Point(17, 607)
        Me.kar_overgooien1_hierop_but.Name = "kar_overgooien1_hierop_but"
        Me.kar_overgooien1_hierop_but.Size = New System.Drawing.Size(150, 23)
        Me.kar_overgooien1_hierop_but.TabIndex = 87
        Me.kar_overgooien1_hierop_but.Tag = "1"
        Me.kar_overgooien1_hierop_but.Text = "Overgooien hierop"
        Me.kar_overgooien1_hierop_but.UseVisualStyleBackColor = True
        Me.kar_overgooien1_hierop_but.Visible = False
        '
        'kar_overgooien1_naar_but
        '
        Me.kar_overgooien1_naar_but.Location = New System.Drawing.Point(17, 583)
        Me.kar_overgooien1_naar_but.Name = "kar_overgooien1_naar_but"
        Me.kar_overgooien1_naar_but.Size = New System.Drawing.Size(150, 23)
        Me.kar_overgooien1_naar_but.TabIndex = 86
        Me.kar_overgooien1_naar_but.Tag = "1"
        Me.kar_overgooien1_naar_but.Text = "Overgooien naar"
        Me.kar_overgooien1_naar_but.UseVisualStyleBackColor = True
        Me.kar_overgooien1_naar_but.Visible = False
        '
        'kar_aanvulling4_but
        '
        Me.kar_aanvulling4_but.Location = New System.Drawing.Point(705, 555)
        Me.kar_aanvulling4_but.Name = "kar_aanvulling4_but"
        Me.kar_aanvulling4_but.Size = New System.Drawing.Size(201, 23)
        Me.kar_aanvulling4_but.TabIndex = 85
        Me.kar_aanvulling4_but.Tag = "4"
        Me.kar_aanvulling4_but.Text = "Aanvullen op deze kar"
        Me.kar_aanvulling4_but.UseVisualStyleBackColor = True
        Me.kar_aanvulling4_but.Visible = False
        '
        'kar_aanvulling3_but
        '
        Me.kar_aanvulling3_but.Location = New System.Drawing.Point(474, 555)
        Me.kar_aanvulling3_but.Name = "kar_aanvulling3_but"
        Me.kar_aanvulling3_but.Size = New System.Drawing.Size(201, 23)
        Me.kar_aanvulling3_but.TabIndex = 84
        Me.kar_aanvulling3_but.Tag = "3"
        Me.kar_aanvulling3_but.Text = "Aanvullen op deze kar"
        Me.kar_aanvulling3_but.UseVisualStyleBackColor = True
        Me.kar_aanvulling3_but.Visible = False
        '
        'kar_aanvulling2_but
        '
        Me.kar_aanvulling2_but.Location = New System.Drawing.Point(245, 555)
        Me.kar_aanvulling2_but.Name = "kar_aanvulling2_but"
        Me.kar_aanvulling2_but.Size = New System.Drawing.Size(201, 23)
        Me.kar_aanvulling2_but.TabIndex = 83
        Me.kar_aanvulling2_but.Tag = "2"
        Me.kar_aanvulling2_but.Text = "Aanvullen op deze kar"
        Me.kar_aanvulling2_but.UseVisualStyleBackColor = True
        Me.kar_aanvulling2_but.Visible = False
        '
        'kar_aanvulling1_but
        '
        Me.kar_aanvulling1_but.Location = New System.Drawing.Point(17, 559)
        Me.kar_aanvulling1_but.Name = "kar_aanvulling1_but"
        Me.kar_aanvulling1_but.Size = New System.Drawing.Size(201, 23)
        Me.kar_aanvulling1_but.TabIndex = 82
        Me.kar_aanvulling1_but.Tag = "1"
        Me.kar_aanvulling1_but.Text = "Aanvullen op deze kar"
        Me.kar_aanvulling1_but.UseVisualStyleBackColor = True
        Me.kar_aanvulling1_but.Visible = False
        '
        'Kar_lagenlock4_but
        '
        Me.Kar_lagenlock4_but.Location = New System.Drawing.Point(707, 437)
        Me.Kar_lagenlock4_but.Name = "Kar_lagenlock4_but"
        Me.Kar_lagenlock4_but.Size = New System.Drawing.Size(24, 19)
        Me.Kar_lagenlock4_but.TabIndex = 73
        Me.Kar_lagenlock4_but.Tag = "4"
        Me.Kar_lagenlock4_but.Text = "L"
        Me.Kar_lagenlock4_but.UseVisualStyleBackColor = True
        '
        'Kar_lagenlock3_but
        '
        Me.Kar_lagenlock3_but.Location = New System.Drawing.Point(474, 437)
        Me.Kar_lagenlock3_but.Name = "Kar_lagenlock3_but"
        Me.Kar_lagenlock3_but.Size = New System.Drawing.Size(24, 19)
        Me.Kar_lagenlock3_but.TabIndex = 72
        Me.Kar_lagenlock3_but.Tag = "3"
        Me.Kar_lagenlock3_but.Text = "L"
        Me.Kar_lagenlock3_but.UseVisualStyleBackColor = True
        '
        'Kar_lagenlock2_but
        '
        Me.Kar_lagenlock2_but.Location = New System.Drawing.Point(245, 437)
        Me.Kar_lagenlock2_but.Name = "Kar_lagenlock2_but"
        Me.Kar_lagenlock2_but.Size = New System.Drawing.Size(24, 19)
        Me.Kar_lagenlock2_but.TabIndex = 71
        Me.Kar_lagenlock2_but.Tag = "2"
        Me.Kar_lagenlock2_but.Text = "L"
        Me.Kar_lagenlock2_but.UseVisualStyleBackColor = True
        '
        'Kar_lagenlock1_but
        '
        Me.Kar_lagenlock1_but.Location = New System.Drawing.Point(11, 438)
        Me.Kar_lagenlock1_but.Name = "Kar_lagenlock1_but"
        Me.Kar_lagenlock1_but.Size = New System.Drawing.Size(24, 19)
        Me.Kar_lagenlock1_but.TabIndex = 70
        Me.Kar_lagenlock1_but.Tag = "1"
        Me.Kar_lagenlock1_but.Text = "L"
        Me.Kar_lagenlock1_but.UseVisualStyleBackColor = True
        '
        'Kar_autosamenvoegen4_chk
        '
        Me.Kar_autosamenvoegen4_chk.AutoSize = True
        Me.Kar_autosamenvoegen4_chk.Checked = True
        Me.Kar_autosamenvoegen4_chk.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Kar_autosamenvoegen4_chk.Location = New System.Drawing.Point(891, 416)
        Me.Kar_autosamenvoegen4_chk.Name = "Kar_autosamenvoegen4_chk"
        Me.Kar_autosamenvoegen4_chk.Size = New System.Drawing.Size(15, 14)
        Me.Kar_autosamenvoegen4_chk.TabIndex = 69
        Me.Kar_autosamenvoegen4_chk.UseVisualStyleBackColor = True
        '
        'Kar_autosamenvoegen3_chk
        '
        Me.Kar_autosamenvoegen3_chk.AutoSize = True
        Me.Kar_autosamenvoegen3_chk.Checked = True
        Me.Kar_autosamenvoegen3_chk.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Kar_autosamenvoegen3_chk.Location = New System.Drawing.Point(660, 416)
        Me.Kar_autosamenvoegen3_chk.Name = "Kar_autosamenvoegen3_chk"
        Me.Kar_autosamenvoegen3_chk.Size = New System.Drawing.Size(15, 14)
        Me.Kar_autosamenvoegen3_chk.TabIndex = 68
        Me.Kar_autosamenvoegen3_chk.UseVisualStyleBackColor = True
        '
        'Kar_autosamenvoegen2_chk
        '
        Me.Kar_autosamenvoegen2_chk.AutoSize = True
        Me.Kar_autosamenvoegen2_chk.Checked = True
        Me.Kar_autosamenvoegen2_chk.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Kar_autosamenvoegen2_chk.Location = New System.Drawing.Point(431, 415)
        Me.Kar_autosamenvoegen2_chk.Name = "Kar_autosamenvoegen2_chk"
        Me.Kar_autosamenvoegen2_chk.Size = New System.Drawing.Size(15, 14)
        Me.Kar_autosamenvoegen2_chk.TabIndex = 67
        Me.Kar_autosamenvoegen2_chk.UseVisualStyleBackColor = True
        '
        'Kar_autosamenvoegen1_chk
        '
        Me.Kar_autosamenvoegen1_chk.AutoSize = True
        Me.Kar_autosamenvoegen1_chk.Checked = True
        Me.Kar_autosamenvoegen1_chk.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Kar_autosamenvoegen1_chk.Location = New System.Drawing.Point(203, 415)
        Me.Kar_autosamenvoegen1_chk.Name = "Kar_autosamenvoegen1_chk"
        Me.Kar_autosamenvoegen1_chk.Size = New System.Drawing.Size(15, 14)
        Me.Kar_autosamenvoegen1_chk.TabIndex = 66
        Me.Kar_autosamenvoegen1_chk.UseVisualStyleBackColor = True
        '
        'Kar_nummer4_lbl
        '
        Me.Kar_nummer4_lbl.AutoSize = True
        Me.Kar_nummer4_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kar_nummer4_lbl.Location = New System.Drawing.Point(785, 10)
        Me.Kar_nummer4_lbl.Name = "Kar_nummer4_lbl"
        Me.Kar_nummer4_lbl.Size = New System.Drawing.Size(15, 16)
        Me.Kar_nummer4_lbl.TabIndex = 57
        Me.Kar_nummer4_lbl.Text = "4"
        '
        'Kar_nummer3_lbl
        '
        Me.Kar_nummer3_lbl.AutoSize = True
        Me.Kar_nummer3_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kar_nummer3_lbl.Location = New System.Drawing.Point(565, 10)
        Me.Kar_nummer3_lbl.Name = "Kar_nummer3_lbl"
        Me.Kar_nummer3_lbl.Size = New System.Drawing.Size(15, 16)
        Me.Kar_nummer3_lbl.TabIndex = 56
        Me.Kar_nummer3_lbl.Text = "3"
        '
        'Kar_nummer2_lbl
        '
        Me.Kar_nummer2_lbl.AutoSize = True
        Me.Kar_nummer2_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kar_nummer2_lbl.Location = New System.Drawing.Point(336, 10)
        Me.Kar_nummer2_lbl.Name = "Kar_nummer2_lbl"
        Me.Kar_nummer2_lbl.Size = New System.Drawing.Size(15, 16)
        Me.Kar_nummer2_lbl.TabIndex = 55
        Me.Kar_nummer2_lbl.Text = "2"
        '
        'Kar_nummer1_lbl
        '
        Me.Kar_nummer1_lbl.AutoSize = True
        Me.Kar_nummer1_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kar_nummer1_lbl.Location = New System.Drawing.Point(110, 10)
        Me.Kar_nummer1_lbl.Name = "Kar_nummer1_lbl"
        Me.Kar_nummer1_lbl.Size = New System.Drawing.Size(15, 16)
        Me.Kar_nummer1_lbl.TabIndex = 54
        Me.Kar_nummer1_lbl.Text = "1"
        '
        'Kar_lagen4_lbl
        '
        Me.Kar_lagen4_lbl.AutoSize = True
        Me.Kar_lagen4_lbl.Location = New System.Drawing.Point(826, 513)
        Me.Kar_lagen4_lbl.Name = "Kar_lagen4_lbl"
        Me.Kar_lagen4_lbl.Size = New System.Drawing.Size(71, 13)
        Me.Kar_lagen4_lbl.TabIndex = 53
        Me.Kar_lagen4_lbl.Text = "deense lagen"
        '
        'Kar_lagen4_txt
        '
        Me.Kar_lagen4_txt.Location = New System.Drawing.Point(737, 437)
        Me.Kar_lagen4_txt.Name = "Kar_lagen4_txt"
        Me.Kar_lagen4_txt.Size = New System.Drawing.Size(29, 20)
        Me.Kar_lagen4_txt.TabIndex = 52
        Me.Kar_lagen4_txt.Text = "6"
        '
        'Kar_vervoer4_chk
        '
        Me.Kar_vervoer4_chk.AutoSize = True
        Me.Kar_vervoer4_chk.Location = New System.Drawing.Point(811, 489)
        Me.Kar_vervoer4_chk.Name = "Kar_vervoer4_chk"
        Me.Kar_vervoer4_chk.Size = New System.Drawing.Size(63, 17)
        Me.Kar_vervoer4_chk.TabIndex = 51
        Me.Kar_vervoer4_chk.Tag = "4"
        Me.Kar_vervoer4_chk.Text = "Vervoer"
        Me.Kar_vervoer4_chk.UseVisualStyleBackColor = True
        '
        'Kar_sdfverzonden4_chk
        '
        Me.Kar_sdfverzonden4_chk.AutoSize = True
        Me.Kar_sdfverzonden4_chk.Location = New System.Drawing.Point(705, 489)
        Me.Kar_sdfverzonden4_chk.Name = "Kar_sdfverzonden4_chk"
        Me.Kar_sdfverzonden4_chk.Size = New System.Drawing.Size(95, 17)
        Me.Kar_sdfverzonden4_chk.TabIndex = 50
        Me.Kar_sdfverzonden4_chk.Tag = "4"
        Me.Kar_sdfverzonden4_chk.Text = "Sdf verzonden"
        Me.Kar_sdfverzonden4_chk.UseVisualStyleBackColor = True
        '
        'Kar_flexgrid4
        '
        Me.Kar_flexgrid4.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.Kar_flexgrid4.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.Kar_flexgrid4.ColumnInfo = resources.GetString("Kar_flexgrid4.ColumnInfo")
        Me.Kar_flexgrid4.Location = New System.Drawing.Point(705, 74)
        Me.Kar_flexgrid4.Name = "Kar_flexgrid4"
        Me.Kar_flexgrid4.Rows.Count = 1
        Me.Kar_flexgrid4.Rows.DefaultSize = 17
        Me.Kar_flexgrid4.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.ListBox
        Me.Kar_flexgrid4.Size = New System.Drawing.Size(201, 339)
        Me.Kar_flexgrid4.TabIndex = 49
        '
        'Kar_rfid4_lbl
        '
        Me.Kar_rfid4_lbl.AutoSize = True
        Me.Kar_rfid4_lbl.Location = New System.Drawing.Point(704, 658)
        Me.Kar_rfid4_lbl.Name = "Kar_rfid4_lbl"
        Me.Kar_rfid4_lbl.Size = New System.Drawing.Size(26, 13)
        Me.Kar_rfid4_lbl.TabIndex = 48
        Me.Kar_rfid4_lbl.Text = "Rfid"
        '
        'Kar_barcode4_lbl
        '
        Me.Kar_barcode4_lbl.AutoSize = True
        Me.Kar_barcode4_lbl.Location = New System.Drawing.Point(701, 532)
        Me.Kar_barcode4_lbl.Name = "Kar_barcode4_lbl"
        Me.Kar_barcode4_lbl.Size = New System.Drawing.Size(59, 13)
        Me.Kar_barcode4_lbl.TabIndex = 47
        Me.Kar_barcode4_lbl.Text = "Pakbon nr."
        '
        'Kar_rfid4_txt
        '
        Me.Kar_rfid4_txt.Location = New System.Drawing.Point(748, 655)
        Me.Kar_rfid4_txt.Name = "Kar_rfid4_txt"
        Me.Kar_rfid4_txt.Size = New System.Drawing.Size(157, 20)
        Me.Kar_rfid4_txt.TabIndex = 46
        '
        'Kar_barcode4_txt
        '
        Me.Kar_barcode4_txt.Location = New System.Drawing.Point(764, 529)
        Me.Kar_barcode4_txt.Name = "Kar_barcode4_txt"
        Me.Kar_barcode4_txt.Size = New System.Drawing.Size(141, 20)
        Me.Kar_barcode4_txt.TabIndex = 45
        '
        'Kar_aantaltotaal4_lbl
        '
        Me.Kar_aantaltotaal4_lbl.AutoSize = True
        Me.Kar_aantaltotaal4_lbl.Location = New System.Drawing.Point(715, 417)
        Me.Kar_aantaltotaal4_lbl.Name = "Kar_aantaltotaal4_lbl"
        Me.Kar_aantaltotaal4_lbl.Size = New System.Drawing.Size(69, 13)
        Me.Kar_aantaltotaal4_lbl.TabIndex = 44
        Me.Kar_aantaltotaal4_lbl.Text = "10 x 8 Totaal"
        '
        'Kar_down4_but
        '
        Me.Kar_down4_but.Location = New System.Drawing.Point(859, 36)
        Me.Kar_down4_but.Name = "Kar_down4_but"
        Me.Kar_down4_but.Size = New System.Drawing.Size(33, 32)
        Me.Kar_down4_but.TabIndex = 43
        Me.Kar_down4_but.Text = "v"
        Me.Kar_down4_but.UseVisualStyleBackColor = True
        '
        'Kar_up4_but
        '
        Me.Kar_up4_but.Location = New System.Drawing.Point(716, 36)
        Me.Kar_up4_but.Name = "Kar_up4_but"
        Me.Kar_up4_but.Size = New System.Drawing.Size(33, 32)
        Me.Kar_up4_but.TabIndex = 42
        Me.Kar_up4_but.Text = "^"
        Me.Kar_up4_but.UseVisualStyleBackColor = True
        '
        'Kar_plus4_but
        '
        Me.Kar_plus4_but.Location = New System.Drawing.Point(764, 36)
        Me.Kar_plus4_but.Name = "Kar_plus4_but"
        Me.Kar_plus4_but.Size = New System.Drawing.Size(79, 32)
        Me.Kar_plus4_but.TabIndex = 41
        Me.Kar_plus4_but.Tag = "4"
        Me.Kar_plus4_but.Text = "+"
        Me.Kar_plus4_but.UseVisualStyleBackColor = True
        '
        'Kar_lagen3_lbl
        '
        Me.Kar_lagen3_lbl.AutoSize = True
        Me.Kar_lagen3_lbl.Location = New System.Drawing.Point(615, 507)
        Me.Kar_lagen3_lbl.Name = "Kar_lagen3_lbl"
        Me.Kar_lagen3_lbl.Size = New System.Drawing.Size(71, 13)
        Me.Kar_lagen3_lbl.TabIndex = 40
        Me.Kar_lagen3_lbl.Text = "deense lagen"
        '
        'Kar_lagen3_txt
        '
        Me.Kar_lagen3_txt.Location = New System.Drawing.Point(504, 436)
        Me.Kar_lagen3_txt.Name = "Kar_lagen3_txt"
        Me.Kar_lagen3_txt.Size = New System.Drawing.Size(29, 20)
        Me.Kar_lagen3_txt.TabIndex = 39
        Me.Kar_lagen3_txt.Text = "6"
        '
        'Kar_vervoer3_chk
        '
        Me.Kar_vervoer3_chk.AutoSize = True
        Me.Kar_vervoer3_chk.Location = New System.Drawing.Point(579, 489)
        Me.Kar_vervoer3_chk.Name = "Kar_vervoer3_chk"
        Me.Kar_vervoer3_chk.Size = New System.Drawing.Size(63, 17)
        Me.Kar_vervoer3_chk.TabIndex = 38
        Me.Kar_vervoer3_chk.Tag = "3"
        Me.Kar_vervoer3_chk.Text = "Vervoer"
        Me.Kar_vervoer3_chk.UseVisualStyleBackColor = True
        '
        'Kar_sdfverzonden3_chk
        '
        Me.Kar_sdfverzonden3_chk.AutoSize = True
        Me.Kar_sdfverzonden3_chk.Location = New System.Drawing.Point(474, 489)
        Me.Kar_sdfverzonden3_chk.Name = "Kar_sdfverzonden3_chk"
        Me.Kar_sdfverzonden3_chk.Size = New System.Drawing.Size(95, 17)
        Me.Kar_sdfverzonden3_chk.TabIndex = 37
        Me.Kar_sdfverzonden3_chk.Tag = "3"
        Me.Kar_sdfverzonden3_chk.Text = "Sdf verzonden"
        Me.Kar_sdfverzonden3_chk.UseVisualStyleBackColor = True
        '
        'Kar_flexgrid3
        '
        Me.Kar_flexgrid3.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.Kar_flexgrid3.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.Kar_flexgrid3.ColumnInfo = resources.GetString("Kar_flexgrid3.ColumnInfo")
        Me.Kar_flexgrid3.Location = New System.Drawing.Point(474, 74)
        Me.Kar_flexgrid3.Name = "Kar_flexgrid3"
        Me.Kar_flexgrid3.Rows.Count = 1
        Me.Kar_flexgrid3.Rows.DefaultSize = 17
        Me.Kar_flexgrid3.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.ListBox
        Me.Kar_flexgrid3.Size = New System.Drawing.Size(201, 339)
        Me.Kar_flexgrid3.TabIndex = 36
        '
        'Kar_rfid3_lbl
        '
        Me.Kar_rfid3_lbl.AutoSize = True
        Me.Kar_rfid3_lbl.Location = New System.Drawing.Point(471, 658)
        Me.Kar_rfid3_lbl.Name = "Kar_rfid3_lbl"
        Me.Kar_rfid3_lbl.Size = New System.Drawing.Size(26, 13)
        Me.Kar_rfid3_lbl.TabIndex = 35
        Me.Kar_rfid3_lbl.Text = "Rfid"
        '
        'Kar_barcode3_lbl
        '
        Me.Kar_barcode3_lbl.AutoSize = True
        Me.Kar_barcode3_lbl.Location = New System.Drawing.Point(471, 532)
        Me.Kar_barcode3_lbl.Name = "Kar_barcode3_lbl"
        Me.Kar_barcode3_lbl.Size = New System.Drawing.Size(59, 13)
        Me.Kar_barcode3_lbl.TabIndex = 34
        Me.Kar_barcode3_lbl.Text = "Pakbon nr."
        '
        'Kar_rfid3_txt
        '
        Me.Kar_rfid3_txt.Location = New System.Drawing.Point(518, 655)
        Me.Kar_rfid3_txt.Name = "Kar_rfid3_txt"
        Me.Kar_rfid3_txt.Size = New System.Drawing.Size(157, 20)
        Me.Kar_rfid3_txt.TabIndex = 33
        '
        'Kar_barcode3_txt
        '
        Me.Kar_barcode3_txt.Location = New System.Drawing.Point(533, 529)
        Me.Kar_barcode3_txt.Name = "Kar_barcode3_txt"
        Me.Kar_barcode3_txt.Size = New System.Drawing.Size(142, 20)
        Me.Kar_barcode3_txt.TabIndex = 32
        '
        'Kar_aantaltotaal3_lbl
        '
        Me.Kar_aantaltotaal3_lbl.AutoSize = True
        Me.Kar_aantaltotaal3_lbl.Location = New System.Drawing.Point(482, 416)
        Me.Kar_aantaltotaal3_lbl.Name = "Kar_aantaltotaal3_lbl"
        Me.Kar_aantaltotaal3_lbl.Size = New System.Drawing.Size(69, 13)
        Me.Kar_aantaltotaal3_lbl.TabIndex = 31
        Me.Kar_aantaltotaal3_lbl.Text = "10 x 8 Totaal"
        '
        'Kar_down3_but
        '
        Me.Kar_down3_but.Location = New System.Drawing.Point(628, 36)
        Me.Kar_down3_but.Name = "Kar_down3_but"
        Me.Kar_down3_but.Size = New System.Drawing.Size(33, 32)
        Me.Kar_down3_but.TabIndex = 30
        Me.Kar_down3_but.Text = "v"
        Me.Kar_down3_but.UseVisualStyleBackColor = True
        '
        'Kar_up3_but
        '
        Me.Kar_up3_but.Location = New System.Drawing.Point(485, 36)
        Me.Kar_up3_but.Name = "Kar_up3_but"
        Me.Kar_up3_but.Size = New System.Drawing.Size(33, 32)
        Me.Kar_up3_but.TabIndex = 29
        Me.Kar_up3_but.Text = "^"
        Me.Kar_up3_but.UseVisualStyleBackColor = True
        '
        'Kar_plus3_but
        '
        Me.Kar_plus3_but.Location = New System.Drawing.Point(533, 36)
        Me.Kar_plus3_but.Name = "Kar_plus3_but"
        Me.Kar_plus3_but.Size = New System.Drawing.Size(79, 32)
        Me.Kar_plus3_but.TabIndex = 28
        Me.Kar_plus3_but.Tag = "3"
        Me.Kar_plus3_but.Text = "+"
        Me.Kar_plus3_but.UseVisualStyleBackColor = True
        '
        'Kar_lagen2_lbl
        '
        Me.Kar_lagen2_lbl.AutoSize = True
        Me.Kar_lagen2_lbl.Location = New System.Drawing.Point(375, 509)
        Me.Kar_lagen2_lbl.Name = "Kar_lagen2_lbl"
        Me.Kar_lagen2_lbl.Size = New System.Drawing.Size(71, 13)
        Me.Kar_lagen2_lbl.TabIndex = 27
        Me.Kar_lagen2_lbl.Text = "deense lagen"
        '
        'Kar_lagen2_txt
        '
        Me.Kar_lagen2_txt.Location = New System.Drawing.Point(276, 437)
        Me.Kar_lagen2_txt.Name = "Kar_lagen2_txt"
        Me.Kar_lagen2_txt.Size = New System.Drawing.Size(29, 20)
        Me.Kar_lagen2_txt.TabIndex = 26
        Me.Kar_lagen2_txt.Text = "6"
        '
        'Kar_vervoer2_chk
        '
        Me.Kar_vervoer2_chk.AutoSize = True
        Me.Kar_vervoer2_chk.Location = New System.Drawing.Point(351, 489)
        Me.Kar_vervoer2_chk.Name = "Kar_vervoer2_chk"
        Me.Kar_vervoer2_chk.Size = New System.Drawing.Size(63, 17)
        Me.Kar_vervoer2_chk.TabIndex = 25
        Me.Kar_vervoer2_chk.Tag = "2"
        Me.Kar_vervoer2_chk.Text = "Vervoer"
        Me.Kar_vervoer2_chk.UseVisualStyleBackColor = True
        '
        'Kar_sdfverzonden2_chk
        '
        Me.Kar_sdfverzonden2_chk.AutoSize = True
        Me.Kar_sdfverzonden2_chk.Location = New System.Drawing.Point(245, 489)
        Me.Kar_sdfverzonden2_chk.Name = "Kar_sdfverzonden2_chk"
        Me.Kar_sdfverzonden2_chk.Size = New System.Drawing.Size(95, 17)
        Me.Kar_sdfverzonden2_chk.TabIndex = 24
        Me.Kar_sdfverzonden2_chk.Tag = "2"
        Me.Kar_sdfverzonden2_chk.Text = "Sdf verzonden"
        Me.Kar_sdfverzonden2_chk.UseVisualStyleBackColor = True
        '
        'Kar_flexgrid2
        '
        Me.Kar_flexgrid2.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.Kar_flexgrid2.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.Kar_flexgrid2.ColumnInfo = resources.GetString("Kar_flexgrid2.ColumnInfo")
        Me.Kar_flexgrid2.Location = New System.Drawing.Point(245, 74)
        Me.Kar_flexgrid2.Name = "Kar_flexgrid2"
        Me.Kar_flexgrid2.Rows.Count = 1
        Me.Kar_flexgrid2.Rows.DefaultSize = 17
        Me.Kar_flexgrid2.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.ListBox
        Me.Kar_flexgrid2.Size = New System.Drawing.Size(201, 339)
        Me.Kar_flexgrid2.TabIndex = 23
        '
        'Kar_rfid2_lbl
        '
        Me.Kar_rfid2_lbl.AutoSize = True
        Me.Kar_rfid2_lbl.Location = New System.Drawing.Point(242, 658)
        Me.Kar_rfid2_lbl.Name = "Kar_rfid2_lbl"
        Me.Kar_rfid2_lbl.Size = New System.Drawing.Size(26, 13)
        Me.Kar_rfid2_lbl.TabIndex = 22
        Me.Kar_rfid2_lbl.Text = "Rfid"
        '
        'Kar_barcode2_lbl
        '
        Me.Kar_barcode2_lbl.AutoSize = True
        Me.Kar_barcode2_lbl.Location = New System.Drawing.Point(242, 532)
        Me.Kar_barcode2_lbl.Name = "Kar_barcode2_lbl"
        Me.Kar_barcode2_lbl.Size = New System.Drawing.Size(59, 13)
        Me.Kar_barcode2_lbl.TabIndex = 21
        Me.Kar_barcode2_lbl.Text = "Pakbon nr."
        '
        'Kar_rfid2_txt
        '
        Me.Kar_rfid2_txt.Location = New System.Drawing.Point(289, 655)
        Me.Kar_rfid2_txt.Name = "Kar_rfid2_txt"
        Me.Kar_rfid2_txt.Size = New System.Drawing.Size(157, 20)
        Me.Kar_rfid2_txt.TabIndex = 20
        '
        'Kar_barcode2_txt
        '
        Me.Kar_barcode2_txt.Location = New System.Drawing.Point(304, 529)
        Me.Kar_barcode2_txt.Name = "Kar_barcode2_txt"
        Me.Kar_barcode2_txt.Size = New System.Drawing.Size(142, 20)
        Me.Kar_barcode2_txt.TabIndex = 19
        '
        'Kar_aantaltotaal2_lbl
        '
        Me.Kar_aantaltotaal2_lbl.AutoSize = True
        Me.Kar_aantaltotaal2_lbl.Location = New System.Drawing.Point(253, 416)
        Me.Kar_aantaltotaal2_lbl.Name = "Kar_aantaltotaal2_lbl"
        Me.Kar_aantaltotaal2_lbl.Size = New System.Drawing.Size(69, 13)
        Me.Kar_aantaltotaal2_lbl.TabIndex = 18
        Me.Kar_aantaltotaal2_lbl.Text = "10 x 8 Totaal"
        '
        'Kar_down2_but
        '
        Me.Kar_down2_but.Location = New System.Drawing.Point(399, 36)
        Me.Kar_down2_but.Name = "Kar_down2_but"
        Me.Kar_down2_but.Size = New System.Drawing.Size(33, 32)
        Me.Kar_down2_but.TabIndex = 17
        Me.Kar_down2_but.Text = "v"
        Me.Kar_down2_but.UseVisualStyleBackColor = True
        '
        'Kar_up2_but
        '
        Me.Kar_up2_but.Location = New System.Drawing.Point(256, 36)
        Me.Kar_up2_but.Name = "Kar_up2_but"
        Me.Kar_up2_but.Size = New System.Drawing.Size(33, 32)
        Me.Kar_up2_but.TabIndex = 16
        Me.Kar_up2_but.Text = "^"
        Me.Kar_up2_but.UseVisualStyleBackColor = True
        '
        'Kar_plus2_but
        '
        Me.Kar_plus2_but.Location = New System.Drawing.Point(304, 36)
        Me.Kar_plus2_but.Name = "Kar_plus2_but"
        Me.Kar_plus2_but.Size = New System.Drawing.Size(79, 32)
        Me.Kar_plus2_but.TabIndex = 15
        Me.Kar_plus2_but.Tag = "2"
        Me.Kar_plus2_but.Text = "+"
        Me.Kar_plus2_but.UseVisualStyleBackColor = True
        '
        'Kar_lagen1_lbl
        '
        Me.Kar_lagen1_lbl.AutoSize = True
        Me.Kar_lagen1_lbl.Location = New System.Drawing.Point(138, 511)
        Me.Kar_lagen1_lbl.Name = "Kar_lagen1_lbl"
        Me.Kar_lagen1_lbl.Size = New System.Drawing.Size(71, 13)
        Me.Kar_lagen1_lbl.TabIndex = 14
        Me.Kar_lagen1_lbl.Text = "deense lagen"
        '
        'Kar_lagen1_txt
        '
        Me.Kar_lagen1_txt.Location = New System.Drawing.Point(41, 438)
        Me.Kar_lagen1_txt.Name = "Kar_lagen1_txt"
        Me.Kar_lagen1_txt.Size = New System.Drawing.Size(29, 20)
        Me.Kar_lagen1_txt.TabIndex = 13
        Me.Kar_lagen1_txt.Text = "6"
        '
        'Kar_vervoer1_chk
        '
        Me.Kar_vervoer1_chk.AutoSize = True
        Me.Kar_vervoer1_chk.Location = New System.Drawing.Point(122, 489)
        Me.Kar_vervoer1_chk.Name = "Kar_vervoer1_chk"
        Me.Kar_vervoer1_chk.Size = New System.Drawing.Size(63, 17)
        Me.Kar_vervoer1_chk.TabIndex = 12
        Me.Kar_vervoer1_chk.Tag = "1"
        Me.Kar_vervoer1_chk.Text = "Vervoer"
        Me.Kar_vervoer1_chk.UseVisualStyleBackColor = True
        '
        'Kar_sdfverzonden1_chk
        '
        Me.Kar_sdfverzonden1_chk.AutoSize = True
        Me.Kar_sdfverzonden1_chk.Location = New System.Drawing.Point(17, 489)
        Me.Kar_sdfverzonden1_chk.Name = "Kar_sdfverzonden1_chk"
        Me.Kar_sdfverzonden1_chk.Size = New System.Drawing.Size(95, 17)
        Me.Kar_sdfverzonden1_chk.TabIndex = 11
        Me.Kar_sdfverzonden1_chk.Tag = "1"
        Me.Kar_sdfverzonden1_chk.Text = "Sdf verzonden"
        Me.Kar_sdfverzonden1_chk.UseVisualStyleBackColor = True
        '
        'Kar_flexgrid1
        '
        Me.Kar_flexgrid1.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.Kar_flexgrid1.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.Kar_flexgrid1.ColumnInfo = resources.GetString("Kar_flexgrid1.ColumnInfo")
        Me.Kar_flexgrid1.Location = New System.Drawing.Point(17, 74)
        Me.Kar_flexgrid1.Name = "Kar_flexgrid1"
        Me.Kar_flexgrid1.Rows.Count = 1
        Me.Kar_flexgrid1.Rows.DefaultSize = 17
        Me.Kar_flexgrid1.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.ListBox
        Me.Kar_flexgrid1.Size = New System.Drawing.Size(201, 339)
        Me.Kar_flexgrid1.TabIndex = 10
        '
        'Kar_rfid1_lbl
        '
        Me.Kar_rfid1_lbl.AutoSize = True
        Me.Kar_rfid1_lbl.Location = New System.Drawing.Point(14, 658)
        Me.Kar_rfid1_lbl.Name = "Kar_rfid1_lbl"
        Me.Kar_rfid1_lbl.Size = New System.Drawing.Size(26, 13)
        Me.Kar_rfid1_lbl.TabIndex = 9
        Me.Kar_rfid1_lbl.Text = "Rfid"
        '
        'Kar_barcode1_lbl
        '
        Me.Kar_barcode1_lbl.AutoSize = True
        Me.Kar_barcode1_lbl.Location = New System.Drawing.Point(14, 536)
        Me.Kar_barcode1_lbl.Name = "Kar_barcode1_lbl"
        Me.Kar_barcode1_lbl.Size = New System.Drawing.Size(59, 13)
        Me.Kar_barcode1_lbl.TabIndex = 8
        Me.Kar_barcode1_lbl.Text = "Pakbon nr."
        '
        'Kar_rfid1_txt
        '
        Me.Kar_rfid1_txt.Location = New System.Drawing.Point(61, 655)
        Me.Kar_rfid1_txt.Name = "Kar_rfid1_txt"
        Me.Kar_rfid1_txt.Size = New System.Drawing.Size(157, 20)
        Me.Kar_rfid1_txt.TabIndex = 7
        '
        'Kar_barcode1_txt
        '
        Me.Kar_barcode1_txt.Location = New System.Drawing.Point(76, 533)
        Me.Kar_barcode1_txt.Name = "Kar_barcode1_txt"
        Me.Kar_barcode1_txt.Size = New System.Drawing.Size(142, 20)
        Me.Kar_barcode1_txt.TabIndex = 6
        '
        'Kar_aantaltotaal1_lbl
        '
        Me.Kar_aantaltotaal1_lbl.AutoSize = True
        Me.Kar_aantaltotaal1_lbl.Location = New System.Drawing.Point(25, 416)
        Me.Kar_aantaltotaal1_lbl.Name = "Kar_aantaltotaal1_lbl"
        Me.Kar_aantaltotaal1_lbl.Size = New System.Drawing.Size(69, 13)
        Me.Kar_aantaltotaal1_lbl.TabIndex = 5
        Me.Kar_aantaltotaal1_lbl.Text = "10 x 8 Totaal"
        '
        'Kar_down1_but
        '
        Me.Kar_down1_but.Location = New System.Drawing.Point(171, 36)
        Me.Kar_down1_but.Name = "Kar_down1_but"
        Me.Kar_down1_but.Size = New System.Drawing.Size(33, 32)
        Me.Kar_down1_but.TabIndex = 4
        Me.Kar_down1_but.Text = "v"
        Me.Kar_down1_but.UseVisualStyleBackColor = True
        '
        'Kar_up1_but
        '
        Me.Kar_up1_but.Location = New System.Drawing.Point(28, 36)
        Me.Kar_up1_but.Name = "Kar_up1_but"
        Me.Kar_up1_but.Size = New System.Drawing.Size(33, 32)
        Me.Kar_up1_but.TabIndex = 3
        Me.Kar_up1_but.Text = "^"
        Me.Kar_up1_but.UseVisualStyleBackColor = True
        '
        'Kar_plus1_but
        '
        Me.Kar_plus1_but.Location = New System.Drawing.Point(76, 36)
        Me.Kar_plus1_but.Name = "Kar_plus1_but"
        Me.Kar_plus1_but.Size = New System.Drawing.Size(79, 32)
        Me.Kar_plus1_but.TabIndex = 2
        Me.Kar_plus1_but.Tag = "1"
        Me.Kar_plus1_but.Text = "+"
        Me.Kar_plus1_but.UseVisualStyleBackColor = True
        '
        'PanelKarIndelingBoven
        '
        Me.PanelKarIndelingBoven.Controls.Add(Me.KarBut40)
        Me.PanelKarIndelingBoven.Controls.Add(Me.KarBut35)
        Me.PanelKarIndelingBoven.Controls.Add(Me.kar_wissel_vestiging_but)
        Me.PanelKarIndelingBoven.Controls.Add(Me.Kar_vestiging_lbl)
        Me.PanelKarIndelingBoven.Controls.Add(Me.KarOrder_versie_lbl)
        Me.PanelKarIndelingBoven.Controls.Add(Me.Kar_karvoorkeur_lbl)
        Me.PanelKarIndelingBoven.Controls.Add(Me.Kar_selectietot_lbl)
        Me.PanelKarIndelingBoven.Controls.Add(Me.Kar_selectie_txt)
        Me.PanelKarIndelingBoven.Controls.Add(Me.KarBut20)
        Me.PanelKarIndelingBoven.Controls.Add(Me.KarBut16)
        Me.PanelKarIndelingBoven.Controls.Add(Me.KarBut12)
        Me.PanelKarIndelingBoven.Controls.Add(Me.KarBut10)
        Me.PanelKarIndelingBoven.Controls.Add(Me.KarBut9)
        Me.PanelKarIndelingBoven.Controls.Add(Me.KarBut8)
        Me.PanelKarIndelingBoven.Controls.Add(Me.KarBut7)
        Me.PanelKarIndelingBoven.Controls.Add(Me.KarBut6)
        Me.PanelKarIndelingBoven.Controls.Add(Me.KarBut5)
        Me.PanelKarIndelingBoven.Controls.Add(Me.KarBut4)
        Me.PanelKarIndelingBoven.Controls.Add(Me.KarBut3)
        Me.PanelKarIndelingBoven.Controls.Add(Me.KarBut2)
        Me.PanelKarIndelingBoven.Controls.Add(Me.KarBut1)
        Me.PanelKarIndelingBoven.Controls.Add(Me.KarBut100)
        Me.PanelKarIndelingBoven.Controls.Add(Me.Kar_kopernaam_lbl)
        Me.PanelKarIndelingBoven.Location = New System.Drawing.Point(4, 4)
        Me.PanelKarIndelingBoven.Name = "PanelKarIndelingBoven"
        Me.PanelKarIndelingBoven.Size = New System.Drawing.Size(875, 100)
        Me.PanelKarIndelingBoven.TabIndex = 0
        '
        'KarBut40
        '
        Me.KarBut40.Location = New System.Drawing.Point(673, 61)
        Me.KarBut40.Name = "KarBut40"
        Me.KarBut40.Size = New System.Drawing.Size(38, 36)
        Me.KarBut40.TabIndex = 85
        Me.KarBut40.Tag = "40"
        Me.KarBut40.Text = "40"
        Me.KarBut40.UseVisualStyleBackColor = True
        '
        'KarBut35
        '
        Me.KarBut35.Location = New System.Drawing.Point(629, 61)
        Me.KarBut35.Name = "KarBut35"
        Me.KarBut35.Size = New System.Drawing.Size(38, 36)
        Me.KarBut35.TabIndex = 84
        Me.KarBut35.Tag = "35"
        Me.KarBut35.Text = "35"
        Me.KarBut35.UseVisualStyleBackColor = True
        '
        'kar_wissel_vestiging_but
        '
        Me.kar_wissel_vestiging_but.Location = New System.Drawing.Point(17, 36)
        Me.kar_wissel_vestiging_but.Name = "kar_wissel_vestiging_but"
        Me.kar_wissel_vestiging_but.Size = New System.Drawing.Size(170, 23)
        Me.kar_wissel_vestiging_but.TabIndex = 83
        Me.kar_wissel_vestiging_but.Tag = "1"
        Me.kar_wissel_vestiging_but.Text = "Wissel vestiging"
        Me.kar_wissel_vestiging_but.UseVisualStyleBackColor = True
        Me.kar_wissel_vestiging_but.Visible = False
        '
        'Kar_vestiging_lbl
        '
        Me.Kar_vestiging_lbl.AutoSize = True
        Me.Kar_vestiging_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kar_vestiging_lbl.Location = New System.Drawing.Point(14, 7)
        Me.Kar_vestiging_lbl.Name = "Kar_vestiging_lbl"
        Me.Kar_vestiging_lbl.Size = New System.Drawing.Size(127, 26)
        Me.Kar_vestiging_lbl.TabIndex = 24
        Me.Kar_vestiging_lbl.Text = "Karindeling "
        '
        'KarOrder_versie_lbl
        '
        Me.KarOrder_versie_lbl.AutoSize = True
        Me.KarOrder_versie_lbl.Location = New System.Drawing.Point(671, 16)
        Me.KarOrder_versie_lbl.Name = "KarOrder_versie_lbl"
        Me.KarOrder_versie_lbl.Size = New System.Drawing.Size(45, 13)
        Me.KarOrder_versie_lbl.TabIndex = 23
        Me.KarOrder_versie_lbl.Text = "Versienr"
        Me.KarOrder_versie_lbl.Visible = False
        '
        'Kar_karvoorkeur_lbl
        '
        Me.Kar_karvoorkeur_lbl.AutoSize = True
        Me.Kar_karvoorkeur_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kar_karvoorkeur_lbl.Location = New System.Drawing.Point(320, 37)
        Me.Kar_karvoorkeur_lbl.Name = "Kar_karvoorkeur_lbl"
        Me.Kar_karvoorkeur_lbl.Size = New System.Drawing.Size(134, 16)
        Me.Kar_karvoorkeur_lbl.TabIndex = 21
        Me.Kar_karvoorkeur_lbl.Text = "Deen CC + Opzetstuk"
        '
        'Kar_selectietot_lbl
        '
        Me.Kar_selectietot_lbl.AutoSize = True
        Me.Kar_selectietot_lbl.Location = New System.Drawing.Point(671, 40)
        Me.Kar_selectietot_lbl.Name = "Kar_selectietot_lbl"
        Me.Kar_selectietot_lbl.Size = New System.Drawing.Size(91, 13)
        Me.Kar_selectietot_lbl.TabIndex = 20
        Me.Kar_selectietot_lbl.Text = "5 x 8 Napoli Kar 1"
        '
        'Kar_selectie_txt
        '
        Me.Kar_selectie_txt.Location = New System.Drawing.Point(754, 77)
        Me.Kar_selectie_txt.Name = "Kar_selectie_txt"
        Me.Kar_selectie_txt.Size = New System.Drawing.Size(38, 20)
        Me.Kar_selectie_txt.TabIndex = 17
        Me.Kar_selectie_txt.Text = "100"
        '
        'KarBut20
        '
        Me.KarBut20.Location = New System.Drawing.Point(585, 61)
        Me.KarBut20.Name = "KarBut20"
        Me.KarBut20.Size = New System.Drawing.Size(38, 36)
        Me.KarBut20.TabIndex = 16
        Me.KarBut20.Tag = "20"
        Me.KarBut20.Text = "20"
        Me.KarBut20.UseVisualStyleBackColor = True
        '
        'KarBut16
        '
        Me.KarBut16.Location = New System.Drawing.Point(541, 61)
        Me.KarBut16.Name = "KarBut16"
        Me.KarBut16.Size = New System.Drawing.Size(38, 36)
        Me.KarBut16.TabIndex = 15
        Me.KarBut16.Tag = "15"
        Me.KarBut16.Text = "15"
        Me.KarBut16.UseVisualStyleBackColor = True
        '
        'KarBut12
        '
        Me.KarBut12.Location = New System.Drawing.Point(497, 61)
        Me.KarBut12.Name = "KarBut12"
        Me.KarBut12.Size = New System.Drawing.Size(38, 36)
        Me.KarBut12.TabIndex = 13
        Me.KarBut12.Tag = "12"
        Me.KarBut12.Text = "12"
        Me.KarBut12.UseVisualStyleBackColor = True
        '
        'KarBut10
        '
        Me.KarBut10.Location = New System.Drawing.Point(455, 61)
        Me.KarBut10.Name = "KarBut10"
        Me.KarBut10.Size = New System.Drawing.Size(38, 36)
        Me.KarBut10.TabIndex = 12
        Me.KarBut10.Tag = "10"
        Me.KarBut10.Text = "10"
        Me.KarBut10.UseVisualStyleBackColor = True
        '
        'KarBut9
        '
        Me.KarBut9.Location = New System.Drawing.Point(411, 61)
        Me.KarBut9.Name = "KarBut9"
        Me.KarBut9.Size = New System.Drawing.Size(38, 36)
        Me.KarBut9.TabIndex = 11
        Me.KarBut9.Tag = "9"
        Me.KarBut9.Text = "9"
        Me.KarBut9.UseVisualStyleBackColor = True
        '
        'KarBut8
        '
        Me.KarBut8.Location = New System.Drawing.Point(367, 61)
        Me.KarBut8.Name = "KarBut8"
        Me.KarBut8.Size = New System.Drawing.Size(38, 36)
        Me.KarBut8.TabIndex = 10
        Me.KarBut8.Tag = "8"
        Me.KarBut8.Text = "8"
        Me.KarBut8.UseVisualStyleBackColor = True
        '
        'KarBut7
        '
        Me.KarBut7.Location = New System.Drawing.Point(323, 61)
        Me.KarBut7.Name = "KarBut7"
        Me.KarBut7.Size = New System.Drawing.Size(38, 36)
        Me.KarBut7.TabIndex = 9
        Me.KarBut7.Tag = "7"
        Me.KarBut7.Text = "7"
        Me.KarBut7.UseVisualStyleBackColor = True
        '
        'KarBut6
        '
        Me.KarBut6.Location = New System.Drawing.Point(279, 61)
        Me.KarBut6.Name = "KarBut6"
        Me.KarBut6.Size = New System.Drawing.Size(38, 36)
        Me.KarBut6.TabIndex = 8
        Me.KarBut6.Tag = "6"
        Me.KarBut6.Text = "6"
        Me.KarBut6.UseVisualStyleBackColor = True
        '
        'KarBut5
        '
        Me.KarBut5.Location = New System.Drawing.Point(237, 61)
        Me.KarBut5.Name = "KarBut5"
        Me.KarBut5.Size = New System.Drawing.Size(38, 36)
        Me.KarBut5.TabIndex = 7
        Me.KarBut5.Tag = "5"
        Me.KarBut5.Text = "5"
        Me.KarBut5.UseVisualStyleBackColor = True
        '
        'KarBut4
        '
        Me.KarBut4.Location = New System.Drawing.Point(193, 61)
        Me.KarBut4.Name = "KarBut4"
        Me.KarBut4.Size = New System.Drawing.Size(38, 36)
        Me.KarBut4.TabIndex = 6
        Me.KarBut4.Tag = "4"
        Me.KarBut4.Text = "4"
        Me.KarBut4.UseVisualStyleBackColor = True
        '
        'KarBut3
        '
        Me.KarBut3.Location = New System.Drawing.Point(149, 61)
        Me.KarBut3.Name = "KarBut3"
        Me.KarBut3.Size = New System.Drawing.Size(38, 36)
        Me.KarBut3.TabIndex = 5
        Me.KarBut3.Tag = "3"
        Me.KarBut3.Text = "3"
        Me.KarBut3.UseVisualStyleBackColor = True
        '
        'KarBut2
        '
        Me.KarBut2.Location = New System.Drawing.Point(105, 61)
        Me.KarBut2.Name = "KarBut2"
        Me.KarBut2.Size = New System.Drawing.Size(38, 36)
        Me.KarBut2.TabIndex = 4
        Me.KarBut2.Tag = "2"
        Me.KarBut2.Text = "2"
        Me.KarBut2.UseVisualStyleBackColor = True
        '
        'KarBut1
        '
        Me.KarBut1.Location = New System.Drawing.Point(61, 61)
        Me.KarBut1.Name = "KarBut1"
        Me.KarBut1.Size = New System.Drawing.Size(38, 36)
        Me.KarBut1.TabIndex = 3
        Me.KarBut1.Tag = "1"
        Me.KarBut1.Text = "1"
        Me.KarBut1.UseVisualStyleBackColor = True
        '
        'KarBut100
        '
        Me.KarBut100.Location = New System.Drawing.Point(17, 61)
        Me.KarBut100.Name = "KarBut100"
        Me.KarBut100.Size = New System.Drawing.Size(38, 36)
        Me.KarBut100.TabIndex = 2
        Me.KarBut100.Tag = "100"
        Me.KarBut100.Text = "-"
        Me.KarBut100.UseVisualStyleBackColor = True
        '
        'Kar_kopernaam_lbl
        '
        Me.Kar_kopernaam_lbl.AutoSize = True
        Me.Kar_kopernaam_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kar_kopernaam_lbl.Location = New System.Drawing.Point(320, 16)
        Me.Kar_kopernaam_lbl.Name = "Kar_kopernaam_lbl"
        Me.Kar_kopernaam_lbl.Size = New System.Drawing.Size(106, 16)
        Me.Kar_kopernaam_lbl.TabIndex = 1
        Me.Kar_kopernaam_lbl.Text = "Waterdrinker CC"
        '
        'C1TabFloriday
        '
        Me.C1TabFloriday.Controls.Add(Me.C1SizerFloriday)
        Me.C1TabFloriday.Location = New System.Drawing.Point(1, 24)
        Me.C1TabFloriday.Name = "C1TabFloriday"
        Me.C1TabFloriday.Size = New System.Drawing.Size(883, 940)
        Me.C1TabFloriday.TabIndex = 11
        Me.C1TabFloriday.Text = "Floriday"
        '
        'C1SizerFloriday
        '
        Me.C1SizerFloriday.Controls.Add(Me.PanelFloridayorders)
        Me.C1SizerFloriday.Controls.Add(Me.FDLineCombo)
        Me.C1SizerFloriday.Controls.Add(Me.FloridayOrderInfo_flx)
        Me.C1SizerFloriday.Controls.Add(Me.FloridayOrderLines_flx)
        Me.C1SizerFloriday.Controls.Add(Me.FloridayOrders_flx)
        Me.C1SizerFloriday.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1SizerFloriday.GridDefinition = "31.1702127659574:False:False;31.2765957446809:False:False;4.25531914893617:False:" &
    "False;31.1702127659574:False:False;" & Global.Microsoft.VisualBasic.ChrW(9) & "99.0939977349943:False:False;"
        Me.C1SizerFloriday.Location = New System.Drawing.Point(0, 0)
        Me.C1SizerFloriday.Name = "C1SizerFloriday"
        Me.C1SizerFloriday.Size = New System.Drawing.Size(883, 940)
        Me.C1SizerFloriday.TabIndex = 0
        Me.C1SizerFloriday.Text = "C1Sizer2"
        '
        'PanelFloridayorders
        '
        Me.PanelFloridayorders.Controls.Add(Me.Floriday_Filterstoepassen_but)
        Me.PanelFloridayorders.Controls.Add(Me.Floriday_orderlineherstellen_but)
        Me.PanelFloridayorders.Location = New System.Drawing.Point(4, 599)
        Me.PanelFloridayorders.Name = "PanelFloridayorders"
        Me.PanelFloridayorders.Size = New System.Drawing.Size(875, 40)
        Me.PanelFloridayorders.TabIndex = 6
        '
        'Floriday_Filterstoepassen_but
        '
        Me.Floriday_Filterstoepassen_but.Location = New System.Drawing.Point(205, 3)
        Me.Floriday_Filterstoepassen_but.Name = "Floriday_Filterstoepassen_but"
        Me.Floriday_Filterstoepassen_but.Size = New System.Drawing.Size(196, 32)
        Me.Floriday_Filterstoepassen_but.TabIndex = 1
        Me.Floriday_Filterstoepassen_but.Text = "Filters toepassen"
        Me.Floriday_Filterstoepassen_but.UseVisualStyleBackColor = True
        '
        'Floriday_orderlineherstellen_but
        '
        Me.Floriday_orderlineherstellen_but.Location = New System.Drawing.Point(3, 3)
        Me.Floriday_orderlineherstellen_but.Name = "Floriday_orderlineherstellen_but"
        Me.Floriday_orderlineherstellen_but.Size = New System.Drawing.Size(196, 32)
        Me.Floriday_orderlineherstellen_but.TabIndex = 0
        Me.Floriday_orderlineherstellen_but.Text = "Orderline herstellen"
        Me.Floriday_orderlineherstellen_but.UseVisualStyleBackColor = True
        '
        'FDLineCombo
        '
        Me.FDLineCombo.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.FDLineCombo.Caption = ""
        Me.FDLineCombo.CaptionHeight = 17
        Me.FDLineCombo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.FDLineCombo.ColumnCaptionHeight = 17
        Me.FDLineCombo.ColumnFooterHeight = 17
        Me.FDLineCombo.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.FDLineCombo.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.FDLineCombo.EditorBackColor = System.Drawing.SystemColors.Window
        Me.FDLineCombo.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.FDLineCombo.Images.Add(CType(resources.GetObject("FDLineCombo.Images"), System.Drawing.Image))
        Me.FDLineCombo.ItemHeight = 15
        Me.FDLineCombo.Location = New System.Drawing.Point(4, 301)
        Me.FDLineCombo.MatchEntryTimeout = CType(2000, Long)
        Me.FDLineCombo.MaxDropDownItems = CType(5, Short)
        Me.FDLineCombo.MaxLength = 32767
        Me.FDLineCombo.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.FDLineCombo.Name = "FDLineCombo"
        Me.FDLineCombo.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.FDLineCombo.Size = New System.Drawing.Size(875, 21)
        Me.FDLineCombo.TabIndex = 5
        Me.FDLineCombo.Visible = False
        Me.FDLineCombo.PropBag = resources.GetString("FDLineCombo.PropBag")
        '
        'FloridayOrderInfo_flx
        '
        Me.FloridayOrderInfo_flx.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.FloridayOrderInfo_flx.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.FloridayOrderInfo_flx.ColumnInfo = "3,0,0,0,0,-1,Columns:"
        Me.FloridayOrderInfo_flx.Location = New System.Drawing.Point(4, 643)
        Me.FloridayOrderInfo_flx.Name = "FloridayOrderInfo_flx"
        Me.FloridayOrderInfo_flx.Rows.Count = 1
        Me.FloridayOrderInfo_flx.Rows.Fixed = 0
        Me.FloridayOrderInfo_flx.Size = New System.Drawing.Size(875, 293)
        Me.FloridayOrderInfo_flx.TabIndex = 2
        '
        'FloridayOrderLines_flx
        '
        Me.FloridayOrderLines_flx.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.FloridayOrderLines_flx.ColumnInfo = "8,0,0,0,0,-1,Columns:"
        Me.FloridayOrderLines_flx.Location = New System.Drawing.Point(4, 301)
        Me.FloridayOrderLines_flx.Name = "FloridayOrderLines_flx"
        Me.FloridayOrderLines_flx.Rows.Count = 1
        Me.FloridayOrderLines_flx.Size = New System.Drawing.Size(875, 294)
        Me.FloridayOrderLines_flx.TabIndex = 1
        '
        'FloridayOrders_flx
        '
        Me.FloridayOrders_flx.ColumnInfo = "5,0,0,0,0,-1,Columns:0{Width:101;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.FloridayOrders_flx.Location = New System.Drawing.Point(4, 4)
        Me.FloridayOrders_flx.Name = "FloridayOrders_flx"
        Me.FloridayOrders_flx.Rows.Count = 1
        Me.FloridayOrders_flx.Size = New System.Drawing.Size(875, 293)
        Me.FloridayOrders_flx.TabIndex = 0
        '
        'C1TabFlorecom
        '
        Me.C1TabFlorecom.Controls.Add(Me.C1SizerFlorecom)
        Me.C1TabFlorecom.Location = New System.Drawing.Point(1, 24)
        Me.C1TabFlorecom.Name = "C1TabFlorecom"
        Me.C1TabFlorecom.Size = New System.Drawing.Size(883, 940)
        Me.C1TabFlorecom.TabIndex = 2
        Me.C1TabFlorecom.Text = "Florecom"
        '
        'C1SizerFlorecom
        '
        Me.C1SizerFlorecom.Controls.Add(Me.Fc_ContactCombo)
        Me.C1SizerFlorecom.Controls.Add(Me.Fc_LineCombo)
        Me.C1SizerFlorecom.Controls.Add(Me.Fc_Flexgrid_LineData)
        Me.C1SizerFlorecom.Controls.Add(Me.FC_Flexgrid_contactdata)
        Me.C1SizerFlorecom.Controls.Add(Me.FC_Flexgrid_orderlines)
        Me.C1SizerFlorecom.Controls.Add(Me.FC_Flexgrid_orderlijst)
        Me.C1SizerFlorecom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1SizerFlorecom.GridDefinition = "21.2765957446809:False:False;77.4468085106383:False:False;" & Global.Microsoft.VisualBasic.ChrW(9) & "44.2808607021518:False" &
    ":False;54.3601359003397:False:False;"
        Me.C1SizerFlorecom.Location = New System.Drawing.Point(0, 0)
        Me.C1SizerFlorecom.Name = "C1SizerFlorecom"
        Me.C1SizerFlorecom.Size = New System.Drawing.Size(883, 940)
        Me.C1SizerFlorecom.TabIndex = 0
        Me.C1SizerFlorecom.Text = "C1Sizer2"
        '
        'Fc_ContactCombo
        '
        Me.Fc_ContactCombo.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.Fc_ContactCombo.Caption = ""
        Me.Fc_ContactCombo.CaptionHeight = 17
        Me.Fc_ContactCombo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Fc_ContactCombo.ColumnCaptionHeight = 17
        Me.Fc_ContactCombo.ColumnFooterHeight = 17
        Me.Fc_ContactCombo.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.Fc_ContactCombo.EditorBackColor = System.Drawing.SystemColors.Window
        Me.Fc_ContactCombo.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.Fc_ContactCombo.Images.Add(CType(resources.GetObject("Fc_ContactCombo.Images"), System.Drawing.Image))
        Me.Fc_ContactCombo.ItemHeight = 15
        Me.Fc_ContactCombo.Location = New System.Drawing.Point(4, 208)
        Me.Fc_ContactCombo.MatchEntryTimeout = CType(2000, Long)
        Me.Fc_ContactCombo.MaxDropDownItems = CType(5, Short)
        Me.Fc_ContactCombo.MaxLength = 32767
        Me.Fc_ContactCombo.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.Fc_ContactCombo.Name = "Fc_ContactCombo"
        Me.Fc_ContactCombo.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.Fc_ContactCombo.Size = New System.Drawing.Size(391, 21)
        Me.Fc_ContactCombo.TabIndex = 5
        Me.Fc_ContactCombo.Visible = False
        Me.Fc_ContactCombo.PropBag = resources.GetString("Fc_ContactCombo.PropBag")
        '
        'Fc_LineCombo
        '
        Me.Fc_LineCombo.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.Fc_LineCombo.Caption = ""
        Me.Fc_LineCombo.CaptionHeight = 17
        Me.Fc_LineCombo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Fc_LineCombo.ColumnCaptionHeight = 17
        Me.Fc_LineCombo.ColumnFooterHeight = 17
        Me.Fc_LineCombo.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.Fc_LineCombo.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.Fc_LineCombo.EditorBackColor = System.Drawing.SystemColors.Window
        Me.Fc_LineCombo.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.Fc_LineCombo.Images.Add(CType(resources.GetObject("Fc_LineCombo.Images"), System.Drawing.Image))
        Me.Fc_LineCombo.ItemHeight = 15
        Me.Fc_LineCombo.Location = New System.Drawing.Point(399, 208)
        Me.Fc_LineCombo.MatchEntryTimeout = CType(2000, Long)
        Me.Fc_LineCombo.MaxDropDownItems = CType(5, Short)
        Me.Fc_LineCombo.MaxLength = 32767
        Me.Fc_LineCombo.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.Fc_LineCombo.Name = "Fc_LineCombo"
        Me.Fc_LineCombo.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.Fc_LineCombo.Size = New System.Drawing.Size(480, 21)
        Me.Fc_LineCombo.TabIndex = 4
        Me.Fc_LineCombo.Visible = False
        Me.Fc_LineCombo.PropBag = resources.GetString("Fc_LineCombo.PropBag")
        '
        'Fc_Flexgrid_LineData
        '
        Me.Fc_Flexgrid_LineData.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.Fc_Flexgrid_LineData.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.Fc_Flexgrid_LineData.ColumnInfo = resources.GetString("Fc_Flexgrid_LineData.ColumnInfo")
        Me.Fc_Flexgrid_LineData.Location = New System.Drawing.Point(399, 208)
        Me.Fc_Flexgrid_LineData.Name = "Fc_Flexgrid_LineData"
        Me.Fc_Flexgrid_LineData.Rows.DefaultSize = 17
        Me.Fc_Flexgrid_LineData.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.ListBox
        Me.Fc_Flexgrid_LineData.Size = New System.Drawing.Size(480, 728)
        Me.Fc_Flexgrid_LineData.TabIndex = 3
        '
        'FC_Flexgrid_contactdata
        '
        Me.FC_Flexgrid_contactdata.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.FC_Flexgrid_contactdata.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.FC_Flexgrid_contactdata.ColumnInfo = "3,0,0,0,0,85,Columns:0{Caption:""id"";Visible:False;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:120;Caption:""Order ge" &
    "gevens"";}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:300;Style:""TextAlign:LeftCenter;"";}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.FC_Flexgrid_contactdata.Location = New System.Drawing.Point(4, 208)
        Me.FC_Flexgrid_contactdata.Name = "FC_Flexgrid_contactdata"
        Me.FC_Flexgrid_contactdata.Rows.DefaultSize = 17
        Me.FC_Flexgrid_contactdata.Size = New System.Drawing.Size(391, 728)
        Me.FC_Flexgrid_contactdata.TabIndex = 2
        '
        'FC_Flexgrid_orderlines
        '
        Me.FC_Flexgrid_orderlines.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.FC_Flexgrid_orderlines.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.FC_Flexgrid_orderlines.ColumnInfo = resources.GetString("FC_Flexgrid_orderlines.ColumnInfo")
        Me.FC_Flexgrid_orderlines.Location = New System.Drawing.Point(399, 4)
        Me.FC_Flexgrid_orderlines.Name = "FC_Flexgrid_orderlines"
        Me.FC_Flexgrid_orderlines.Rows.DefaultSize = 17
        Me.FC_Flexgrid_orderlines.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.FC_Flexgrid_orderlines.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.ListBox
        Me.FC_Flexgrid_orderlines.Size = New System.Drawing.Size(480, 200)
        Me.FC_Flexgrid_orderlines.TabIndex = 1
        '
        'FC_Flexgrid_orderlijst
        '
        Me.FC_Flexgrid_orderlijst.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.FC_Flexgrid_orderlijst.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.FC_Flexgrid_orderlijst.ColumnInfo = resources.GetString("FC_Flexgrid_orderlijst.ColumnInfo")
        Me.FC_Flexgrid_orderlijst.ContextMenuStrip = Me.FlorecomDel_menuStrip
        Me.FC_Flexgrid_orderlijst.Location = New System.Drawing.Point(4, 4)
        Me.FC_Flexgrid_orderlijst.Name = "FC_Flexgrid_orderlijst"
        Me.FC_Flexgrid_orderlijst.Rows.DefaultSize = 17
        Me.FC_Flexgrid_orderlijst.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.FC_Flexgrid_orderlijst.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.ListBox
        Me.FC_Flexgrid_orderlijst.Size = New System.Drawing.Size(391, 200)
        Me.FC_Flexgrid_orderlijst.TabIndex = 0
        '
        'FlorecomDel_menuStrip
        '
        Me.FlorecomDel_menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteFlorecomMenuStrip})
        Me.FlorecomDel_menuStrip.Name = "Florecom_MenuStrip"
        Me.FlorecomDel_menuStrip.Size = New System.Drawing.Size(159, 26)
        '
        'DeleteFlorecomMenuStrip
        '
        Me.DeleteFlorecomMenuStrip.Name = "DeleteFlorecomMenuStrip"
        Me.DeleteFlorecomMenuStrip.Size = New System.Drawing.Size(158, 22)
        Me.DeleteFlorecomMenuStrip.Text = "Delete florecom"
        '
        'C1TabVervoer
        '
        Me.C1TabVervoer.Controls.Add(Me.SizerVervoer)
        Me.C1TabVervoer.Location = New System.Drawing.Point(1, 24)
        Me.C1TabVervoer.Name = "C1TabVervoer"
        Me.C1TabVervoer.Size = New System.Drawing.Size(883, 940)
        Me.C1TabVervoer.TabIndex = 3
        Me.C1TabVervoer.Text = "Vervoer"
        '
        'SizerVervoer
        '
        Me.SizerVervoer.Controls.Add(Me.Vervoer_Listbox)
        Me.SizerVervoer.Controls.Add(Me.Vervoer_Treeview)
        Me.SizerVervoer.Controls.Add(Me.Vervoer_PanelRechts)
        Me.SizerVervoer.Controls.Add(Me.Vervoer_PanelLinks)
        Me.SizerVervoer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SizerVervoer.GridDefinition = "63.8297872340426:False:False;34.8936170212766:False:False;" & Global.Microsoft.VisualBasic.ChrW(9) & "49.3771234428086:False" &
    ":False;49.2638731596829:False:False;"
        Me.SizerVervoer.Location = New System.Drawing.Point(0, 0)
        Me.SizerVervoer.Name = "SizerVervoer"
        Me.SizerVervoer.Size = New System.Drawing.Size(883, 940)
        Me.SizerVervoer.TabIndex = 0
        Me.SizerVervoer.Text = "C1Sizer2"
        '
        'Vervoer_Listbox
        '
        Me.Vervoer_Listbox.FormattingEnabled = True
        Me.Vervoer_Listbox.Location = New System.Drawing.Point(444, 4)
        Me.Vervoer_Listbox.Name = "Vervoer_Listbox"
        Me.Vervoer_Listbox.Size = New System.Drawing.Size(435, 589)
        Me.Vervoer_Listbox.TabIndex = 3
        '
        'Vervoer_Treeview
        '
        Me.Vervoer_Treeview.CheckBoxes = True
        Me.Vervoer_Treeview.Location = New System.Drawing.Point(4, 4)
        Me.Vervoer_Treeview.Name = "Vervoer_Treeview"
        Me.Vervoer_Treeview.Size = New System.Drawing.Size(436, 600)
        Me.Vervoer_Treeview.TabIndex = 2
        '
        'Vervoer_PanelRechts
        '
        Me.Vervoer_PanelRechts.Controls.Add(Me.vervoer_vervoerder_klant_but)
        Me.Vervoer_PanelRechts.Controls.Add(Me.vervoer_afleverloc_klant_but)
        Me.Vervoer_PanelRechts.Controls.Add(Me.vervoer_omboek_vervoerder_cmb)
        Me.Vervoer_PanelRechts.Controls.Add(Me.vervoer_omboek_afleverloc_cmb)
        Me.Vervoer_PanelRechts.Controls.Add(Me.vervoer_vervoerder_order_but)
        Me.Vervoer_PanelRechts.Controls.Add(Me.vervoer_afleverloc_order_but)
        Me.Vervoer_PanelRechts.Controls.Add(Me.Label13)
        Me.Vervoer_PanelRechts.Controls.Add(Me.Vervoer_MonthCalendar)
        Me.Vervoer_PanelRechts.Location = New System.Drawing.Point(444, 608)
        Me.Vervoer_PanelRechts.Name = "Vervoer_PanelRechts"
        Me.Vervoer_PanelRechts.Size = New System.Drawing.Size(435, 328)
        Me.Vervoer_PanelRechts.TabIndex = 1
        '
        'vervoer_vervoerder_klant_but
        '
        Me.vervoer_vervoerder_klant_but.Location = New System.Drawing.Point(208, 234)
        Me.vervoer_vervoerder_klant_but.Name = "vervoer_vervoerder_klant_but"
        Me.vervoer_vervoerder_klant_but.Size = New System.Drawing.Size(183, 37)
        Me.vervoer_vervoerder_klant_but.TabIndex = 22
        Me.vervoer_vervoerder_klant_but.Text = "Verander vervoerder klant"
        Me.vervoer_vervoerder_klant_but.UseVisualStyleBackColor = True
        '
        'vervoer_afleverloc_klant_but
        '
        Me.vervoer_afleverloc_klant_but.Location = New System.Drawing.Point(14, 234)
        Me.vervoer_afleverloc_klant_but.Name = "vervoer_afleverloc_klant_but"
        Me.vervoer_afleverloc_klant_but.Size = New System.Drawing.Size(183, 37)
        Me.vervoer_afleverloc_klant_but.TabIndex = 21
        Me.vervoer_afleverloc_klant_but.Text = "Verander afleverlocatie klant"
        Me.vervoer_afleverloc_klant_but.UseVisualStyleBackColor = True
        '
        'vervoer_omboek_vervoerder_cmb
        '
        Me.vervoer_omboek_vervoerder_cmb.FormattingEnabled = True
        Me.vervoer_omboek_vervoerder_cmb.Location = New System.Drawing.Point(208, 207)
        Me.vervoer_omboek_vervoerder_cmb.Name = "vervoer_omboek_vervoerder_cmb"
        Me.vervoer_omboek_vervoerder_cmb.Size = New System.Drawing.Size(183, 21)
        Me.vervoer_omboek_vervoerder_cmb.TabIndex = 20
        '
        'vervoer_omboek_afleverloc_cmb
        '
        Me.vervoer_omboek_afleverloc_cmb.FormattingEnabled = True
        Me.vervoer_omboek_afleverloc_cmb.Location = New System.Drawing.Point(14, 207)
        Me.vervoer_omboek_afleverloc_cmb.Name = "vervoer_omboek_afleverloc_cmb"
        Me.vervoer_omboek_afleverloc_cmb.Size = New System.Drawing.Size(183, 21)
        Me.vervoer_omboek_afleverloc_cmb.TabIndex = 19
        '
        'vervoer_vervoerder_order_but
        '
        Me.vervoer_vervoerder_order_but.Location = New System.Drawing.Point(208, 274)
        Me.vervoer_vervoerder_order_but.Name = "vervoer_vervoerder_order_but"
        Me.vervoer_vervoerder_order_but.Size = New System.Drawing.Size(183, 37)
        Me.vervoer_vervoerder_order_but.TabIndex = 3
        Me.vervoer_vervoerder_order_but.Text = "Verander vervoerder order"
        Me.vervoer_vervoerder_order_but.UseVisualStyleBackColor = True
        '
        'vervoer_afleverloc_order_but
        '
        Me.vervoer_afleverloc_order_but.Location = New System.Drawing.Point(14, 274)
        Me.vervoer_afleverloc_order_but.Name = "vervoer_afleverloc_order_but"
        Me.vervoer_afleverloc_order_but.Size = New System.Drawing.Size(183, 37)
        Me.vervoer_afleverloc_order_but.TabIndex = 2
        Me.vervoer_afleverloc_order_but.Text = "Verander afleverlocatie order"
        Me.vervoer_afleverloc_order_but.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(11, 189)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 13)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Vervoer overboeken"
        '
        'Vervoer_MonthCalendar
        '
        Me.Vervoer_MonthCalendar.Location = New System.Drawing.Point(122, 15)
        Me.Vervoer_MonthCalendar.Name = "Vervoer_MonthCalendar"
        Me.Vervoer_MonthCalendar.TabIndex = 0
        '
        'Vervoer_PanelLinks
        '
        Me.Vervoer_PanelLinks.Controls.Add(Me.Vervoer_OphalenSelectie_but)
        Me.Vervoer_PanelLinks.Controls.Add(Me.vervoer_karrentotaal_lbl)
        Me.Vervoer_PanelLinks.Controls.Add(Me.Vervoer_OverzichtDeSelectAll)
        Me.Vervoer_PanelLinks.Controls.Add(Me.Vervoer_OverzichtSelectAll)
        Me.Vervoer_PanelLinks.Controls.Add(Me.vervoer_wordtopgehaald_but)
        Me.Vervoer_PanelLinks.Controls.Add(Me.Vervoer_VervoerderMail_but)
        Me.Vervoer_PanelLinks.Controls.Add(Me.Vervoer_OverzichtPrint_but)
        Me.Vervoer_PanelLinks.Controls.Add(Me.Vervoer_Vervoerder_cmb)
        Me.Vervoer_PanelLinks.Controls.Add(Me.Vervoer_OphalenBrieven_but)
        Me.Vervoer_PanelLinks.Location = New System.Drawing.Point(4, 608)
        Me.Vervoer_PanelLinks.Name = "Vervoer_PanelLinks"
        Me.Vervoer_PanelLinks.Size = New System.Drawing.Size(436, 328)
        Me.Vervoer_PanelLinks.TabIndex = 0
        '
        'Vervoer_OphalenSelectie_but
        '
        Me.Vervoer_OphalenSelectie_but.Location = New System.Drawing.Point(10, 70)
        Me.Vervoer_OphalenSelectie_but.Name = "Vervoer_OphalenSelectie_but"
        Me.Vervoer_OphalenSelectie_but.Size = New System.Drawing.Size(162, 32)
        Me.Vervoer_OphalenSelectie_but.TabIndex = 12
        Me.Vervoer_OphalenSelectie_but.Text = "Selectie ophalen"
        Me.Vervoer_OphalenSelectie_but.UseVisualStyleBackColor = True
        '
        'vervoer_karrentotaal_lbl
        '
        Me.vervoer_karrentotaal_lbl.AutoSize = True
        Me.vervoer_karrentotaal_lbl.Location = New System.Drawing.Point(7, 2)
        Me.vervoer_karrentotaal_lbl.Name = "vervoer_karrentotaal_lbl"
        Me.vervoer_karrentotaal_lbl.Size = New System.Drawing.Size(67, 13)
        Me.vervoer_karrentotaal_lbl.TabIndex = 11
        Me.vervoer_karrentotaal_lbl.Text = "Karren totaal"
        '
        'Vervoer_OverzichtDeSelectAll
        '
        Me.Vervoer_OverzichtDeSelectAll.Location = New System.Drawing.Point(10, 217)
        Me.Vervoer_OverzichtDeSelectAll.Name = "Vervoer_OverzichtDeSelectAll"
        Me.Vervoer_OverzichtDeSelectAll.Size = New System.Drawing.Size(162, 32)
        Me.Vervoer_OverzichtDeSelectAll.TabIndex = 10
        Me.Vervoer_OverzichtDeSelectAll.Text = "Verwijder alle checks"
        Me.Vervoer_OverzichtDeSelectAll.UseVisualStyleBackColor = True
        '
        'Vervoer_OverzichtSelectAll
        '
        Me.Vervoer_OverzichtSelectAll.Location = New System.Drawing.Point(10, 179)
        Me.Vervoer_OverzichtSelectAll.Name = "Vervoer_OverzichtSelectAll"
        Me.Vervoer_OverzichtSelectAll.Size = New System.Drawing.Size(162, 32)
        Me.Vervoer_OverzichtSelectAll.TabIndex = 9
        Me.Vervoer_OverzichtSelectAll.Text = "Zet alle checks"
        Me.Vervoer_OverzichtSelectAll.UseVisualStyleBackColor = True
        '
        'vervoer_wordtopgehaald_but
        '
        Me.vervoer_wordtopgehaald_but.Location = New System.Drawing.Point(210, 107)
        Me.vervoer_wordtopgehaald_but.Name = "vervoer_wordtopgehaald_but"
        Me.vervoer_wordtopgehaald_but.Size = New System.Drawing.Size(162, 32)
        Me.vervoer_wordtopgehaald_but.TabIndex = 8
        Me.vervoer_wordtopgehaald_but.Text = "Is thuisgehaald"
        Me.vervoer_wordtopgehaald_but.UseVisualStyleBackColor = True
        '
        'Vervoer_VervoerderMail_but
        '
        Me.Vervoer_VervoerderMail_but.Location = New System.Drawing.Point(210, 69)
        Me.Vervoer_VervoerderMail_but.Name = "Vervoer_VervoerderMail_but"
        Me.Vervoer_VervoerderMail_but.Size = New System.Drawing.Size(162, 32)
        Me.Vervoer_VervoerderMail_but.TabIndex = 6
        Me.Vervoer_VervoerderMail_but.Text = "Vervoerder mailen"
        Me.Vervoer_VervoerderMail_but.UseVisualStyleBackColor = True
        '
        'Vervoer_OverzichtPrint_but
        '
        Me.Vervoer_OverzichtPrint_but.Location = New System.Drawing.Point(10, 107)
        Me.Vervoer_OverzichtPrint_but.Name = "Vervoer_OverzichtPrint_but"
        Me.Vervoer_OverzichtPrint_but.Size = New System.Drawing.Size(162, 32)
        Me.Vervoer_OverzichtPrint_but.TabIndex = 5
        Me.Vervoer_OverzichtPrint_but.Text = "Overzicht printen"
        Me.Vervoer_OverzichtPrint_but.UseVisualStyleBackColor = True
        '
        'Vervoer_Vervoerder_cmb
        '
        Me.Vervoer_Vervoerder_cmb.FormattingEnabled = True
        Me.Vervoer_Vervoerder_cmb.Items.AddRange(New Object() {"De Winter", "Jan Aerts", "Wematrans"})
        Me.Vervoer_Vervoerder_cmb.Location = New System.Drawing.Point(210, 31)
        Me.Vervoer_Vervoerder_cmb.Name = "Vervoer_Vervoerder_cmb"
        Me.Vervoer_Vervoerder_cmb.Size = New System.Drawing.Size(166, 21)
        Me.Vervoer_Vervoerder_cmb.TabIndex = 2
        '
        'Vervoer_OphalenBrieven_but
        '
        Me.Vervoer_OphalenBrieven_but.Location = New System.Drawing.Point(10, 31)
        Me.Vervoer_OphalenBrieven_but.Name = "Vervoer_OphalenBrieven_but"
        Me.Vervoer_OphalenBrieven_but.Size = New System.Drawing.Size(162, 32)
        Me.Vervoer_OphalenBrieven_but.TabIndex = 0
        Me.Vervoer_OphalenBrieven_but.Text = "Overzicht ophalen"
        Me.Vervoer_OphalenBrieven_but.UseVisualStyleBackColor = True
        '
        'C1TabOverzichten
        '
        Me.C1TabOverzichten.Controls.Add(Me.OverzichtSizer1)
        Me.C1TabOverzichten.Location = New System.Drawing.Point(1, 24)
        Me.C1TabOverzichten.Name = "C1TabOverzichten"
        Me.C1TabOverzichten.Size = New System.Drawing.Size(883, 940)
        Me.C1TabOverzichten.TabIndex = 4
        Me.C1TabOverzichten.Text = "Overzicht"
        '
        'OverzichtSizer1
        '
        Me.OverzichtSizer1.Controls.Add(Me.OverzichtSizer2)
        Me.OverzichtSizer1.Controls.Add(Me.Overzicht_PictureBox)
        Me.OverzichtSizer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OverzichtSizer1.GridDefinition = "72.1276595744681:False:False;26.5957446808511:False:False;" & Global.Microsoft.VisualBasic.ChrW(9) & "99.0939977349943:False" &
    ":False;"
        Me.OverzichtSizer1.Location = New System.Drawing.Point(0, 0)
        Me.OverzichtSizer1.Name = "OverzichtSizer1"
        Me.OverzichtSizer1.Size = New System.Drawing.Size(883, 940)
        Me.OverzichtSizer1.TabIndex = 0
        Me.OverzichtSizer1.Text = "C1SizerOverzichten"
        '
        'OverzichtSizer2
        '
        Me.OverzichtSizer2.Controls.Add(Me.Overzicht_FlexGrid)
        Me.OverzichtSizer2.Controls.Add(Me.Overzicht_Panel)
        Me.OverzichtSizer2.GridDefinition = "96.8:False:False;" & Global.Microsoft.VisualBasic.ChrW(9) & "46.8571428571429:False:True;51.7714285714286:False:False;"
        Me.OverzichtSizer2.Location = New System.Drawing.Point(4, 686)
        Me.OverzichtSizer2.Name = "OverzichtSizer2"
        Me.OverzichtSizer2.Size = New System.Drawing.Size(875, 250)
        Me.OverzichtSizer2.TabIndex = 1
        Me.OverzichtSizer2.Text = "C1Sizer2"
        '
        'Overzicht_FlexGrid
        '
        Me.Overzicht_FlexGrid.ColumnInfo = resources.GetString("Overzicht_FlexGrid.ColumnInfo")
        Me.Overzicht_FlexGrid.Location = New System.Drawing.Point(418, 4)
        Me.Overzicht_FlexGrid.Name = "Overzicht_FlexGrid"
        Me.Overzicht_FlexGrid.Rows.DefaultSize = 17
        Me.Overzicht_FlexGrid.Size = New System.Drawing.Size(453, 242)
        Me.Overzicht_FlexGrid.TabIndex = 1
        '
        'Overzicht_Panel
        '
        Me.Overzicht_Panel.Controls.Add(Me.Overzicht_ExcelExport_but)
        Me.Overzicht_Panel.Controls.Add(Me.overzicht_week_lbl)
        Me.Overzicht_Panel.Controls.Add(Me.Overzicht_soortgroep_chk)
        Me.Overzicht_Panel.Controls.Add(Me.Overzicht_TotaalNieuw_cmb)
        Me.Overzicht_Panel.Controls.Add(Me.Overzicht_Soortgroep_cmb)
        Me.Overzicht_Panel.Controls.Add(Me.Overzicht_gegevensophalen_but)
        Me.Overzicht_Panel.Controls.Add(Me.Overzicht_klantspecifiek_chk)
        Me.Overzicht_Panel.Controls.Add(Me.Overzicht_klantspecifiek_cmb)
        Me.Overzicht_Panel.Controls.Add(Me.Overzicht_MonthCalendar)
        Me.Overzicht_Panel.Location = New System.Drawing.Point(4, 4)
        Me.Overzicht_Panel.Name = "Overzicht_Panel"
        Me.Overzicht_Panel.Size = New System.Drawing.Size(410, 242)
        Me.Overzicht_Panel.TabIndex = 0
        '
        'Overzicht_ExcelExport_but
        '
        Me.Overzicht_ExcelExport_but.Location = New System.Drawing.Point(226, 177)
        Me.Overzicht_ExcelExport_but.Name = "Overzicht_ExcelExport_but"
        Me.Overzicht_ExcelExport_but.Size = New System.Drawing.Size(181, 40)
        Me.Overzicht_ExcelExport_but.TabIndex = 24
        Me.Overzicht_ExcelExport_but.Text = "Exporteer naar XLSX"
        Me.Overzicht_ExcelExport_but.UseVisualStyleBackColor = True
        '
        'overzicht_week_lbl
        '
        Me.overzicht_week_lbl.AutoSize = True
        Me.overzicht_week_lbl.Location = New System.Drawing.Point(45, 194)
        Me.overzicht_week_lbl.Name = "overzicht_week_lbl"
        Me.overzicht_week_lbl.Size = New System.Drawing.Size(39, 13)
        Me.overzicht_week_lbl.TabIndex = 23
        Me.overzicht_week_lbl.Text = "Week:"
        '
        'Overzicht_soortgroep_chk
        '
        Me.Overzicht_soortgroep_chk.AutoSize = True
        Me.Overzicht_soortgroep_chk.Location = New System.Drawing.Point(226, 42)
        Me.Overzicht_soortgroep_chk.Name = "Overzicht_soortgroep_chk"
        Me.Overzicht_soortgroep_chk.Size = New System.Drawing.Size(15, 14)
        Me.Overzicht_soortgroep_chk.TabIndex = 22
        Me.Overzicht_soortgroep_chk.UseVisualStyleBackColor = True
        '
        'Overzicht_TotaalNieuw_cmb
        '
        Me.Overzicht_TotaalNieuw_cmb.FormattingEnabled = True
        Me.Overzicht_TotaalNieuw_cmb.Items.AddRange(New Object() {"Totaal", "Nieuw"})
        Me.Overzicht_TotaalNieuw_cmb.Location = New System.Drawing.Point(254, 66)
        Me.Overzicht_TotaalNieuw_cmb.Name = "Overzicht_TotaalNieuw_cmb"
        Me.Overzicht_TotaalNieuw_cmb.Size = New System.Drawing.Size(153, 21)
        Me.Overzicht_TotaalNieuw_cmb.TabIndex = 21
        Me.Overzicht_TotaalNieuw_cmb.Text = "Totaal"
        '
        'Overzicht_Soortgroep_cmb
        '
        Me.Overzicht_Soortgroep_cmb.FormattingEnabled = True
        Me.Overzicht_Soortgroep_cmb.Location = New System.Drawing.Point(254, 39)
        Me.Overzicht_Soortgroep_cmb.Name = "Overzicht_Soortgroep_cmb"
        Me.Overzicht_Soortgroep_cmb.Size = New System.Drawing.Size(153, 21)
        Me.Overzicht_Soortgroep_cmb.TabIndex = 20
        '
        'Overzicht_gegevensophalen_but
        '
        Me.Overzicht_gegevensophalen_but.Location = New System.Drawing.Point(226, 131)
        Me.Overzicht_gegevensophalen_but.Name = "Overzicht_gegevensophalen_but"
        Me.Overzicht_gegevensophalen_but.Size = New System.Drawing.Size(181, 40)
        Me.Overzicht_gegevensophalen_but.TabIndex = 19
        Me.Overzicht_gegevensophalen_but.Text = "Gegevens ophalen"
        Me.Overzicht_gegevensophalen_but.UseVisualStyleBackColor = True
        '
        'Overzicht_klantspecifiek_chk
        '
        Me.Overzicht_klantspecifiek_chk.AutoSize = True
        Me.Overzicht_klantspecifiek_chk.Location = New System.Drawing.Point(226, 12)
        Me.Overzicht_klantspecifiek_chk.Name = "Overzicht_klantspecifiek_chk"
        Me.Overzicht_klantspecifiek_chk.Size = New System.Drawing.Size(15, 14)
        Me.Overzicht_klantspecifiek_chk.TabIndex = 18
        Me.Overzicht_klantspecifiek_chk.UseVisualStyleBackColor = True
        '
        'Overzicht_klantspecifiek_cmb
        '
        Me.Overzicht_klantspecifiek_cmb.FormattingEnabled = True
        Me.Overzicht_klantspecifiek_cmb.Location = New System.Drawing.Point(254, 9)
        Me.Overzicht_klantspecifiek_cmb.Name = "Overzicht_klantspecifiek_cmb"
        Me.Overzicht_klantspecifiek_cmb.Size = New System.Drawing.Size(153, 21)
        Me.Overzicht_klantspecifiek_cmb.TabIndex = 17
        '
        'Overzicht_MonthCalendar
        '
        Me.Overzicht_MonthCalendar.Location = New System.Drawing.Point(9, 9)
        Me.Overzicht_MonthCalendar.Name = "Overzicht_MonthCalendar"
        Me.Overzicht_MonthCalendar.ShowWeekNumbers = True
        Me.Overzicht_MonthCalendar.TabIndex = 0
        '
        'Overzicht_PictureBox
        '
        Me.Overzicht_PictureBox.Location = New System.Drawing.Point(4, 4)
        Me.Overzicht_PictureBox.Name = "Overzicht_PictureBox"
        Me.Overzicht_PictureBox.Size = New System.Drawing.Size(875, 678)
        Me.Overzicht_PictureBox.TabIndex = 0
        Me.Overzicht_PictureBox.TabStop = False
        '
        'C1TabDatabase
        '
        Me.C1TabDatabase.Controls.Add(Me.C1Sizer1)
        Me.C1TabDatabase.Location = New System.Drawing.Point(1, 24)
        Me.C1TabDatabase.Name = "C1TabDatabase"
        Me.C1TabDatabase.Size = New System.Drawing.Size(883, 940)
        Me.C1TabDatabase.TabIndex = 5
        Me.C1TabDatabase.Text = "Database"
        '
        'C1Sizer1
        '
        Me.C1Sizer1.Controls.Add(Me.DatabaseComboWpsFilter)
        Me.C1Sizer1.Controls.Add(Me.DatabaseFlexGridEdit)
        Me.C1Sizer1.Controls.Add(Me.DatabaseFlexGridShow)
        Me.C1Sizer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1Sizer1.GridDefinition = "6.38297872340426:False:True;92.3404255319149:False:False;" & Global.Microsoft.VisualBasic.ChrW(9) & "99.0939977349943:False:" &
    "False;"
        Me.C1Sizer1.Location = New System.Drawing.Point(0, 0)
        Me.C1Sizer1.Name = "C1Sizer1"
        Me.C1Sizer1.Size = New System.Drawing.Size(883, 940)
        Me.C1Sizer1.TabIndex = 0
        Me.C1Sizer1.Text = "C1Sizer1"
        '
        'DatabaseComboWpsFilter
        '
        Me.DatabaseComboWpsFilter.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.DatabaseComboWpsFilter.Caption = ""
        Me.DatabaseComboWpsFilter.CaptionHeight = 17
        Me.DatabaseComboWpsFilter.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.DatabaseComboWpsFilter.ColumnCaptionHeight = 17
        Me.DatabaseComboWpsFilter.ColumnFooterHeight = 17
        Me.DatabaseComboWpsFilter.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.DatabaseComboWpsFilter.EditorBackColor = System.Drawing.SystemColors.Window
        Me.DatabaseComboWpsFilter.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.DatabaseComboWpsFilter.Images.Add(CType(resources.GetObject("DatabaseComboWpsFilter.Images"), System.Drawing.Image))
        Me.DatabaseComboWpsFilter.ItemHeight = 15
        Me.DatabaseComboWpsFilter.Location = New System.Drawing.Point(4, 68)
        Me.DatabaseComboWpsFilter.MatchEntryTimeout = CType(2000, Long)
        Me.DatabaseComboWpsFilter.MaxDropDownItems = CType(5, Short)
        Me.DatabaseComboWpsFilter.MaxLength = 32767
        Me.DatabaseComboWpsFilter.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.DatabaseComboWpsFilter.Name = "DatabaseComboWpsFilter"
        Me.DatabaseComboWpsFilter.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.DatabaseComboWpsFilter.Size = New System.Drawing.Size(875, 21)
        Me.DatabaseComboWpsFilter.TabIndex = 2
        Me.DatabaseComboWpsFilter.Visible = False
        Me.DatabaseComboWpsFilter.PropBag = resources.GetString("DatabaseComboWpsFilter.PropBag")
        '
        'DatabaseFlexGridEdit
        '
        Me.DatabaseFlexGridEdit.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.DatabaseFlexGridEdit.ColumnInfo = "10,0,0,0,0,85,Columns:"
        Me.DatabaseFlexGridEdit.Location = New System.Drawing.Point(4, 4)
        Me.DatabaseFlexGridEdit.Name = "DatabaseFlexGridEdit"
        Me.DatabaseFlexGridEdit.Rows.Count = 2
        Me.DatabaseFlexGridEdit.Rows.DefaultSize = 17
        Me.DatabaseFlexGridEdit.Size = New System.Drawing.Size(875, 60)
        Me.DatabaseFlexGridEdit.TabIndex = 0
        '
        'DatabaseFlexGridShow
        '
        Me.DatabaseFlexGridShow.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.DatabaseFlexGridShow.AllowEditing = False
        Me.DatabaseFlexGridShow.ColumnInfo = "10,0,0,0,0,85,Columns:"
        Me.DatabaseFlexGridShow.Location = New System.Drawing.Point(4, 68)
        Me.DatabaseFlexGridShow.Name = "DatabaseFlexGridShow"
        Me.DatabaseFlexGridShow.Rows.DefaultSize = 17
        Me.DatabaseFlexGridShow.Rows.GlyphRow = 0
        Me.DatabaseFlexGridShow.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.ListBox
        Me.DatabaseFlexGridShow.Size = New System.Drawing.Size(875, 868)
        Me.DatabaseFlexGridShow.TabIndex = 1
        '
        'C1TabInstellingen
        '
        Me.C1TabInstellingen.Controls.Add(Me.Inst_paspoortb2_txt)
        Me.C1TabInstellingen.Controls.Add(Me.Inst_paspoortb1_txt)
        Me.C1TabInstellingen.Controls.Add(Me.Label53)
        Me.C1TabInstellingen.Controls.Add(Me.Label54)
        Me.C1TabInstellingen.Controls.Add(Me.Inst_paspoort2_txt)
        Me.C1TabInstellingen.Controls.Add(Me.Inst_paspoort1_txt)
        Me.C1TabInstellingen.Controls.Add(Me.Label52)
        Me.C1TabInstellingen.Controls.Add(Me.Label51)
        Me.C1TabInstellingen.Controls.Add(Me.inst_dfdkleinprint)
        Me.C1TabInstellingen.Controls.Add(Me.inst_database_boekjenp)
        Me.C1TabInstellingen.Controls.Add(Me.inst_boekreload_lbl)
        Me.C1TabInstellingen.Controls.Add(Me.ActivityTimer_lbl)
        Me.C1TabInstellingen.Controls.Add(Me.Inst_printerselect_chk)
        Me.C1TabInstellingen.Controls.Add(Me.Inst_printerip_txt)
        Me.C1TabInstellingen.Controls.Add(Me.Label47)
        Me.C1TabInstellingen.Controls.Add(Me.Label46)
        Me.C1TabInstellingen.Controls.Add(Me.Inst_Login8_T_chk)
        Me.C1TabInstellingen.Controls.Add(Me.Inst_Login7_T_chk)
        Me.C1TabInstellingen.Controls.Add(Me.Inst_Login6_T_chk)
        Me.C1TabInstellingen.Controls.Add(Me.Inst_Login5_T_chk)
        Me.C1TabInstellingen.Controls.Add(Me.Inst_Login4_T_chk)
        Me.C1TabInstellingen.Controls.Add(Me.Inst_Login3_T_chk)
        Me.C1TabInstellingen.Controls.Add(Me.Inst_Login2_T_chk)
        Me.C1TabInstellingen.Controls.Add(Me.Inst_Login1_T_chk)
        Me.C1TabInstellingen.Controls.Add(Me.Label45)
        Me.C1TabInstellingen.Controls.Add(Me.Label44)
        Me.C1TabInstellingen.Controls.Add(Me.Inst_Login8_v2_chk)
        Me.C1TabInstellingen.Controls.Add(Me.Inst_Login7_v2_chk)
        Me.C1TabInstellingen.Controls.Add(Me.Inst_Login6_v2_chk)
        Me.C1TabInstellingen.Controls.Add(Me.Inst_Login5_v2_chk)
        Me.C1TabInstellingen.Controls.Add(Me.Inst_Login4_v2_chk)
        Me.C1TabInstellingen.Controls.Add(Me.Inst_Login3_v2_chk)
        Me.C1TabInstellingen.Controls.Add(Me.Inst_Login2_v2_chk)
        Me.C1TabInstellingen.Controls.Add(Me.Inst_Login1_v2_chk)
        Me.C1TabInstellingen.Controls.Add(Me.Inst_Overig_GB)
        Me.C1TabInstellingen.Controls.Add(Me.Inst_Vervoer_annuleren_but)
        Me.C1TabInstellingen.Controls.Add(Me.Inst_Vervoer_opslaan_but)
        Me.C1TabInstellingen.Controls.Add(Me.Inst_Westland_GB)
        Me.C1TabInstellingen.Controls.Add(Me.Inst_Vervoer_aanpassen_but)
        Me.C1TabInstellingen.Controls.Add(Me.Inst_dag_lbl)
        Me.C1TabInstellingen.Controls.Add(Me.Inst_vervoerstijden_lbl)
        Me.C1TabInstellingen.Controls.Add(Me.Inst_weekdag_cmb)
        Me.C1TabInstellingen.Controls.Add(Me.Inst_barcodeserver)
        Me.C1TabInstellingen.Controls.Add(Me.Inst_Login8_v1_chk)
        Me.C1TabInstellingen.Controls.Add(Me.Inst_Login7_v1_chk)
        Me.C1TabInstellingen.Controls.Add(Me.Inst_Login6_v1_chk)
        Me.C1TabInstellingen.Controls.Add(Me.Inst_Login5_v1_chk)
        Me.C1TabInstellingen.Controls.Add(Me.Inst_Login4_v1_chk)
        Me.C1TabInstellingen.Controls.Add(Me.Inst_Login3_v1_chk)
        Me.C1TabInstellingen.Controls.Add(Me.Inst_Login2_v1_chk)
        Me.C1TabInstellingen.Controls.Add(Me.Inst_Login1_v1_chk)
        Me.C1TabInstellingen.Controls.Add(Me.Inst_test_server)
        Me.C1TabInstellingen.Controls.Add(Me.Inst_Login8_Txt)
        Me.C1TabInstellingen.Controls.Add(Me.SettingsLogin8)
        Me.C1TabInstellingen.Controls.Add(Me.Inst_Login7_Txt)
        Me.C1TabInstellingen.Controls.Add(Me.SettingsLogin7)
        Me.C1TabInstellingen.Controls.Add(Me.Inst_Login6_Txt)
        Me.C1TabInstellingen.Controls.Add(Me.SettingsLogin6)
        Me.C1TabInstellingen.Controls.Add(Me.Inst_Login5_Txt)
        Me.C1TabInstellingen.Controls.Add(Me.SettingsLogin5)
        Me.C1TabInstellingen.Controls.Add(Me.Inst_Login4_Txt)
        Me.C1TabInstellingen.Controls.Add(Me.SettingsLogin4)
        Me.C1TabInstellingen.Controls.Add(Me.Inst_Login3_Txt)
        Me.C1TabInstellingen.Controls.Add(Me.SettingsLogin3)
        Me.C1TabInstellingen.Controls.Add(Me.Inst_Login2_Txt)
        Me.C1TabInstellingen.Controls.Add(Me.SettingsLogin2)
        Me.C1TabInstellingen.Controls.Add(Me.Inst_Login1_Txt)
        Me.C1TabInstellingen.Controls.Add(Me.SettingsLogin1)
        Me.C1TabInstellingen.Controls.Add(Me.Inst_MySQLPass_Txt)
        Me.C1TabInstellingen.Controls.Add(Me.SettingsMySQL_lbl4)
        Me.C1TabInstellingen.Controls.Add(Me.Inst_MySQLUser_Txt)
        Me.C1TabInstellingen.Controls.Add(Me.SettingsMySQL_lbl3)
        Me.C1TabInstellingen.Controls.Add(Me.Inst_MySQLServer_Txt)
        Me.C1TabInstellingen.Controls.Add(Me.SettingsMySQL_lbl2)
        Me.C1TabInstellingen.Controls.Add(Me.Inst_MySQLODBC_Txt)
        Me.C1TabInstellingen.Controls.Add(Me.SettingsMySQL_lbl1)
        Me.C1TabInstellingen.Location = New System.Drawing.Point(1, 24)
        Me.C1TabInstellingen.Name = "C1TabInstellingen"
        Me.C1TabInstellingen.Size = New System.Drawing.Size(883, 940)
        Me.C1TabInstellingen.TabIndex = 6
        Me.C1TabInstellingen.Text = "Instellingen"
        '
        'Inst_paspoortb2_txt
        '
        Me.Inst_paspoortb2_txt.Location = New System.Drawing.Point(634, 234)
        Me.Inst_paspoortb2_txt.Name = "Inst_paspoortb2_txt"
        Me.Inst_paspoortb2_txt.Size = New System.Drawing.Size(100, 20)
        Me.Inst_paspoortb2_txt.TabIndex = 81
        '
        'Inst_paspoortb1_txt
        '
        Me.Inst_paspoortb1_txt.Location = New System.Drawing.Point(634, 208)
        Me.Inst_paspoortb1_txt.Name = "Inst_paspoortb1_txt"
        Me.Inst_paspoortb1_txt.Size = New System.Drawing.Size(100, 20)
        Me.Inst_paspoortb1_txt.TabIndex = 80
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Location = New System.Drawing.Point(473, 237)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(158, 13)
        Me.Label53.TabIndex = 79
        Me.Label53.Text = "Plantenpaspoort HW bakstikker"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Location = New System.Drawing.Point(473, 211)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(154, 13)
        Me.Label54.TabIndex = 78
        Me.Label54.Text = "Plantenpaspoort KR bakstikker"
        '
        'Inst_paspoort2_txt
        '
        Me.Inst_paspoort2_txt.Location = New System.Drawing.Point(590, 181)
        Me.Inst_paspoort2_txt.Name = "Inst_paspoort2_txt"
        Me.Inst_paspoort2_txt.Size = New System.Drawing.Size(100, 20)
        Me.Inst_paspoort2_txt.TabIndex = 77
        '
        'Inst_paspoort1_txt
        '
        Me.Inst_paspoort1_txt.Location = New System.Drawing.Point(590, 155)
        Me.Inst_paspoort1_txt.Name = "Inst_paspoort1_txt"
        Me.Inst_paspoort1_txt.Size = New System.Drawing.Size(100, 20)
        Me.Inst_paspoort1_txt.TabIndex = 76
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(473, 184)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(106, 13)
        Me.Label52.TabIndex = 75
        Me.Label52.Text = "Plantenpaspoort HW"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(473, 158)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(102, 13)
        Me.Label51.TabIndex = 74
        Me.Label51.Text = "Plantenpaspoort KR"
        '
        'inst_dfdkleinprint
        '
        Me.inst_dfdkleinprint.AutoSize = True
        Me.inst_dfdkleinprint.Location = New System.Drawing.Point(549, 73)
        Me.inst_dfdkleinprint.Name = "inst_dfdkleinprint"
        Me.inst_dfdkleinprint.Size = New System.Drawing.Size(109, 17)
        Me.inst_dfdkleinprint.TabIndex = 73
        Me.inst_dfdkleinprint.Text = "DFD Klein printen"
        Me.inst_dfdkleinprint.UseVisualStyleBackColor = True
        '
        'inst_database_boekjenp
        '
        Me.inst_database_boekjenp.AutoSize = True
        Me.inst_database_boekjenp.Location = New System.Drawing.Point(272, 129)
        Me.inst_database_boekjenp.Name = "inst_database_boekjenp"
        Me.inst_database_boekjenp.Size = New System.Drawing.Size(96, 17)
        Me.inst_database_boekjenp.TabIndex = 72
        Me.inst_database_boekjenp.Text = "Test JP Server"
        Me.inst_database_boekjenp.UseVisualStyleBackColor = True
        '
        'inst_boekreload_lbl
        '
        Me.inst_boekreload_lbl.AutoSize = True
        Me.inst_boekreload_lbl.Location = New System.Drawing.Point(470, 132)
        Me.inst_boekreload_lbl.Name = "inst_boekreload_lbl"
        Me.inst_boekreload_lbl.Size = New System.Drawing.Size(44, 13)
        Me.inst_boekreload_lbl.TabIndex = 71
        Me.inst_boekreload_lbl.Text = "Reload:"
        '
        'ActivityTimer_lbl
        '
        Me.ActivityTimer_lbl.AutoSize = True
        Me.ActivityTimer_lbl.Location = New System.Drawing.Point(470, 110)
        Me.ActivityTimer_lbl.Name = "ActivityTimer_lbl"
        Me.ActivityTimer_lbl.Size = New System.Drawing.Size(73, 13)
        Me.ActivityTimer_lbl.TabIndex = 70
        Me.ActivityTimer_lbl.Text = "Activity Timer:"
        '
        'Inst_printerselect_chk
        '
        Me.Inst_printerselect_chk.AutoSize = True
        Me.Inst_printerselect_chk.Location = New System.Drawing.Point(549, 50)
        Me.Inst_printerselect_chk.Name = "Inst_printerselect_chk"
        Me.Inst_printerselect_chk.Size = New System.Drawing.Size(175, 17)
        Me.Inst_printerselect_chk.TabIndex = 69
        Me.Inst_printerselect_chk.Text = "Printer selectie DFD en Vervoer"
        Me.Inst_printerselect_chk.UseVisualStyleBackColor = True
        '
        'Inst_printerip_txt
        '
        Me.Inst_printerip_txt.Location = New System.Drawing.Point(549, 22)
        Me.Inst_printerip_txt.Name = "Inst_printerip_txt"
        Me.Inst_printerip_txt.Size = New System.Drawing.Size(174, 20)
        Me.Inst_printerip_txt.TabIndex = 68
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(470, 25)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(73, 13)
        Me.Label47.TabIndex = 67
        Me.Label47.Text = "Labelprinter ip"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(353, 174)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(23, 13)
        Me.Label46.TabIndex = 66
        Me.Label46.Text = "Tot"
        '
        'Inst_Login8_T_chk
        '
        Me.Inst_Login8_T_chk.AutoSize = True
        Me.Inst_Login8_T_chk.Location = New System.Drawing.Point(356, 380)
        Me.Inst_Login8_T_chk.Name = "Inst_Login8_T_chk"
        Me.Inst_Login8_T_chk.Size = New System.Drawing.Size(15, 14)
        Me.Inst_Login8_T_chk.TabIndex = 65
        Me.Inst_Login8_T_chk.UseVisualStyleBackColor = True
        '
        'Inst_Login7_T_chk
        '
        Me.Inst_Login7_T_chk.AutoSize = True
        Me.Inst_Login7_T_chk.Location = New System.Drawing.Point(356, 354)
        Me.Inst_Login7_T_chk.Name = "Inst_Login7_T_chk"
        Me.Inst_Login7_T_chk.Size = New System.Drawing.Size(15, 14)
        Me.Inst_Login7_T_chk.TabIndex = 64
        Me.Inst_Login7_T_chk.UseVisualStyleBackColor = True
        '
        'Inst_Login6_T_chk
        '
        Me.Inst_Login6_T_chk.AutoSize = True
        Me.Inst_Login6_T_chk.Location = New System.Drawing.Point(356, 329)
        Me.Inst_Login6_T_chk.Name = "Inst_Login6_T_chk"
        Me.Inst_Login6_T_chk.Size = New System.Drawing.Size(15, 14)
        Me.Inst_Login6_T_chk.TabIndex = 63
        Me.Inst_Login6_T_chk.UseVisualStyleBackColor = True
        '
        'Inst_Login5_T_chk
        '
        Me.Inst_Login5_T_chk.AutoSize = True
        Me.Inst_Login5_T_chk.Location = New System.Drawing.Point(356, 303)
        Me.Inst_Login5_T_chk.Name = "Inst_Login5_T_chk"
        Me.Inst_Login5_T_chk.Size = New System.Drawing.Size(15, 14)
        Me.Inst_Login5_T_chk.TabIndex = 62
        Me.Inst_Login5_T_chk.UseVisualStyleBackColor = True
        '
        'Inst_Login4_T_chk
        '
        Me.Inst_Login4_T_chk.AutoSize = True
        Me.Inst_Login4_T_chk.Location = New System.Drawing.Point(356, 277)
        Me.Inst_Login4_T_chk.Name = "Inst_Login4_T_chk"
        Me.Inst_Login4_T_chk.Size = New System.Drawing.Size(15, 14)
        Me.Inst_Login4_T_chk.TabIndex = 61
        Me.Inst_Login4_T_chk.UseVisualStyleBackColor = True
        '
        'Inst_Login3_T_chk
        '
        Me.Inst_Login3_T_chk.AutoSize = True
        Me.Inst_Login3_T_chk.Location = New System.Drawing.Point(356, 251)
        Me.Inst_Login3_T_chk.Name = "Inst_Login3_T_chk"
        Me.Inst_Login3_T_chk.Size = New System.Drawing.Size(15, 14)
        Me.Inst_Login3_T_chk.TabIndex = 60
        Me.Inst_Login3_T_chk.UseVisualStyleBackColor = True
        '
        'Inst_Login2_T_chk
        '
        Me.Inst_Login2_T_chk.AutoSize = True
        Me.Inst_Login2_T_chk.Location = New System.Drawing.Point(356, 225)
        Me.Inst_Login2_T_chk.Name = "Inst_Login2_T_chk"
        Me.Inst_Login2_T_chk.Size = New System.Drawing.Size(15, 14)
        Me.Inst_Login2_T_chk.TabIndex = 59
        Me.Inst_Login2_T_chk.UseVisualStyleBackColor = True
        '
        'Inst_Login1_T_chk
        '
        Me.Inst_Login1_T_chk.AutoSize = True
        Me.Inst_Login1_T_chk.Location = New System.Drawing.Point(356, 198)
        Me.Inst_Login1_T_chk.Name = "Inst_Login1_T_chk"
        Me.Inst_Login1_T_chk.Size = New System.Drawing.Size(15, 14)
        Me.Inst_Login1_T_chk.TabIndex = 58
        Me.Inst_Login1_T_chk.UseVisualStyleBackColor = True
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(419, 174)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(13, 13)
        Me.Label45.TabIndex = 57
        Me.Label45.Text = "2"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(384, 174)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(13, 13)
        Me.Label44.TabIndex = 56
        Me.Label44.Text = "1"
        '
        'Inst_Login8_v2_chk
        '
        Me.Inst_Login8_v2_chk.AutoSize = True
        Me.Inst_Login8_v2_chk.Location = New System.Drawing.Point(422, 380)
        Me.Inst_Login8_v2_chk.Name = "Inst_Login8_v2_chk"
        Me.Inst_Login8_v2_chk.Size = New System.Drawing.Size(15, 14)
        Me.Inst_Login8_v2_chk.TabIndex = 55
        Me.Inst_Login8_v2_chk.UseVisualStyleBackColor = True
        '
        'Inst_Login7_v2_chk
        '
        Me.Inst_Login7_v2_chk.AutoSize = True
        Me.Inst_Login7_v2_chk.Location = New System.Drawing.Point(422, 354)
        Me.Inst_Login7_v2_chk.Name = "Inst_Login7_v2_chk"
        Me.Inst_Login7_v2_chk.Size = New System.Drawing.Size(15, 14)
        Me.Inst_Login7_v2_chk.TabIndex = 54
        Me.Inst_Login7_v2_chk.UseVisualStyleBackColor = True
        '
        'Inst_Login6_v2_chk
        '
        Me.Inst_Login6_v2_chk.AutoSize = True
        Me.Inst_Login6_v2_chk.Location = New System.Drawing.Point(422, 329)
        Me.Inst_Login6_v2_chk.Name = "Inst_Login6_v2_chk"
        Me.Inst_Login6_v2_chk.Size = New System.Drawing.Size(15, 14)
        Me.Inst_Login6_v2_chk.TabIndex = 53
        Me.Inst_Login6_v2_chk.UseVisualStyleBackColor = True
        '
        'Inst_Login5_v2_chk
        '
        Me.Inst_Login5_v2_chk.AutoSize = True
        Me.Inst_Login5_v2_chk.Location = New System.Drawing.Point(422, 303)
        Me.Inst_Login5_v2_chk.Name = "Inst_Login5_v2_chk"
        Me.Inst_Login5_v2_chk.Size = New System.Drawing.Size(15, 14)
        Me.Inst_Login5_v2_chk.TabIndex = 52
        Me.Inst_Login5_v2_chk.UseVisualStyleBackColor = True
        '
        'Inst_Login4_v2_chk
        '
        Me.Inst_Login4_v2_chk.AutoSize = True
        Me.Inst_Login4_v2_chk.Location = New System.Drawing.Point(422, 277)
        Me.Inst_Login4_v2_chk.Name = "Inst_Login4_v2_chk"
        Me.Inst_Login4_v2_chk.Size = New System.Drawing.Size(15, 14)
        Me.Inst_Login4_v2_chk.TabIndex = 51
        Me.Inst_Login4_v2_chk.UseVisualStyleBackColor = True
        '
        'Inst_Login3_v2_chk
        '
        Me.Inst_Login3_v2_chk.AutoSize = True
        Me.Inst_Login3_v2_chk.Location = New System.Drawing.Point(422, 251)
        Me.Inst_Login3_v2_chk.Name = "Inst_Login3_v2_chk"
        Me.Inst_Login3_v2_chk.Size = New System.Drawing.Size(15, 14)
        Me.Inst_Login3_v2_chk.TabIndex = 50
        Me.Inst_Login3_v2_chk.UseVisualStyleBackColor = True
        '
        'Inst_Login2_v2_chk
        '
        Me.Inst_Login2_v2_chk.AutoSize = True
        Me.Inst_Login2_v2_chk.Location = New System.Drawing.Point(422, 225)
        Me.Inst_Login2_v2_chk.Name = "Inst_Login2_v2_chk"
        Me.Inst_Login2_v2_chk.Size = New System.Drawing.Size(15, 14)
        Me.Inst_Login2_v2_chk.TabIndex = 49
        Me.Inst_Login2_v2_chk.UseVisualStyleBackColor = True
        '
        'Inst_Login1_v2_chk
        '
        Me.Inst_Login1_v2_chk.AutoSize = True
        Me.Inst_Login1_v2_chk.Location = New System.Drawing.Point(422, 198)
        Me.Inst_Login1_v2_chk.Name = "Inst_Login1_v2_chk"
        Me.Inst_Login1_v2_chk.Size = New System.Drawing.Size(15, 14)
        Me.Inst_Login1_v2_chk.TabIndex = 48
        Me.Inst_Login1_v2_chk.UseVisualStyleBackColor = True
        '
        'Inst_Overig_GB
        '
        Me.Inst_Overig_GB.Controls.Add(Me.Label34)
        Me.Inst_Overig_GB.Controls.Add(Me.Label35)
        Me.Inst_Overig_GB.Controls.Add(Me.Label36)
        Me.Inst_Overig_GB.Controls.Add(Me.Label37)
        Me.Inst_Overig_GB.Controls.Add(Me.Inst_oboektijd7_txt)
        Me.Inst_Overig_GB.Controls.Add(Me.Inst_odag7_ud)
        Me.Inst_Overig_GB.Controls.Add(Me.Inst_o7_chk)
        Me.Inst_Overig_GB.Controls.Add(Me.Inst_ochktijd7_txt)
        Me.Inst_Overig_GB.Controls.Add(Me.Label38)
        Me.Inst_Overig_GB.Controls.Add(Me.Inst_oboektijd6_txt)
        Me.Inst_Overig_GB.Controls.Add(Me.Inst_odag6_ud)
        Me.Inst_Overig_GB.Controls.Add(Me.Inst_o6_chk)
        Me.Inst_Overig_GB.Controls.Add(Me.Inst_ochktijd6_txt)
        Me.Inst_Overig_GB.Controls.Add(Me.Label39)
        Me.Inst_Overig_GB.Controls.Add(Me.Inst_oboektijd5_txt)
        Me.Inst_Overig_GB.Controls.Add(Me.Inst_odag5_ud)
        Me.Inst_Overig_GB.Controls.Add(Me.Inst_o5_chk)
        Me.Inst_Overig_GB.Controls.Add(Me.Inst_ochktijd5_txt)
        Me.Inst_Overig_GB.Controls.Add(Me.Label40)
        Me.Inst_Overig_GB.Controls.Add(Me.Inst_oboektijd4_txt)
        Me.Inst_Overig_GB.Controls.Add(Me.Inst_odag4_ud)
        Me.Inst_Overig_GB.Controls.Add(Me.Inst_o4_chk)
        Me.Inst_Overig_GB.Controls.Add(Me.Inst_ochktijd4_txt)
        Me.Inst_Overig_GB.Controls.Add(Me.Label41)
        Me.Inst_Overig_GB.Controls.Add(Me.Inst_oboektijd3_txt)
        Me.Inst_Overig_GB.Controls.Add(Me.Inst_odag3_ud)
        Me.Inst_Overig_GB.Controls.Add(Me.Inst_o3_chk)
        Me.Inst_Overig_GB.Controls.Add(Me.Inst_ochktijd3_txt)
        Me.Inst_Overig_GB.Controls.Add(Me.Label42)
        Me.Inst_Overig_GB.Controls.Add(Me.Inst_oboektijd2_txt)
        Me.Inst_Overig_GB.Controls.Add(Me.Inst_odag2_ud)
        Me.Inst_Overig_GB.Controls.Add(Me.Inst_o2_chk)
        Me.Inst_Overig_GB.Controls.Add(Me.Inst_ochktijd2_txt)
        Me.Inst_Overig_GB.Controls.Add(Me.Label43)
        Me.Inst_Overig_GB.Controls.Add(Me.Inst_oboektijd1_txt)
        Me.Inst_Overig_GB.Controls.Add(Me.Inst_odag1_ud)
        Me.Inst_Overig_GB.Controls.Add(Me.Inst_o1_chk)
        Me.Inst_Overig_GB.Controls.Add(Me.Inst_ochktijd1_txt)
        Me.Inst_Overig_GB.Enabled = False
        Me.Inst_Overig_GB.Location = New System.Drawing.Point(343, 543)
        Me.Inst_Overig_GB.Name = "Inst_Overig_GB"
        Me.Inst_Overig_GB.Size = New System.Drawing.Size(300, 264)
        Me.Inst_Overig_GB.TabIndex = 46
        Me.Inst_Overig_GB.TabStop = False
        Me.Inst_Overig_GB.Text = "Overige locaties"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(229, 25)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(24, 13)
        Me.Label34.TabIndex = 38
        Me.Label34.Text = "Tijd"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(165, 24)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(39, 13)
        Me.Label35.TabIndex = 37
        Me.Label35.Text = "Dagen"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(57, 25)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(24, 13)
        Me.Label36.TabIndex = 36
        Me.Label36.Text = "Tijd"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(115, 205)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(16, 13)
        Me.Label37.TabIndex = 35
        Me.Label37.Text = "->"
        '
        'Inst_oboektijd7_txt
        '
        Me.Inst_oboektijd7_txt.Location = New System.Drawing.Point(216, 202)
        Me.Inst_oboektijd7_txt.Name = "Inst_oboektijd7_txt"
        Me.Inst_oboektijd7_txt.Size = New System.Drawing.Size(55, 20)
        Me.Inst_oboektijd7_txt.TabIndex = 34
        '
        'Inst_odag7_ud
        '
        Me.Inst_odag7_ud.Location = New System.Drawing.Point(166, 201)
        Me.Inst_odag7_ud.Maximum = New Decimal(New Integer() {7, 0, 0, 0})
        Me.Inst_odag7_ud.Minimum = New Decimal(New Integer() {7, 0, 0, -2147483648})
        Me.Inst_odag7_ud.Name = "Inst_odag7_ud"
        Me.Inst_odag7_ud.Size = New System.Drawing.Size(44, 20)
        Me.Inst_odag7_ud.TabIndex = 33
        '
        'Inst_o7_chk
        '
        Me.Inst_o7_chk.AutoSize = True
        Me.Inst_o7_chk.Location = New System.Drawing.Point(13, 203)
        Me.Inst_o7_chk.Name = "Inst_o7_chk"
        Me.Inst_o7_chk.Size = New System.Drawing.Size(35, 17)
        Me.Inst_o7_chk.TabIndex = 32
        Me.Inst_o7_chk.Text = " <"
        Me.Inst_o7_chk.UseVisualStyleBackColor = True
        '
        'Inst_ochktijd7_txt
        '
        Me.Inst_ochktijd7_txt.Location = New System.Drawing.Point(54, 201)
        Me.Inst_ochktijd7_txt.Name = "Inst_ochktijd7_txt"
        Me.Inst_ochktijd7_txt.Size = New System.Drawing.Size(55, 20)
        Me.Inst_ochktijd7_txt.TabIndex = 31
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(115, 179)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(16, 13)
        Me.Label38.TabIndex = 30
        Me.Label38.Text = "->"
        '
        'Inst_oboektijd6_txt
        '
        Me.Inst_oboektijd6_txt.Location = New System.Drawing.Point(216, 176)
        Me.Inst_oboektijd6_txt.Name = "Inst_oboektijd6_txt"
        Me.Inst_oboektijd6_txt.Size = New System.Drawing.Size(55, 20)
        Me.Inst_oboektijd6_txt.TabIndex = 29
        '
        'Inst_odag6_ud
        '
        Me.Inst_odag6_ud.Location = New System.Drawing.Point(166, 175)
        Me.Inst_odag6_ud.Maximum = New Decimal(New Integer() {7, 0, 0, 0})
        Me.Inst_odag6_ud.Minimum = New Decimal(New Integer() {7, 0, 0, -2147483648})
        Me.Inst_odag6_ud.Name = "Inst_odag6_ud"
        Me.Inst_odag6_ud.Size = New System.Drawing.Size(44, 20)
        Me.Inst_odag6_ud.TabIndex = 28
        '
        'Inst_o6_chk
        '
        Me.Inst_o6_chk.AutoSize = True
        Me.Inst_o6_chk.Location = New System.Drawing.Point(13, 177)
        Me.Inst_o6_chk.Name = "Inst_o6_chk"
        Me.Inst_o6_chk.Size = New System.Drawing.Size(35, 17)
        Me.Inst_o6_chk.TabIndex = 27
        Me.Inst_o6_chk.Text = " <"
        Me.Inst_o6_chk.UseVisualStyleBackColor = True
        '
        'Inst_ochktijd6_txt
        '
        Me.Inst_ochktijd6_txt.Location = New System.Drawing.Point(54, 175)
        Me.Inst_ochktijd6_txt.Name = "Inst_ochktijd6_txt"
        Me.Inst_ochktijd6_txt.Size = New System.Drawing.Size(55, 20)
        Me.Inst_ochktijd6_txt.TabIndex = 26
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(115, 153)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(16, 13)
        Me.Label39.TabIndex = 25
        Me.Label39.Text = "->"
        '
        'Inst_oboektijd5_txt
        '
        Me.Inst_oboektijd5_txt.Location = New System.Drawing.Point(216, 150)
        Me.Inst_oboektijd5_txt.Name = "Inst_oboektijd5_txt"
        Me.Inst_oboektijd5_txt.Size = New System.Drawing.Size(55, 20)
        Me.Inst_oboektijd5_txt.TabIndex = 24
        '
        'Inst_odag5_ud
        '
        Me.Inst_odag5_ud.Location = New System.Drawing.Point(166, 149)
        Me.Inst_odag5_ud.Maximum = New Decimal(New Integer() {7, 0, 0, 0})
        Me.Inst_odag5_ud.Minimum = New Decimal(New Integer() {7, 0, 0, -2147483648})
        Me.Inst_odag5_ud.Name = "Inst_odag5_ud"
        Me.Inst_odag5_ud.Size = New System.Drawing.Size(44, 20)
        Me.Inst_odag5_ud.TabIndex = 23
        '
        'Inst_o5_chk
        '
        Me.Inst_o5_chk.AutoSize = True
        Me.Inst_o5_chk.Location = New System.Drawing.Point(13, 151)
        Me.Inst_o5_chk.Name = "Inst_o5_chk"
        Me.Inst_o5_chk.Size = New System.Drawing.Size(35, 17)
        Me.Inst_o5_chk.TabIndex = 22
        Me.Inst_o5_chk.Text = " <"
        Me.Inst_o5_chk.UseVisualStyleBackColor = True
        '
        'Inst_ochktijd5_txt
        '
        Me.Inst_ochktijd5_txt.Location = New System.Drawing.Point(54, 149)
        Me.Inst_ochktijd5_txt.Name = "Inst_ochktijd5_txt"
        Me.Inst_ochktijd5_txt.Size = New System.Drawing.Size(55, 20)
        Me.Inst_ochktijd5_txt.TabIndex = 21
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(115, 127)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(16, 13)
        Me.Label40.TabIndex = 20
        Me.Label40.Text = "->"
        '
        'Inst_oboektijd4_txt
        '
        Me.Inst_oboektijd4_txt.Location = New System.Drawing.Point(216, 124)
        Me.Inst_oboektijd4_txt.Name = "Inst_oboektijd4_txt"
        Me.Inst_oboektijd4_txt.Size = New System.Drawing.Size(55, 20)
        Me.Inst_oboektijd4_txt.TabIndex = 19
        '
        'Inst_odag4_ud
        '
        Me.Inst_odag4_ud.Location = New System.Drawing.Point(166, 123)
        Me.Inst_odag4_ud.Maximum = New Decimal(New Integer() {7, 0, 0, 0})
        Me.Inst_odag4_ud.Minimum = New Decimal(New Integer() {7, 0, 0, -2147483648})
        Me.Inst_odag4_ud.Name = "Inst_odag4_ud"
        Me.Inst_odag4_ud.Size = New System.Drawing.Size(44, 20)
        Me.Inst_odag4_ud.TabIndex = 18
        '
        'Inst_o4_chk
        '
        Me.Inst_o4_chk.AutoSize = True
        Me.Inst_o4_chk.Location = New System.Drawing.Point(13, 125)
        Me.Inst_o4_chk.Name = "Inst_o4_chk"
        Me.Inst_o4_chk.Size = New System.Drawing.Size(35, 17)
        Me.Inst_o4_chk.TabIndex = 17
        Me.Inst_o4_chk.Text = " <"
        Me.Inst_o4_chk.UseVisualStyleBackColor = True
        '
        'Inst_ochktijd4_txt
        '
        Me.Inst_ochktijd4_txt.Location = New System.Drawing.Point(54, 123)
        Me.Inst_ochktijd4_txt.Name = "Inst_ochktijd4_txt"
        Me.Inst_ochktijd4_txt.Size = New System.Drawing.Size(55, 20)
        Me.Inst_ochktijd4_txt.TabIndex = 16
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(115, 101)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(16, 13)
        Me.Label41.TabIndex = 15
        Me.Label41.Text = "->"
        '
        'Inst_oboektijd3_txt
        '
        Me.Inst_oboektijd3_txt.Location = New System.Drawing.Point(216, 98)
        Me.Inst_oboektijd3_txt.Name = "Inst_oboektijd3_txt"
        Me.Inst_oboektijd3_txt.Size = New System.Drawing.Size(55, 20)
        Me.Inst_oboektijd3_txt.TabIndex = 14
        '
        'Inst_odag3_ud
        '
        Me.Inst_odag3_ud.Location = New System.Drawing.Point(166, 97)
        Me.Inst_odag3_ud.Maximum = New Decimal(New Integer() {7, 0, 0, 0})
        Me.Inst_odag3_ud.Minimum = New Decimal(New Integer() {7, 0, 0, -2147483648})
        Me.Inst_odag3_ud.Name = "Inst_odag3_ud"
        Me.Inst_odag3_ud.Size = New System.Drawing.Size(44, 20)
        Me.Inst_odag3_ud.TabIndex = 13
        '
        'Inst_o3_chk
        '
        Me.Inst_o3_chk.AutoSize = True
        Me.Inst_o3_chk.Location = New System.Drawing.Point(13, 99)
        Me.Inst_o3_chk.Name = "Inst_o3_chk"
        Me.Inst_o3_chk.Size = New System.Drawing.Size(35, 17)
        Me.Inst_o3_chk.TabIndex = 12
        Me.Inst_o3_chk.Text = " <"
        Me.Inst_o3_chk.UseVisualStyleBackColor = True
        '
        'Inst_ochktijd3_txt
        '
        Me.Inst_ochktijd3_txt.Location = New System.Drawing.Point(54, 97)
        Me.Inst_ochktijd3_txt.Name = "Inst_ochktijd3_txt"
        Me.Inst_ochktijd3_txt.Size = New System.Drawing.Size(55, 20)
        Me.Inst_ochktijd3_txt.TabIndex = 11
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(115, 75)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(16, 13)
        Me.Label42.TabIndex = 10
        Me.Label42.Text = "->"
        '
        'Inst_oboektijd2_txt
        '
        Me.Inst_oboektijd2_txt.Location = New System.Drawing.Point(216, 72)
        Me.Inst_oboektijd2_txt.Name = "Inst_oboektijd2_txt"
        Me.Inst_oboektijd2_txt.Size = New System.Drawing.Size(55, 20)
        Me.Inst_oboektijd2_txt.TabIndex = 9
        '
        'Inst_odag2_ud
        '
        Me.Inst_odag2_ud.Location = New System.Drawing.Point(166, 71)
        Me.Inst_odag2_ud.Maximum = New Decimal(New Integer() {7, 0, 0, 0})
        Me.Inst_odag2_ud.Minimum = New Decimal(New Integer() {7, 0, 0, -2147483648})
        Me.Inst_odag2_ud.Name = "Inst_odag2_ud"
        Me.Inst_odag2_ud.Size = New System.Drawing.Size(44, 20)
        Me.Inst_odag2_ud.TabIndex = 8
        '
        'Inst_o2_chk
        '
        Me.Inst_o2_chk.AutoSize = True
        Me.Inst_o2_chk.Location = New System.Drawing.Point(13, 73)
        Me.Inst_o2_chk.Name = "Inst_o2_chk"
        Me.Inst_o2_chk.Size = New System.Drawing.Size(35, 17)
        Me.Inst_o2_chk.TabIndex = 7
        Me.Inst_o2_chk.Text = " <"
        Me.Inst_o2_chk.UseVisualStyleBackColor = True
        '
        'Inst_ochktijd2_txt
        '
        Me.Inst_ochktijd2_txt.Location = New System.Drawing.Point(54, 71)
        Me.Inst_ochktijd2_txt.Name = "Inst_ochktijd2_txt"
        Me.Inst_ochktijd2_txt.Size = New System.Drawing.Size(55, 20)
        Me.Inst_ochktijd2_txt.TabIndex = 6
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(115, 46)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(16, 13)
        Me.Label43.TabIndex = 5
        Me.Label43.Text = "->"
        '
        'Inst_oboektijd1_txt
        '
        Me.Inst_oboektijd1_txt.Location = New System.Drawing.Point(216, 43)
        Me.Inst_oboektijd1_txt.Name = "Inst_oboektijd1_txt"
        Me.Inst_oboektijd1_txt.Size = New System.Drawing.Size(55, 20)
        Me.Inst_oboektijd1_txt.TabIndex = 4
        '
        'Inst_odag1_ud
        '
        Me.Inst_odag1_ud.Location = New System.Drawing.Point(166, 42)
        Me.Inst_odag1_ud.Maximum = New Decimal(New Integer() {7, 0, 0, 0})
        Me.Inst_odag1_ud.Minimum = New Decimal(New Integer() {7, 0, 0, -2147483648})
        Me.Inst_odag1_ud.Name = "Inst_odag1_ud"
        Me.Inst_odag1_ud.Size = New System.Drawing.Size(44, 20)
        Me.Inst_odag1_ud.TabIndex = 3
        '
        'Inst_o1_chk
        '
        Me.Inst_o1_chk.AutoSize = True
        Me.Inst_o1_chk.Location = New System.Drawing.Point(13, 44)
        Me.Inst_o1_chk.Name = "Inst_o1_chk"
        Me.Inst_o1_chk.Size = New System.Drawing.Size(35, 17)
        Me.Inst_o1_chk.TabIndex = 2
        Me.Inst_o1_chk.Text = " <"
        Me.Inst_o1_chk.UseVisualStyleBackColor = True
        '
        'Inst_ochktijd1_txt
        '
        Me.Inst_ochktijd1_txt.Location = New System.Drawing.Point(54, 42)
        Me.Inst_ochktijd1_txt.Name = "Inst_ochktijd1_txt"
        Me.Inst_ochktijd1_txt.Size = New System.Drawing.Size(55, 20)
        Me.Inst_ochktijd1_txt.TabIndex = 0
        '
        'Inst_Vervoer_annuleren_but
        '
        Me.Inst_Vervoer_annuleren_but.Enabled = False
        Me.Inst_Vervoer_annuleren_but.Location = New System.Drawing.Point(524, 494)
        Me.Inst_Vervoer_annuleren_but.Name = "Inst_Vervoer_annuleren_but"
        Me.Inst_Vervoer_annuleren_but.Size = New System.Drawing.Size(96, 27)
        Me.Inst_Vervoer_annuleren_but.TabIndex = 45
        Me.Inst_Vervoer_annuleren_but.Text = "Annuleren"
        Me.Inst_Vervoer_annuleren_but.UseVisualStyleBackColor = True
        '
        'Inst_Vervoer_opslaan_but
        '
        Me.Inst_Vervoer_opslaan_but.Enabled = False
        Me.Inst_Vervoer_opslaan_but.Location = New System.Drawing.Point(422, 494)
        Me.Inst_Vervoer_opslaan_but.Name = "Inst_Vervoer_opslaan_but"
        Me.Inst_Vervoer_opslaan_but.Size = New System.Drawing.Size(96, 27)
        Me.Inst_Vervoer_opslaan_but.TabIndex = 44
        Me.Inst_Vervoer_opslaan_but.Text = "Opslaan"
        Me.Inst_Vervoer_opslaan_but.UseVisualStyleBackColor = True
        '
        'Inst_Westland_GB
        '
        Me.Inst_Westland_GB.Controls.Add(Me.Label33)
        Me.Inst_Westland_GB.Controls.Add(Me.Label32)
        Me.Inst_Westland_GB.Controls.Add(Me.Label31)
        Me.Inst_Westland_GB.Controls.Add(Me.Label30)
        Me.Inst_Westland_GB.Controls.Add(Me.Inst_wboektijd7_txt)
        Me.Inst_Westland_GB.Controls.Add(Me.Inst_wdag7_ud)
        Me.Inst_Westland_GB.Controls.Add(Me.Inst_w7_chk)
        Me.Inst_Westland_GB.Controls.Add(Me.Inst_wchktijd7_txt)
        Me.Inst_Westland_GB.Controls.Add(Me.Label29)
        Me.Inst_Westland_GB.Controls.Add(Me.Inst_wboektijd6_txt)
        Me.Inst_Westland_GB.Controls.Add(Me.Inst_wdag6_ud)
        Me.Inst_Westland_GB.Controls.Add(Me.Inst_w6_chk)
        Me.Inst_Westland_GB.Controls.Add(Me.Inst_wchktijd6_txt)
        Me.Inst_Westland_GB.Controls.Add(Me.Label28)
        Me.Inst_Westland_GB.Controls.Add(Me.Inst_wboektijd5_txt)
        Me.Inst_Westland_GB.Controls.Add(Me.Inst_wdag5_ud)
        Me.Inst_Westland_GB.Controls.Add(Me.Inst_w5_chk)
        Me.Inst_Westland_GB.Controls.Add(Me.Inst_wchktijd5_txt)
        Me.Inst_Westland_GB.Controls.Add(Me.Label27)
        Me.Inst_Westland_GB.Controls.Add(Me.Inst_wboektijd4_txt)
        Me.Inst_Westland_GB.Controls.Add(Me.Inst_wdag4_ud)
        Me.Inst_Westland_GB.Controls.Add(Me.Inst_w4_chk)
        Me.Inst_Westland_GB.Controls.Add(Me.Inst_wchktijd4_txt)
        Me.Inst_Westland_GB.Controls.Add(Me.Label26)
        Me.Inst_Westland_GB.Controls.Add(Me.Inst_wboektijd3_txt)
        Me.Inst_Westland_GB.Controls.Add(Me.Inst_wdag3_ud)
        Me.Inst_Westland_GB.Controls.Add(Me.Inst_w3_chk)
        Me.Inst_Westland_GB.Controls.Add(Me.Inst_wchktijd3_txt)
        Me.Inst_Westland_GB.Controls.Add(Me.Label25)
        Me.Inst_Westland_GB.Controls.Add(Me.Inst_wboektijd2_txt)
        Me.Inst_Westland_GB.Controls.Add(Me.Inst_wdag2_ud)
        Me.Inst_Westland_GB.Controls.Add(Me.Inst_w2_chk)
        Me.Inst_Westland_GB.Controls.Add(Me.Inst_wchktijd2_txt)
        Me.Inst_Westland_GB.Controls.Add(Me.Label24)
        Me.Inst_Westland_GB.Controls.Add(Me.Inst_wboektijd1_txt)
        Me.Inst_Westland_GB.Controls.Add(Me.Inst_wdag1_ud)
        Me.Inst_Westland_GB.Controls.Add(Me.Inst_w1_chk)
        Me.Inst_Westland_GB.Controls.Add(Me.Inst_wchktijd1_txt)
        Me.Inst_Westland_GB.Enabled = False
        Me.Inst_Westland_GB.Location = New System.Drawing.Point(26, 543)
        Me.Inst_Westland_GB.Name = "Inst_Westland_GB"
        Me.Inst_Westland_GB.Size = New System.Drawing.Size(300, 264)
        Me.Inst_Westland_GB.TabIndex = 43
        Me.Inst_Westland_GB.TabStop = False
        Me.Inst_Westland_GB.Text = "Westland"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(229, 25)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(24, 13)
        Me.Label33.TabIndex = 38
        Me.Label33.Text = "Tijd"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(165, 24)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(39, 13)
        Me.Label32.TabIndex = 37
        Me.Label32.Text = "Dagen"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(57, 25)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(24, 13)
        Me.Label31.TabIndex = 36
        Me.Label31.Text = "Tijd"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(115, 205)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(16, 13)
        Me.Label30.TabIndex = 35
        Me.Label30.Text = "->"
        '
        'Inst_wboektijd7_txt
        '
        Me.Inst_wboektijd7_txt.Location = New System.Drawing.Point(216, 202)
        Me.Inst_wboektijd7_txt.Name = "Inst_wboektijd7_txt"
        Me.Inst_wboektijd7_txt.Size = New System.Drawing.Size(55, 20)
        Me.Inst_wboektijd7_txt.TabIndex = 34
        '
        'Inst_wdag7_ud
        '
        Me.Inst_wdag7_ud.Location = New System.Drawing.Point(166, 201)
        Me.Inst_wdag7_ud.Maximum = New Decimal(New Integer() {7, 0, 0, 0})
        Me.Inst_wdag7_ud.Minimum = New Decimal(New Integer() {7, 0, 0, -2147483648})
        Me.Inst_wdag7_ud.Name = "Inst_wdag7_ud"
        Me.Inst_wdag7_ud.Size = New System.Drawing.Size(44, 20)
        Me.Inst_wdag7_ud.TabIndex = 33
        '
        'Inst_w7_chk
        '
        Me.Inst_w7_chk.AutoSize = True
        Me.Inst_w7_chk.Location = New System.Drawing.Point(13, 203)
        Me.Inst_w7_chk.Name = "Inst_w7_chk"
        Me.Inst_w7_chk.Size = New System.Drawing.Size(35, 17)
        Me.Inst_w7_chk.TabIndex = 32
        Me.Inst_w7_chk.Text = " <"
        Me.Inst_w7_chk.UseVisualStyleBackColor = True
        '
        'Inst_wchktijd7_txt
        '
        Me.Inst_wchktijd7_txt.Location = New System.Drawing.Point(54, 201)
        Me.Inst_wchktijd7_txt.Name = "Inst_wchktijd7_txt"
        Me.Inst_wchktijd7_txt.Size = New System.Drawing.Size(55, 20)
        Me.Inst_wchktijd7_txt.TabIndex = 31
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(115, 179)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(16, 13)
        Me.Label29.TabIndex = 30
        Me.Label29.Text = "->"
        '
        'Inst_wboektijd6_txt
        '
        Me.Inst_wboektijd6_txt.Location = New System.Drawing.Point(216, 176)
        Me.Inst_wboektijd6_txt.Name = "Inst_wboektijd6_txt"
        Me.Inst_wboektijd6_txt.Size = New System.Drawing.Size(55, 20)
        Me.Inst_wboektijd6_txt.TabIndex = 29
        '
        'Inst_wdag6_ud
        '
        Me.Inst_wdag6_ud.Location = New System.Drawing.Point(166, 175)
        Me.Inst_wdag6_ud.Maximum = New Decimal(New Integer() {7, 0, 0, 0})
        Me.Inst_wdag6_ud.Minimum = New Decimal(New Integer() {7, 0, 0, -2147483648})
        Me.Inst_wdag6_ud.Name = "Inst_wdag6_ud"
        Me.Inst_wdag6_ud.Size = New System.Drawing.Size(44, 20)
        Me.Inst_wdag6_ud.TabIndex = 28
        '
        'Inst_w6_chk
        '
        Me.Inst_w6_chk.AutoSize = True
        Me.Inst_w6_chk.Location = New System.Drawing.Point(13, 177)
        Me.Inst_w6_chk.Name = "Inst_w6_chk"
        Me.Inst_w6_chk.Size = New System.Drawing.Size(35, 17)
        Me.Inst_w6_chk.TabIndex = 27
        Me.Inst_w6_chk.Text = " <"
        Me.Inst_w6_chk.UseVisualStyleBackColor = True
        '
        'Inst_wchktijd6_txt
        '
        Me.Inst_wchktijd6_txt.Location = New System.Drawing.Point(54, 175)
        Me.Inst_wchktijd6_txt.Name = "Inst_wchktijd6_txt"
        Me.Inst_wchktijd6_txt.Size = New System.Drawing.Size(55, 20)
        Me.Inst_wchktijd6_txt.TabIndex = 26
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(115, 153)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(16, 13)
        Me.Label28.TabIndex = 25
        Me.Label28.Text = "->"
        '
        'Inst_wboektijd5_txt
        '
        Me.Inst_wboektijd5_txt.Location = New System.Drawing.Point(216, 150)
        Me.Inst_wboektijd5_txt.Name = "Inst_wboektijd5_txt"
        Me.Inst_wboektijd5_txt.Size = New System.Drawing.Size(55, 20)
        Me.Inst_wboektijd5_txt.TabIndex = 24
        '
        'Inst_wdag5_ud
        '
        Me.Inst_wdag5_ud.Location = New System.Drawing.Point(166, 149)
        Me.Inst_wdag5_ud.Maximum = New Decimal(New Integer() {7, 0, 0, 0})
        Me.Inst_wdag5_ud.Minimum = New Decimal(New Integer() {7, 0, 0, -2147483648})
        Me.Inst_wdag5_ud.Name = "Inst_wdag5_ud"
        Me.Inst_wdag5_ud.Size = New System.Drawing.Size(44, 20)
        Me.Inst_wdag5_ud.TabIndex = 23
        '
        'Inst_w5_chk
        '
        Me.Inst_w5_chk.AutoSize = True
        Me.Inst_w5_chk.Location = New System.Drawing.Point(13, 151)
        Me.Inst_w5_chk.Name = "Inst_w5_chk"
        Me.Inst_w5_chk.Size = New System.Drawing.Size(35, 17)
        Me.Inst_w5_chk.TabIndex = 22
        Me.Inst_w5_chk.Text = " <"
        Me.Inst_w5_chk.UseVisualStyleBackColor = True
        '
        'Inst_wchktijd5_txt
        '
        Me.Inst_wchktijd5_txt.Location = New System.Drawing.Point(54, 149)
        Me.Inst_wchktijd5_txt.Name = "Inst_wchktijd5_txt"
        Me.Inst_wchktijd5_txt.Size = New System.Drawing.Size(55, 20)
        Me.Inst_wchktijd5_txt.TabIndex = 21
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(115, 127)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(16, 13)
        Me.Label27.TabIndex = 20
        Me.Label27.Text = "->"
        '
        'Inst_wboektijd4_txt
        '
        Me.Inst_wboektijd4_txt.Location = New System.Drawing.Point(216, 124)
        Me.Inst_wboektijd4_txt.Name = "Inst_wboektijd4_txt"
        Me.Inst_wboektijd4_txt.Size = New System.Drawing.Size(55, 20)
        Me.Inst_wboektijd4_txt.TabIndex = 19
        '
        'Inst_wdag4_ud
        '
        Me.Inst_wdag4_ud.Location = New System.Drawing.Point(166, 123)
        Me.Inst_wdag4_ud.Maximum = New Decimal(New Integer() {7, 0, 0, 0})
        Me.Inst_wdag4_ud.Minimum = New Decimal(New Integer() {7, 0, 0, -2147483648})
        Me.Inst_wdag4_ud.Name = "Inst_wdag4_ud"
        Me.Inst_wdag4_ud.Size = New System.Drawing.Size(44, 20)
        Me.Inst_wdag4_ud.TabIndex = 18
        '
        'Inst_w4_chk
        '
        Me.Inst_w4_chk.AutoSize = True
        Me.Inst_w4_chk.Location = New System.Drawing.Point(13, 125)
        Me.Inst_w4_chk.Name = "Inst_w4_chk"
        Me.Inst_w4_chk.Size = New System.Drawing.Size(35, 17)
        Me.Inst_w4_chk.TabIndex = 17
        Me.Inst_w4_chk.Text = " <"
        Me.Inst_w4_chk.UseVisualStyleBackColor = True
        '
        'Inst_wchktijd4_txt
        '
        Me.Inst_wchktijd4_txt.Location = New System.Drawing.Point(54, 123)
        Me.Inst_wchktijd4_txt.Name = "Inst_wchktijd4_txt"
        Me.Inst_wchktijd4_txt.Size = New System.Drawing.Size(55, 20)
        Me.Inst_wchktijd4_txt.TabIndex = 16
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(115, 101)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(16, 13)
        Me.Label26.TabIndex = 15
        Me.Label26.Text = "->"
        '
        'Inst_wboektijd3_txt
        '
        Me.Inst_wboektijd3_txt.Location = New System.Drawing.Point(216, 98)
        Me.Inst_wboektijd3_txt.Name = "Inst_wboektijd3_txt"
        Me.Inst_wboektijd3_txt.Size = New System.Drawing.Size(55, 20)
        Me.Inst_wboektijd3_txt.TabIndex = 14
        '
        'Inst_wdag3_ud
        '
        Me.Inst_wdag3_ud.Location = New System.Drawing.Point(166, 97)
        Me.Inst_wdag3_ud.Maximum = New Decimal(New Integer() {7, 0, 0, 0})
        Me.Inst_wdag3_ud.Minimum = New Decimal(New Integer() {7, 0, 0, -2147483648})
        Me.Inst_wdag3_ud.Name = "Inst_wdag3_ud"
        Me.Inst_wdag3_ud.Size = New System.Drawing.Size(44, 20)
        Me.Inst_wdag3_ud.TabIndex = 13
        '
        'Inst_w3_chk
        '
        Me.Inst_w3_chk.AutoSize = True
        Me.Inst_w3_chk.Location = New System.Drawing.Point(13, 99)
        Me.Inst_w3_chk.Name = "Inst_w3_chk"
        Me.Inst_w3_chk.Size = New System.Drawing.Size(35, 17)
        Me.Inst_w3_chk.TabIndex = 12
        Me.Inst_w3_chk.Text = " <"
        Me.Inst_w3_chk.UseVisualStyleBackColor = True
        '
        'Inst_wchktijd3_txt
        '
        Me.Inst_wchktijd3_txt.Location = New System.Drawing.Point(54, 97)
        Me.Inst_wchktijd3_txt.Name = "Inst_wchktijd3_txt"
        Me.Inst_wchktijd3_txt.Size = New System.Drawing.Size(55, 20)
        Me.Inst_wchktijd3_txt.TabIndex = 11
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(115, 75)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(16, 13)
        Me.Label25.TabIndex = 10
        Me.Label25.Text = "->"
        '
        'Inst_wboektijd2_txt
        '
        Me.Inst_wboektijd2_txt.Location = New System.Drawing.Point(216, 72)
        Me.Inst_wboektijd2_txt.Name = "Inst_wboektijd2_txt"
        Me.Inst_wboektijd2_txt.Size = New System.Drawing.Size(55, 20)
        Me.Inst_wboektijd2_txt.TabIndex = 9
        '
        'Inst_wdag2_ud
        '
        Me.Inst_wdag2_ud.Location = New System.Drawing.Point(166, 71)
        Me.Inst_wdag2_ud.Maximum = New Decimal(New Integer() {7, 0, 0, 0})
        Me.Inst_wdag2_ud.Minimum = New Decimal(New Integer() {7, 0, 0, -2147483648})
        Me.Inst_wdag2_ud.Name = "Inst_wdag2_ud"
        Me.Inst_wdag2_ud.Size = New System.Drawing.Size(44, 20)
        Me.Inst_wdag2_ud.TabIndex = 8
        '
        'Inst_w2_chk
        '
        Me.Inst_w2_chk.AutoSize = True
        Me.Inst_w2_chk.Location = New System.Drawing.Point(13, 73)
        Me.Inst_w2_chk.Name = "Inst_w2_chk"
        Me.Inst_w2_chk.Size = New System.Drawing.Size(35, 17)
        Me.Inst_w2_chk.TabIndex = 7
        Me.Inst_w2_chk.Text = " <"
        Me.Inst_w2_chk.UseVisualStyleBackColor = True
        '
        'Inst_wchktijd2_txt
        '
        Me.Inst_wchktijd2_txt.Location = New System.Drawing.Point(54, 71)
        Me.Inst_wchktijd2_txt.Name = "Inst_wchktijd2_txt"
        Me.Inst_wchktijd2_txt.Size = New System.Drawing.Size(55, 20)
        Me.Inst_wchktijd2_txt.TabIndex = 6
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(115, 46)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(16, 13)
        Me.Label24.TabIndex = 5
        Me.Label24.Text = "->"
        '
        'Inst_wboektijd1_txt
        '
        Me.Inst_wboektijd1_txt.Location = New System.Drawing.Point(216, 43)
        Me.Inst_wboektijd1_txt.Name = "Inst_wboektijd1_txt"
        Me.Inst_wboektijd1_txt.Size = New System.Drawing.Size(55, 20)
        Me.Inst_wboektijd1_txt.TabIndex = 4
        '
        'Inst_wdag1_ud
        '
        Me.Inst_wdag1_ud.Location = New System.Drawing.Point(166, 42)
        Me.Inst_wdag1_ud.Maximum = New Decimal(New Integer() {7, 0, 0, 0})
        Me.Inst_wdag1_ud.Minimum = New Decimal(New Integer() {7, 0, 0, -2147483648})
        Me.Inst_wdag1_ud.Name = "Inst_wdag1_ud"
        Me.Inst_wdag1_ud.Size = New System.Drawing.Size(44, 20)
        Me.Inst_wdag1_ud.TabIndex = 3
        '
        'Inst_w1_chk
        '
        Me.Inst_w1_chk.AutoSize = True
        Me.Inst_w1_chk.Location = New System.Drawing.Point(13, 44)
        Me.Inst_w1_chk.Name = "Inst_w1_chk"
        Me.Inst_w1_chk.Size = New System.Drawing.Size(35, 17)
        Me.Inst_w1_chk.TabIndex = 2
        Me.Inst_w1_chk.Text = " <"
        Me.Inst_w1_chk.UseVisualStyleBackColor = True
        '
        'Inst_wchktijd1_txt
        '
        Me.Inst_wchktijd1_txt.Location = New System.Drawing.Point(54, 42)
        Me.Inst_wchktijd1_txt.Name = "Inst_wchktijd1_txt"
        Me.Inst_wchktijd1_txt.Size = New System.Drawing.Size(55, 20)
        Me.Inst_wchktijd1_txt.TabIndex = 0
        '
        'Inst_Vervoer_aanpassen_but
        '
        Me.Inst_Vervoer_aanpassen_but.Location = New System.Drawing.Point(320, 494)
        Me.Inst_Vervoer_aanpassen_but.Name = "Inst_Vervoer_aanpassen_but"
        Me.Inst_Vervoer_aanpassen_but.Size = New System.Drawing.Size(96, 27)
        Me.Inst_Vervoer_aanpassen_but.TabIndex = 42
        Me.Inst_Vervoer_aanpassen_but.Text = "Aanpassen"
        Me.Inst_Vervoer_aanpassen_but.UseVisualStyleBackColor = True
        '
        'Inst_dag_lbl
        '
        Me.Inst_dag_lbl.AutoSize = True
        Me.Inst_dag_lbl.Location = New System.Drawing.Point(25, 503)
        Me.Inst_dag_lbl.Name = "Inst_dag_lbl"
        Me.Inst_dag_lbl.Size = New System.Drawing.Size(27, 13)
        Me.Inst_dag_lbl.TabIndex = 41
        Me.Inst_dag_lbl.Text = "Dag"
        '
        'Inst_vervoerstijden_lbl
        '
        Me.Inst_vervoerstijden_lbl.AutoSize = True
        Me.Inst_vervoerstijden_lbl.Location = New System.Drawing.Point(25, 474)
        Me.Inst_vervoerstijden_lbl.Name = "Inst_vervoerstijden_lbl"
        Me.Inst_vervoerstijden_lbl.Size = New System.Drawing.Size(74, 13)
        Me.Inst_vervoerstijden_lbl.TabIndex = 40
        Me.Inst_vervoerstijden_lbl.Text = "Vervoerstijden"
        '
        'Inst_weekdag_cmb
        '
        Me.Inst_weekdag_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Inst_weekdag_cmb.FormattingEnabled = True
        Me.Inst_weekdag_cmb.Items.AddRange(New Object() {"Selecteer dag", "Maandag", "Dinsdag", "Woensdag", "Donderdag", "Vrijdag", "Zaterdag", "Zondag"})
        Me.Inst_weekdag_cmb.Location = New System.Drawing.Point(134, 500)
        Me.Inst_weekdag_cmb.Name = "Inst_weekdag_cmb"
        Me.Inst_weekdag_cmb.Size = New System.Drawing.Size(176, 21)
        Me.Inst_weekdag_cmb.TabIndex = 39
        '
        'Inst_barcodeserver
        '
        Me.Inst_barcodeserver.AutoSize = True
        Me.Inst_barcodeserver.Location = New System.Drawing.Point(133, 129)
        Me.Inst_barcodeserver.Name = "Inst_barcodeserver"
        Me.Inst_barcodeserver.Size = New System.Drawing.Size(125, 17)
        Me.Inst_barcodeserver.TabIndex = 38
        Me.Inst_barcodeserver.Text = "Barcode ScanServer"
        Me.Inst_barcodeserver.UseVisualStyleBackColor = True
        '
        'Inst_Login8_v1_chk
        '
        Me.Inst_Login8_v1_chk.AutoSize = True
        Me.Inst_Login8_v1_chk.Location = New System.Drawing.Point(387, 380)
        Me.Inst_Login8_v1_chk.Name = "Inst_Login8_v1_chk"
        Me.Inst_Login8_v1_chk.Size = New System.Drawing.Size(15, 14)
        Me.Inst_Login8_v1_chk.TabIndex = 33
        Me.Inst_Login8_v1_chk.UseVisualStyleBackColor = True
        '
        'Inst_Login7_v1_chk
        '
        Me.Inst_Login7_v1_chk.AutoSize = True
        Me.Inst_Login7_v1_chk.Location = New System.Drawing.Point(387, 354)
        Me.Inst_Login7_v1_chk.Name = "Inst_Login7_v1_chk"
        Me.Inst_Login7_v1_chk.Size = New System.Drawing.Size(15, 14)
        Me.Inst_Login7_v1_chk.TabIndex = 32
        Me.Inst_Login7_v1_chk.UseVisualStyleBackColor = True
        '
        'Inst_Login6_v1_chk
        '
        Me.Inst_Login6_v1_chk.AutoSize = True
        Me.Inst_Login6_v1_chk.Location = New System.Drawing.Point(387, 329)
        Me.Inst_Login6_v1_chk.Name = "Inst_Login6_v1_chk"
        Me.Inst_Login6_v1_chk.Size = New System.Drawing.Size(15, 14)
        Me.Inst_Login6_v1_chk.TabIndex = 31
        Me.Inst_Login6_v1_chk.UseVisualStyleBackColor = True
        '
        'Inst_Login5_v1_chk
        '
        Me.Inst_Login5_v1_chk.AutoSize = True
        Me.Inst_Login5_v1_chk.Location = New System.Drawing.Point(387, 303)
        Me.Inst_Login5_v1_chk.Name = "Inst_Login5_v1_chk"
        Me.Inst_Login5_v1_chk.Size = New System.Drawing.Size(15, 14)
        Me.Inst_Login5_v1_chk.TabIndex = 30
        Me.Inst_Login5_v1_chk.UseVisualStyleBackColor = True
        '
        'Inst_Login4_v1_chk
        '
        Me.Inst_Login4_v1_chk.AutoSize = True
        Me.Inst_Login4_v1_chk.Location = New System.Drawing.Point(387, 277)
        Me.Inst_Login4_v1_chk.Name = "Inst_Login4_v1_chk"
        Me.Inst_Login4_v1_chk.Size = New System.Drawing.Size(15, 14)
        Me.Inst_Login4_v1_chk.TabIndex = 29
        Me.Inst_Login4_v1_chk.UseVisualStyleBackColor = True
        '
        'Inst_Login3_v1_chk
        '
        Me.Inst_Login3_v1_chk.AutoSize = True
        Me.Inst_Login3_v1_chk.Location = New System.Drawing.Point(387, 251)
        Me.Inst_Login3_v1_chk.Name = "Inst_Login3_v1_chk"
        Me.Inst_Login3_v1_chk.Size = New System.Drawing.Size(15, 14)
        Me.Inst_Login3_v1_chk.TabIndex = 28
        Me.Inst_Login3_v1_chk.UseVisualStyleBackColor = True
        '
        'Inst_Login2_v1_chk
        '
        Me.Inst_Login2_v1_chk.AutoSize = True
        Me.Inst_Login2_v1_chk.Location = New System.Drawing.Point(387, 225)
        Me.Inst_Login2_v1_chk.Name = "Inst_Login2_v1_chk"
        Me.Inst_Login2_v1_chk.Size = New System.Drawing.Size(15, 14)
        Me.Inst_Login2_v1_chk.TabIndex = 27
        Me.Inst_Login2_v1_chk.UseVisualStyleBackColor = True
        '
        'Inst_Login1_v1_chk
        '
        Me.Inst_Login1_v1_chk.AutoSize = True
        Me.Inst_Login1_v1_chk.Location = New System.Drawing.Point(387, 198)
        Me.Inst_Login1_v1_chk.Name = "Inst_Login1_v1_chk"
        Me.Inst_Login1_v1_chk.Size = New System.Drawing.Size(15, 14)
        Me.Inst_Login1_v1_chk.TabIndex = 26
        Me.Inst_Login1_v1_chk.UseVisualStyleBackColor = True
        '
        'Inst_test_server
        '
        Me.Inst_test_server.Location = New System.Drawing.Point(320, 25)
        Me.Inst_test_server.Name = "Inst_test_server"
        Me.Inst_test_server.Size = New System.Drawing.Size(84, 25)
        Me.Inst_test_server.TabIndex = 24
        Me.Inst_test_server.Text = "Test SQL server"
        Me.Inst_test_server.UseVisualStyleBackColor = True
        '
        'Inst_Login8_Txt
        '
        Me.Inst_Login8_Txt.Location = New System.Drawing.Point(133, 379)
        Me.Inst_Login8_Txt.Name = "Inst_Login8_Txt"
        Me.Inst_Login8_Txt.Size = New System.Drawing.Size(175, 20)
        Me.Inst_Login8_Txt.TabIndex = 23
        '
        'SettingsLogin8
        '
        Me.SettingsLogin8.AutoSize = True
        Me.SettingsLogin8.Location = New System.Drawing.Point(22, 382)
        Me.SettingsLogin8.Name = "SettingsLogin8"
        Me.SettingsLogin8.Size = New System.Drawing.Size(42, 13)
        Me.SettingsLogin8.TabIndex = 22
        Me.SettingsLogin8.Text = "Login 8"
        '
        'Inst_Login7_Txt
        '
        Me.Inst_Login7_Txt.Location = New System.Drawing.Point(133, 353)
        Me.Inst_Login7_Txt.Name = "Inst_Login7_Txt"
        Me.Inst_Login7_Txt.Size = New System.Drawing.Size(175, 20)
        Me.Inst_Login7_Txt.TabIndex = 21
        '
        'SettingsLogin7
        '
        Me.SettingsLogin7.AutoSize = True
        Me.SettingsLogin7.Location = New System.Drawing.Point(22, 356)
        Me.SettingsLogin7.Name = "SettingsLogin7"
        Me.SettingsLogin7.Size = New System.Drawing.Size(42, 13)
        Me.SettingsLogin7.TabIndex = 20
        Me.SettingsLogin7.Text = "Login 7"
        '
        'Inst_Login6_Txt
        '
        Me.Inst_Login6_Txt.Location = New System.Drawing.Point(133, 327)
        Me.Inst_Login6_Txt.Name = "Inst_Login6_Txt"
        Me.Inst_Login6_Txt.Size = New System.Drawing.Size(175, 20)
        Me.Inst_Login6_Txt.TabIndex = 19
        '
        'SettingsLogin6
        '
        Me.SettingsLogin6.AutoSize = True
        Me.SettingsLogin6.Location = New System.Drawing.Point(22, 330)
        Me.SettingsLogin6.Name = "SettingsLogin6"
        Me.SettingsLogin6.Size = New System.Drawing.Size(42, 13)
        Me.SettingsLogin6.TabIndex = 18
        Me.SettingsLogin6.Text = "Login 6"
        '
        'Inst_Login5_Txt
        '
        Me.Inst_Login5_Txt.Location = New System.Drawing.Point(134, 301)
        Me.Inst_Login5_Txt.Name = "Inst_Login5_Txt"
        Me.Inst_Login5_Txt.Size = New System.Drawing.Size(175, 20)
        Me.Inst_Login5_Txt.TabIndex = 17
        '
        'SettingsLogin5
        '
        Me.SettingsLogin5.AutoSize = True
        Me.SettingsLogin5.Location = New System.Drawing.Point(23, 304)
        Me.SettingsLogin5.Name = "SettingsLogin5"
        Me.SettingsLogin5.Size = New System.Drawing.Size(42, 13)
        Me.SettingsLogin5.TabIndex = 16
        Me.SettingsLogin5.Text = "Login 5"
        '
        'Inst_Login4_Txt
        '
        Me.Inst_Login4_Txt.Location = New System.Drawing.Point(134, 275)
        Me.Inst_Login4_Txt.Name = "Inst_Login4_Txt"
        Me.Inst_Login4_Txt.Size = New System.Drawing.Size(175, 20)
        Me.Inst_Login4_Txt.TabIndex = 15
        '
        'SettingsLogin4
        '
        Me.SettingsLogin4.AutoSize = True
        Me.SettingsLogin4.Location = New System.Drawing.Point(23, 278)
        Me.SettingsLogin4.Name = "SettingsLogin4"
        Me.SettingsLogin4.Size = New System.Drawing.Size(42, 13)
        Me.SettingsLogin4.TabIndex = 14
        Me.SettingsLogin4.Text = "Login 4"
        '
        'Inst_Login3_Txt
        '
        Me.Inst_Login3_Txt.Location = New System.Drawing.Point(134, 248)
        Me.Inst_Login3_Txt.Name = "Inst_Login3_Txt"
        Me.Inst_Login3_Txt.Size = New System.Drawing.Size(175, 20)
        Me.Inst_Login3_Txt.TabIndex = 13
        '
        'SettingsLogin3
        '
        Me.SettingsLogin3.AutoSize = True
        Me.SettingsLogin3.Location = New System.Drawing.Point(25, 252)
        Me.SettingsLogin3.Name = "SettingsLogin3"
        Me.SettingsLogin3.Size = New System.Drawing.Size(42, 13)
        Me.SettingsLogin3.TabIndex = 12
        Me.SettingsLogin3.Text = "Login 3"
        '
        'Inst_Login2_Txt
        '
        Me.Inst_Login2_Txt.Location = New System.Drawing.Point(134, 223)
        Me.Inst_Login2_Txt.Name = "Inst_Login2_Txt"
        Me.Inst_Login2_Txt.Size = New System.Drawing.Size(175, 20)
        Me.Inst_Login2_Txt.TabIndex = 11
        '
        'SettingsLogin2
        '
        Me.SettingsLogin2.AutoSize = True
        Me.SettingsLogin2.Location = New System.Drawing.Point(23, 226)
        Me.SettingsLogin2.Name = "SettingsLogin2"
        Me.SettingsLogin2.Size = New System.Drawing.Size(42, 13)
        Me.SettingsLogin2.TabIndex = 10
        Me.SettingsLogin2.Text = "Login 2"
        '
        'Inst_Login1_Txt
        '
        Me.Inst_Login1_Txt.Location = New System.Drawing.Point(134, 197)
        Me.Inst_Login1_Txt.Name = "Inst_Login1_Txt"
        Me.Inst_Login1_Txt.Size = New System.Drawing.Size(175, 20)
        Me.Inst_Login1_Txt.TabIndex = 9
        '
        'SettingsLogin1
        '
        Me.SettingsLogin1.AutoSize = True
        Me.SettingsLogin1.Location = New System.Drawing.Point(23, 200)
        Me.SettingsLogin1.Name = "SettingsLogin1"
        Me.SettingsLogin1.Size = New System.Drawing.Size(42, 13)
        Me.SettingsLogin1.TabIndex = 8
        Me.SettingsLogin1.Text = "Login 1"
        '
        'Inst_MySQLPass_Txt
        '
        Me.Inst_MySQLPass_Txt.Location = New System.Drawing.Point(134, 103)
        Me.Inst_MySQLPass_Txt.Name = "Inst_MySQLPass_Txt"
        Me.Inst_MySQLPass_Txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Inst_MySQLPass_Txt.Size = New System.Drawing.Size(174, 20)
        Me.Inst_MySQLPass_Txt.TabIndex = 7
        '
        'SettingsMySQL_lbl4
        '
        Me.SettingsMySQL_lbl4.AutoSize = True
        Me.SettingsMySQL_lbl4.Location = New System.Drawing.Point(22, 103)
        Me.SettingsMySQL_lbl4.Name = "SettingsMySQL_lbl4"
        Me.SettingsMySQL_lbl4.Size = New System.Drawing.Size(77, 13)
        Me.SettingsMySQL_lbl4.TabIndex = 6
        Me.SettingsMySQL_lbl4.Text = "SQL Password"
        '
        'Inst_MySQLUser_Txt
        '
        Me.Inst_MySQLUser_Txt.Location = New System.Drawing.Point(134, 77)
        Me.Inst_MySQLUser_Txt.Name = "Inst_MySQLUser_Txt"
        Me.Inst_MySQLUser_Txt.Size = New System.Drawing.Size(174, 20)
        Me.Inst_MySQLUser_Txt.TabIndex = 5
        '
        'SettingsMySQL_lbl3
        '
        Me.SettingsMySQL_lbl3.AutoSize = True
        Me.SettingsMySQL_lbl3.Location = New System.Drawing.Point(22, 77)
        Me.SettingsMySQL_lbl3.Name = "SettingsMySQL_lbl3"
        Me.SettingsMySQL_lbl3.Size = New System.Drawing.Size(79, 13)
        Me.SettingsMySQL_lbl3.TabIndex = 4
        Me.SettingsMySQL_lbl3.Text = "SQL Username"
        '
        'Inst_MySQLServer_Txt
        '
        Me.Inst_MySQLServer_Txt.Location = New System.Drawing.Point(134, 51)
        Me.Inst_MySQLServer_Txt.Name = "Inst_MySQLServer_Txt"
        Me.Inst_MySQLServer_Txt.Size = New System.Drawing.Size(174, 20)
        Me.Inst_MySQLServer_Txt.TabIndex = 3
        '
        'SettingsMySQL_lbl2
        '
        Me.SettingsMySQL_lbl2.AutoSize = True
        Me.SettingsMySQL_lbl2.Location = New System.Drawing.Point(22, 51)
        Me.SettingsMySQL_lbl2.Name = "SettingsMySQL_lbl2"
        Me.SettingsMySQL_lbl2.Size = New System.Drawing.Size(62, 13)
        Me.SettingsMySQL_lbl2.TabIndex = 2
        Me.SettingsMySQL_lbl2.Text = "SQL Server"
        '
        'Inst_MySQLODBC_Txt
        '
        Me.Inst_MySQLODBC_Txt.Location = New System.Drawing.Point(134, 25)
        Me.Inst_MySQLODBC_Txt.Name = "Inst_MySQLODBC_Txt"
        Me.Inst_MySQLODBC_Txt.Size = New System.Drawing.Size(174, 20)
        Me.Inst_MySQLODBC_Txt.TabIndex = 1
        '
        'SettingsMySQL_lbl1
        '
        Me.SettingsMySQL_lbl1.AutoSize = True
        Me.SettingsMySQL_lbl1.Location = New System.Drawing.Point(22, 25)
        Me.SettingsMySQL_lbl1.Name = "SettingsMySQL_lbl1"
        Me.SettingsMySQL_lbl1.Size = New System.Drawing.Size(92, 13)
        Me.SettingsMySQL_lbl1.TabIndex = 0
        Me.SettingsMySQL_lbl1.Text = "SQL ODBC Driver"
        '
        'C1TabPrijzen
        '
        Me.C1TabPrijzen.Controls.Add(Me.Prijzen_sizer)
        Me.C1TabPrijzen.Location = New System.Drawing.Point(1, 24)
        Me.C1TabPrijzen.Name = "C1TabPrijzen"
        Me.C1TabPrijzen.Size = New System.Drawing.Size(883, 940)
        Me.C1TabPrijzen.TabIndex = 8
        Me.C1TabPrijzen.Text = "Prijzen"
        '
        'Prijzen_sizer
        '
        Me.Prijzen_sizer.Controls.Add(Me.C1prijzensizer3)
        Me.Prijzen_sizer.Controls.Add(Me.Prijzen_PictureBox)
        Me.Prijzen_sizer.Controls.Add(Me.Prijzen_Sizer2)
        Me.Prijzen_sizer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Prijzen_sizer.GridDefinition = "42.0212765957447:False:False;10.6382978723404:False:True;45.6382978723404:False:F" &
    "alse;" & Global.Microsoft.VisualBasic.ChrW(9) & "99.0939977349943:False:False;"
        Me.Prijzen_sizer.Location = New System.Drawing.Point(0, 0)
        Me.Prijzen_sizer.Name = "Prijzen_sizer"
        Me.Prijzen_sizer.Size = New System.Drawing.Size(883, 940)
        Me.Prijzen_sizer.TabIndex = 0
        Me.Prijzen_sizer.Text = "C1Sizer2"
        '
        'C1prijzensizer3
        '
        Me.C1prijzensizer3.Controls.Add(Me.prijzenpanelmidleft)
        Me.C1prijzensizer3.Controls.Add(Me.prijzenpanelmidright)
        Me.C1prijzensizer3.GridDefinition = "92:False:False;" & Global.Microsoft.VisualBasic.ChrW(9) & "65.1428571428571:False:False;33.4857142857143:False:False;"
        Me.C1prijzensizer3.Location = New System.Drawing.Point(4, 403)
        Me.C1prijzensizer3.Name = "C1prijzensizer3"
        Me.C1prijzensizer3.Size = New System.Drawing.Size(875, 100)
        Me.C1prijzensizer3.TabIndex = 5
        Me.C1prijzensizer3.Text = "C1Sizer2"
        '
        'prijzenpanelmidleft
        '
        Me.prijzenpanelmidleft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.prijzenpanelmidleft.Controls.Add(Me.prijzen_actiecode)
        Me.prijzenpanelmidleft.Controls.Add(Me.Label23)
        Me.prijzenpanelmidleft.Controls.Add(Me.prijzen_accessoire_chk)
        Me.prijzenpanelmidleft.Controls.Add(Me.prijzen_id_lbl)
        Me.prijzenpanelmidleft.Controls.Add(Me.prijzen_jaar_lbl)
        Me.prijzenpanelmidleft.Controls.Add(Me.prijzen_jaar_updown)
        Me.prijzenpanelmidleft.Controls.Add(Me.prijzen_actief_check)
        Me.prijzenpanelmidleft.Controls.Add(Me.prijzen_naam_txt)
        Me.prijzenpanelmidleft.Controls.Add(Me.prijzen_soort_combo)
        Me.prijzenpanelmidleft.Controls.Add(Me.prijzen_naam_lbl)
        Me.prijzenpanelmidleft.Controls.Add(Me.prijzen_koper_combo)
        Me.prijzenpanelmidleft.Controls.Add(Me.prijzen_soort_lbl)
        Me.prijzenpanelmidleft.Controls.Add(Me.prijzen_klant_rb)
        Me.prijzenpanelmidleft.Controls.Add(Me.prijzen_kopergroep_combo)
        Me.prijzenpanelmidleft.Controls.Add(Me.prijzen_algemeen_rb)
        Me.prijzenpanelmidleft.Controls.Add(Me.prijzen_klantgroep_rb)
        Me.prijzenpanelmidleft.Location = New System.Drawing.Point(4, 4)
        Me.prijzenpanelmidleft.Name = "prijzenpanelmidleft"
        Me.prijzenpanelmidleft.Size = New System.Drawing.Size(570, 92)
        Me.prijzenpanelmidleft.TabIndex = 4
        '
        'prijzen_actiecode
        '
        Me.prijzen_actiecode.Enabled = False
        Me.prijzen_actiecode.Location = New System.Drawing.Point(247, 26)
        Me.prijzen_actiecode.Name = "prijzen_actiecode"
        Me.prijzen_actiecode.Size = New System.Drawing.Size(34, 20)
        Me.prijzen_actiecode.TabIndex = 40
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(165, 29)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(76, 13)
        Me.Label23.TabIndex = 39
        Me.Label23.Text = "EindKlantcode"
        '
        'prijzen_accessoire_chk
        '
        Me.prijzen_accessoire_chk.AutoSize = True
        Me.prijzen_accessoire_chk.Enabled = False
        Me.prijzen_accessoire_chk.Location = New System.Drawing.Point(168, 6)
        Me.prijzen_accessoire_chk.Name = "prijzen_accessoire_chk"
        Me.prijzen_accessoire_chk.Size = New System.Drawing.Size(113, 17)
        Me.prijzen_accessoire_chk.TabIndex = 38
        Me.prijzen_accessoire_chk.Text = "Accessoire prijslijst"
        Me.prijzen_accessoire_chk.UseVisualStyleBackColor = True
        '
        'prijzen_id_lbl
        '
        Me.prijzen_id_lbl.AutoSize = True
        Me.prijzen_id_lbl.Location = New System.Drawing.Point(25, 34)
        Me.prijzen_id_lbl.Name = "prijzen_id_lbl"
        Me.prijzen_id_lbl.Size = New System.Drawing.Size(10, 13)
        Me.prijzen_id_lbl.TabIndex = 37
        Me.prijzen_id_lbl.Text = "-"
        Me.prijzen_id_lbl.Visible = False
        '
        'prijzen_jaar_lbl
        '
        Me.prijzen_jaar_lbl.AutoSize = True
        Me.prijzen_jaar_lbl.Location = New System.Drawing.Point(4, 11)
        Me.prijzen_jaar_lbl.Name = "prijzen_jaar_lbl"
        Me.prijzen_jaar_lbl.Size = New System.Drawing.Size(27, 13)
        Me.prijzen_jaar_lbl.TabIndex = 33
        Me.prijzen_jaar_lbl.Text = "Jaar"
        '
        'prijzen_jaar_updown
        '
        Me.prijzen_jaar_updown.Location = New System.Drawing.Point(37, 6)
        Me.prijzen_jaar_updown.Maximum = New Decimal(New Integer() {2100, 0, 0, 0})
        Me.prijzen_jaar_updown.Minimum = New Decimal(New Integer() {2010, 0, 0, 0})
        Me.prijzen_jaar_updown.Name = "prijzen_jaar_updown"
        Me.prijzen_jaar_updown.Size = New System.Drawing.Size(73, 20)
        Me.prijzen_jaar_updown.TabIndex = 32
        Me.prijzen_jaar_updown.Value = New Decimal(New Integer() {2010, 0, 0, 0})
        '
        'prijzen_actief_check
        '
        Me.prijzen_actief_check.AutoSize = True
        Me.prijzen_actief_check.Enabled = False
        Me.prijzen_actief_check.Location = New System.Drawing.Point(7, 72)
        Me.prijzen_actief_check.Name = "prijzen_actief_check"
        Me.prijzen_actief_check.Size = New System.Drawing.Size(15, 14)
        Me.prijzen_actief_check.TabIndex = 36
        Me.prijzen_actief_check.UseVisualStyleBackColor = True
        '
        'prijzen_naam_txt
        '
        Me.prijzen_naam_txt.Enabled = False
        Me.prijzen_naam_txt.Location = New System.Drawing.Point(28, 69)
        Me.prijzen_naam_txt.Name = "prijzen_naam_txt"
        Me.prijzen_naam_txt.Size = New System.Drawing.Size(134, 20)
        Me.prijzen_naam_txt.TabIndex = 26
        '
        'prijzen_soort_combo
        '
        Me.prijzen_soort_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.prijzen_soort_combo.Enabled = False
        Me.prijzen_soort_combo.FormattingEnabled = True
        Me.prijzen_soort_combo.Location = New System.Drawing.Point(168, 68)
        Me.prijzen_soort_combo.Name = "prijzen_soort_combo"
        Me.prijzen_soort_combo.Size = New System.Drawing.Size(134, 21)
        Me.prijzen_soort_combo.TabIndex = 0
        '
        'prijzen_naam_lbl
        '
        Me.prijzen_naam_lbl.AutoSize = True
        Me.prijzen_naam_lbl.Location = New System.Drawing.Point(25, 50)
        Me.prijzen_naam_lbl.Name = "prijzen_naam_lbl"
        Me.prijzen_naam_lbl.Size = New System.Drawing.Size(70, 13)
        Me.prijzen_naam_lbl.TabIndex = 27
        Me.prijzen_naam_lbl.Text = "Naam prijslijst"
        '
        'prijzen_koper_combo
        '
        Me.prijzen_koper_combo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.prijzen_koper_combo.Enabled = False
        Me.prijzen_koper_combo.FormattingEnabled = True
        Me.prijzen_koper_combo.Location = New System.Drawing.Point(365, 68)
        Me.prijzen_koper_combo.Name = "prijzen_koper_combo"
        Me.prijzen_koper_combo.Size = New System.Drawing.Size(132, 21)
        Me.prijzen_koper_combo.TabIndex = 18
        Me.prijzen_koper_combo.Text = "Klant"
        '
        'prijzen_soort_lbl
        '
        Me.prijzen_soort_lbl.AutoSize = True
        Me.prijzen_soort_lbl.Location = New System.Drawing.Point(165, 50)
        Me.prijzen_soort_lbl.Name = "prijzen_soort_lbl"
        Me.prijzen_soort_lbl.Size = New System.Drawing.Size(65, 13)
        Me.prijzen_soort_lbl.TabIndex = 14
        Me.prijzen_soort_lbl.Text = "Soort(groep)"
        '
        'prijzen_klant_rb
        '
        Me.prijzen_klant_rb.AutoSize = True
        Me.prijzen_klant_rb.Enabled = False
        Me.prijzen_klant_rb.Location = New System.Drawing.Point(307, 71)
        Me.prijzen_klant_rb.Name = "prijzen_klant_rb"
        Me.prijzen_klant_rb.Size = New System.Drawing.Size(53, 17)
        Me.prijzen_klant_rb.TabIndex = 17
        Me.prijzen_klant_rb.Text = "Koper"
        Me.prijzen_klant_rb.UseVisualStyleBackColor = True
        '
        'prijzen_kopergroep_combo
        '
        Me.prijzen_kopergroep_combo.Enabled = False
        Me.prijzen_kopergroep_combo.FormattingEnabled = True
        Me.prijzen_kopergroep_combo.Location = New System.Drawing.Point(365, 41)
        Me.prijzen_kopergroep_combo.MaxDropDownItems = 12
        Me.prijzen_kopergroep_combo.Name = "prijzen_kopergroep_combo"
        Me.prijzen_kopergroep_combo.Size = New System.Drawing.Size(132, 21)
        Me.prijzen_kopergroep_combo.TabIndex = 3
        Me.prijzen_kopergroep_combo.Text = "Klant-groep"
        '
        'prijzen_algemeen_rb
        '
        Me.prijzen_algemeen_rb.AutoSize = True
        Me.prijzen_algemeen_rb.Checked = True
        Me.prijzen_algemeen_rb.Enabled = False
        Me.prijzen_algemeen_rb.Location = New System.Drawing.Point(306, 17)
        Me.prijzen_algemeen_rb.Name = "prijzen_algemeen_rb"
        Me.prijzen_algemeen_rb.Size = New System.Drawing.Size(75, 17)
        Me.prijzen_algemeen_rb.TabIndex = 16
        Me.prijzen_algemeen_rb.TabStop = True
        Me.prijzen_algemeen_rb.Text = " Algemeen"
        Me.prijzen_algemeen_rb.UseVisualStyleBackColor = True
        '
        'prijzen_klantgroep_rb
        '
        Me.prijzen_klantgroep_rb.AutoSize = True
        Me.prijzen_klantgroep_rb.Enabled = False
        Me.prijzen_klantgroep_rb.Location = New System.Drawing.Point(307, 45)
        Me.prijzen_klantgroep_rb.Name = "prijzen_klantgroep_rb"
        Me.prijzen_klantgroep_rb.Size = New System.Drawing.Size(54, 17)
        Me.prijzen_klantgroep_rb.TabIndex = 15
        Me.prijzen_klantgroep_rb.Text = "Groep"
        Me.prijzen_klantgroep_rb.UseVisualStyleBackColor = True
        '
        'prijzenpanelmidright
        '
        Me.prijzenpanelmidright.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.prijzenpanelmidright.Controls.Add(Me.prijzen_idsel_lbl)
        Me.prijzenpanelmidright.Controls.Add(Me.prijzen_verwijderdatum_but)
        Me.prijzenpanelmidright.Controls.Add(Me.prijzen_toevoegendatum_but)
        Me.prijzenpanelmidright.Controls.Add(Me.prijzen_prijs_lbl)
        Me.prijzenpanelmidright.Controls.Add(Me.prijzen_prijs_txt)
        Me.prijzenpanelmidright.Controls.Add(Me.prijzen_datum_pick)
        Me.prijzenpanelmidright.Location = New System.Drawing.Point(578, 4)
        Me.prijzenpanelmidright.Name = "prijzenpanelmidright"
        Me.prijzenpanelmidright.Size = New System.Drawing.Size(293, 92)
        Me.prijzenpanelmidright.TabIndex = 5
        '
        'prijzen_idsel_lbl
        '
        Me.prijzen_idsel_lbl.AutoSize = True
        Me.prijzen_idsel_lbl.Location = New System.Drawing.Point(29, 9)
        Me.prijzen_idsel_lbl.Name = "prijzen_idsel_lbl"
        Me.prijzen_idsel_lbl.Size = New System.Drawing.Size(10, 13)
        Me.prijzen_idsel_lbl.TabIndex = 38
        Me.prijzen_idsel_lbl.Text = "-"
        Me.prijzen_idsel_lbl.Visible = False
        '
        'prijzen_verwijderdatum_but
        '
        Me.prijzen_verwijderdatum_but.Enabled = False
        Me.prijzen_verwijderdatum_but.Location = New System.Drawing.Point(32, 34)
        Me.prijzen_verwijderdatum_but.Name = "prijzen_verwijderdatum_but"
        Me.prijzen_verwijderdatum_but.Size = New System.Drawing.Size(102, 25)
        Me.prijzen_verwijderdatum_but.TabIndex = 31
        Me.prijzen_verwijderdatum_but.Text = "Verwijderen"
        Me.prijzen_verwijderdatum_but.UseVisualStyleBackColor = True
        '
        'prijzen_toevoegendatum_but
        '
        Me.prijzen_toevoegendatum_but.Enabled = False
        Me.prijzen_toevoegendatum_but.Location = New System.Drawing.Point(138, 34)
        Me.prijzen_toevoegendatum_but.Name = "prijzen_toevoegendatum_but"
        Me.prijzen_toevoegendatum_but.Size = New System.Drawing.Size(101, 25)
        Me.prijzen_toevoegendatum_but.TabIndex = 30
        Me.prijzen_toevoegendatum_but.Text = "Toevoegen"
        Me.prijzen_toevoegendatum_but.UseVisualStyleBackColor = True
        '
        'prijzen_prijs_lbl
        '
        Me.prijzen_prijs_lbl.AutoSize = True
        Me.prijzen_prijs_lbl.Location = New System.Drawing.Point(142, 71)
        Me.prijzen_prijs_lbl.Name = "prijzen_prijs_lbl"
        Me.prijzen_prijs_lbl.Size = New System.Drawing.Size(35, 13)
        Me.prijzen_prijs_lbl.TabIndex = 21
        Me.prijzen_prijs_lbl.Text = "Prijs : "
        '
        'prijzen_prijs_txt
        '
        Me.prijzen_prijs_txt.Enabled = False
        Me.prijzen_prijs_txt.Location = New System.Drawing.Point(183, 65)
        Me.prijzen_prijs_txt.Name = "prijzen_prijs_txt"
        Me.prijzen_prijs_txt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.prijzen_prijs_txt.Size = New System.Drawing.Size(56, 20)
        Me.prijzen_prijs_txt.TabIndex = 20
        Me.prijzen_prijs_txt.Text = "1.00"
        '
        'prijzen_datum_pick
        '
        Me.prijzen_datum_pick.Enabled = False
        Me.prijzen_datum_pick.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.prijzen_datum_pick.Location = New System.Drawing.Point(32, 66)
        Me.prijzen_datum_pick.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.prijzen_datum_pick.Name = "prijzen_datum_pick"
        Me.prijzen_datum_pick.Size = New System.Drawing.Size(104, 20)
        Me.prijzen_datum_pick.TabIndex = 19
        '
        'Prijzen_PictureBox
        '
        Me.Prijzen_PictureBox.Location = New System.Drawing.Point(4, 4)
        Me.Prijzen_PictureBox.Name = "Prijzen_PictureBox"
        Me.Prijzen_PictureBox.Size = New System.Drawing.Size(875, 395)
        Me.Prijzen_PictureBox.TabIndex = 3
        Me.Prijzen_PictureBox.TabStop = False
        '
        'Prijzen_Sizer2
        '
        Me.Prijzen_Sizer2.Controls.Add(Me.Prijzen_flexgrid_soorten)
        Me.Prijzen_Sizer2.Controls.Add(Me.prijzen_flexgrid_datums)
        Me.Prijzen_Sizer2.GridDefinition = "98.1351981351981:False:False;" & Global.Microsoft.VisualBasic.ChrW(9) & "65.1428571428571:False:False;33.4857142857143:False" &
    ":False;"
        Me.Prijzen_Sizer2.Location = New System.Drawing.Point(4, 507)
        Me.Prijzen_Sizer2.Name = "Prijzen_Sizer2"
        Me.Prijzen_Sizer2.Size = New System.Drawing.Size(875, 429)
        Me.Prijzen_Sizer2.TabIndex = 2
        Me.Prijzen_Sizer2.Text = "C1Sizer2"
        '
        'Prijzen_flexgrid_soorten
        '
        Me.Prijzen_flexgrid_soorten.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.Prijzen_flexgrid_soorten.AllowEditing = False
        Me.Prijzen_flexgrid_soorten.ColumnInfo = "10,0,0,0,0,85,Columns:"
        Me.Prijzen_flexgrid_soorten.Location = New System.Drawing.Point(4, 4)
        Me.Prijzen_flexgrid_soorten.Name = "Prijzen_flexgrid_soorten"
        Me.Prijzen_flexgrid_soorten.Rows.DefaultSize = 17
        Me.Prijzen_flexgrid_soorten.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.ListBox
        Me.Prijzen_flexgrid_soorten.Size = New System.Drawing.Size(570, 421)
        Me.Prijzen_flexgrid_soorten.TabIndex = 1
        '
        'prijzen_flexgrid_datums
        '
        Me.prijzen_flexgrid_datums.AllowEditing = False
        Me.prijzen_flexgrid_datums.ColumnInfo = "2,0,0,0,0,85,Columns:0{Width:108;Caption:""Datum"";}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:100;Caption:""Prijs"";}" & Global.Microsoft.VisualBasic.ChrW(9) &
    ""
        Me.prijzen_flexgrid_datums.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.prijzen_flexgrid_datums.Location = New System.Drawing.Point(578, 4)
        Me.prijzen_flexgrid_datums.Name = "prijzen_flexgrid_datums"
        Me.prijzen_flexgrid_datums.Rows.DefaultSize = 17
        Me.prijzen_flexgrid_datums.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.ListBox
        Me.prijzen_flexgrid_datums.Size = New System.Drawing.Size(293, 421)
        Me.prijzen_flexgrid_datums.TabIndex = 0
        '
        'C1TabVoorraad
        '
        Me.C1TabVoorraad.Controls.Add(Me.C1SizerVoorraad)
        Me.C1TabVoorraad.Location = New System.Drawing.Point(1, 24)
        Me.C1TabVoorraad.Name = "C1TabVoorraad"
        Me.C1TabVoorraad.Size = New System.Drawing.Size(883, 940)
        Me.C1TabVoorraad.TabIndex = 9
        Me.C1TabVoorraad.Text = "Voorraad"
        '
        'C1SizerVoorraad
        '
        Me.C1SizerVoorraad.Controls.Add(Me.Voorraad_Flexgrid)
        Me.C1SizerVoorraad.Controls.Add(Me.PanelVoorraad)
        Me.C1SizerVoorraad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1SizerVoorraad.GridDefinition = "99.1489361702128:False:False;" & Global.Microsoft.VisualBasic.ChrW(9) & "28.312570781427:False:True;70.3284258210646:False:F" &
    "alse;"
        Me.C1SizerVoorraad.Location = New System.Drawing.Point(0, 0)
        Me.C1SizerVoorraad.Name = "C1SizerVoorraad"
        Me.C1SizerVoorraad.Size = New System.Drawing.Size(883, 940)
        Me.C1SizerVoorraad.TabIndex = 0
        Me.C1SizerVoorraad.Text = "C1Sizer2"
        '
        'Voorraad_Flexgrid
        '
        Me.Voorraad_Flexgrid.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.Voorraad_Flexgrid.AllowEditing = False
        Me.Voorraad_Flexgrid.ColumnInfo = resources.GetString("Voorraad_Flexgrid.ColumnInfo")
        Me.Voorraad_Flexgrid.Location = New System.Drawing.Point(258, 4)
        Me.Voorraad_Flexgrid.Name = "Voorraad_Flexgrid"
        Me.Voorraad_Flexgrid.Rows.Count = 1
        Me.Voorraad_Flexgrid.Rows.DefaultSize = 17
        Me.Voorraad_Flexgrid.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.ListBox
        Me.Voorraad_Flexgrid.Size = New System.Drawing.Size(621, 932)
        Me.Voorraad_Flexgrid.TabIndex = 1
        '
        'PanelVoorraad
        '
        Me.PanelVoorraad.Controls.Add(Me.Voorraad_aanpassen_but)
        Me.PanelVoorraad.Controls.Add(Me.voorraad_nieuw_but)
        Me.PanelVoorraad.Controls.Add(Me.GroupBoxVoorraad)
        Me.PanelVoorraad.Controls.Add(Me.voorraad_bereken_but)
        Me.PanelVoorraad.Location = New System.Drawing.Point(4, 4)
        Me.PanelVoorraad.Name = "PanelVoorraad"
        Me.PanelVoorraad.Size = New System.Drawing.Size(250, 932)
        Me.PanelVoorraad.TabIndex = 0
        '
        'Voorraad_aanpassen_but
        '
        Me.Voorraad_aanpassen_but.Location = New System.Drawing.Point(3, 737)
        Me.Voorraad_aanpassen_but.Name = "Voorraad_aanpassen_but"
        Me.Voorraad_aanpassen_but.Size = New System.Drawing.Size(245, 35)
        Me.Voorraad_aanpassen_but.TabIndex = 3
        Me.Voorraad_aanpassen_but.Text = "Artikel aanpassen"
        Me.Voorraad_aanpassen_but.UseVisualStyleBackColor = True
        '
        'voorraad_nieuw_but
        '
        Me.voorraad_nieuw_but.Location = New System.Drawing.Point(3, 696)
        Me.voorraad_nieuw_but.Name = "voorraad_nieuw_but"
        Me.voorraad_nieuw_but.Size = New System.Drawing.Size(245, 35)
        Me.voorraad_nieuw_but.TabIndex = 2
        Me.voorraad_nieuw_but.Text = "Nieuw artikel toevoegen"
        Me.voorraad_nieuw_but.UseVisualStyleBackColor = True
        '
        'GroupBoxVoorraad
        '
        Me.GroupBoxVoorraad.Controls.Add(Me.voorraad_annuleer_but)
        Me.GroupBoxVoorraad.Controls.Add(Me.Voorraad_Besteld_chk)
        Me.GroupBoxVoorraad.Controls.Add(Me.voorraad_koppelingfust5_cmb)
        Me.GroupBoxVoorraad.Controls.Add(Me.voorraad_koppelingacce3_cmb)
        Me.GroupBoxVoorraad.Controls.Add(Me.voorraad_koppelingacce2_cmb)
        Me.GroupBoxVoorraad.Controls.Add(Me.voorraad_koppelingfust4_cmb)
        Me.GroupBoxVoorraad.Controls.Add(Me.voorraad_koppelingfust3_cmb)
        Me.GroupBoxVoorraad.Controls.Add(Me.voorraad_koppelingfust2_cmb)
        Me.GroupBoxVoorraad.Controls.Add(Me.voorraad_id)
        Me.GroupBoxVoorraad.Controls.Add(Me.Label22)
        Me.GroupBoxVoorraad.Controls.Add(Me.voorraad_opslaan_but)
        Me.GroupBoxVoorraad.Controls.Add(Me.voorraad_inkoopstuks_but)
        Me.GroupBoxVoorraad.Controls.Add(Me.voorraad_inkooppallets_but)
        Me.GroupBoxVoorraad.Controls.Add(Me.Label21)
        Me.GroupBoxVoorraad.Controls.Add(Me.voorraad_koppelingacce1_cmb)
        Me.GroupBoxVoorraad.Controls.Add(Me.voorraad_koppelingfust1_cmb)
        Me.GroupBoxVoorraad.Controls.Add(Me.voorraad_koppelingacce_radio)
        Me.GroupBoxVoorraad.Controls.Add(Me.voorraad_koppelingfust_radio)
        Me.GroupBoxVoorraad.Controls.Add(Me.voorraad_besteltijd_txt)
        Me.GroupBoxVoorraad.Controls.Add(Me.Label20)
        Me.GroupBoxVoorraad.Controls.Add(Me.voorraad_aantalperpallet_txt)
        Me.GroupBoxVoorraad.Controls.Add(Me.voorraad_minimum_txt)
        Me.GroupBoxVoorraad.Controls.Add(Me.Label14)
        Me.GroupBoxVoorraad.Controls.Add(Me.Label7)
        Me.GroupBoxVoorraad.Controls.Add(Me.Label6)
        Me.GroupBoxVoorraad.Controls.Add(Me.Label5)
        Me.GroupBoxVoorraad.Controls.Add(Me.voorraad_waarschuwing_chk)
        Me.GroupBoxVoorraad.Controls.Add(Me.voorraad_voorraad_txt)
        Me.GroupBoxVoorraad.Controls.Add(Me.Label4)
        Me.GroupBoxVoorraad.Controls.Add(Me.voorraad_inkoopstuks_txt)
        Me.GroupBoxVoorraad.Controls.Add(Me.Label3)
        Me.GroupBoxVoorraad.Controls.Add(Me.voorraad_inkooppallets_txt)
        Me.GroupBoxVoorraad.Controls.Add(Me.Label2)
        Me.GroupBoxVoorraad.Controls.Add(Me.voorraad_artikelnaam_txt)
        Me.GroupBoxVoorraad.Controls.Add(Me.Label1)
        Me.GroupBoxVoorraad.Enabled = False
        Me.GroupBoxVoorraad.Location = New System.Drawing.Point(-1, 62)
        Me.GroupBoxVoorraad.Name = "GroupBoxVoorraad"
        Me.GroupBoxVoorraad.Size = New System.Drawing.Size(248, 628)
        Me.GroupBoxVoorraad.TabIndex = 1
        Me.GroupBoxVoorraad.TabStop = False
        Me.GroupBoxVoorraad.Text = "Artikel"
        '
        'voorraad_annuleer_but
        '
        Me.voorraad_annuleer_but.Location = New System.Drawing.Point(27, 586)
        Me.voorraad_annuleer_but.Name = "voorraad_annuleer_but"
        Me.voorraad_annuleer_but.Size = New System.Drawing.Size(196, 31)
        Me.voorraad_annuleer_but.TabIndex = 37
        Me.voorraad_annuleer_but.Text = "Annuleren"
        Me.voorraad_annuleer_but.UseVisualStyleBackColor = True
        '
        'Voorraad_Besteld_chk
        '
        Me.Voorraad_Besteld_chk.AutoSize = True
        Me.Voorraad_Besteld_chk.Location = New System.Drawing.Point(103, 198)
        Me.Voorraad_Besteld_chk.Name = "Voorraad_Besteld_chk"
        Me.Voorraad_Besteld_chk.Size = New System.Drawing.Size(68, 17)
        Me.Voorraad_Besteld_chk.TabIndex = 36
        Me.Voorraad_Besteld_chk.Text = "1-1-2010"
        Me.Voorraad_Besteld_chk.UseVisualStyleBackColor = True
        '
        'voorraad_koppelingfust5_cmb
        '
        Me.voorraad_koppelingfust5_cmb.FormattingEnabled = True
        Me.voorraad_koppelingfust5_cmb.Location = New System.Drawing.Point(103, 419)
        Me.voorraad_koppelingfust5_cmb.Name = "voorraad_koppelingfust5_cmb"
        Me.voorraad_koppelingfust5_cmb.Size = New System.Drawing.Size(139, 21)
        Me.voorraad_koppelingfust5_cmb.TabIndex = 35
        '
        'voorraad_koppelingacce3_cmb
        '
        Me.voorraad_koppelingacce3_cmb.FormattingEnabled = True
        Me.voorraad_koppelingacce3_cmb.Location = New System.Drawing.Point(103, 509)
        Me.voorraad_koppelingacce3_cmb.Name = "voorraad_koppelingacce3_cmb"
        Me.voorraad_koppelingacce3_cmb.Size = New System.Drawing.Size(139, 21)
        Me.voorraad_koppelingacce3_cmb.TabIndex = 34
        '
        'voorraad_koppelingacce2_cmb
        '
        Me.voorraad_koppelingacce2_cmb.FormattingEnabled = True
        Me.voorraad_koppelingacce2_cmb.Location = New System.Drawing.Point(103, 482)
        Me.voorraad_koppelingacce2_cmb.Name = "voorraad_koppelingacce2_cmb"
        Me.voorraad_koppelingacce2_cmb.Size = New System.Drawing.Size(139, 21)
        Me.voorraad_koppelingacce2_cmb.TabIndex = 33
        '
        'voorraad_koppelingfust4_cmb
        '
        Me.voorraad_koppelingfust4_cmb.FormattingEnabled = True
        Me.voorraad_koppelingfust4_cmb.Location = New System.Drawing.Point(103, 392)
        Me.voorraad_koppelingfust4_cmb.Name = "voorraad_koppelingfust4_cmb"
        Me.voorraad_koppelingfust4_cmb.Size = New System.Drawing.Size(139, 21)
        Me.voorraad_koppelingfust4_cmb.TabIndex = 32
        '
        'voorraad_koppelingfust3_cmb
        '
        Me.voorraad_koppelingfust3_cmb.FormattingEnabled = True
        Me.voorraad_koppelingfust3_cmb.Location = New System.Drawing.Point(103, 365)
        Me.voorraad_koppelingfust3_cmb.Name = "voorraad_koppelingfust3_cmb"
        Me.voorraad_koppelingfust3_cmb.Size = New System.Drawing.Size(139, 21)
        Me.voorraad_koppelingfust3_cmb.TabIndex = 31
        '
        'voorraad_koppelingfust2_cmb
        '
        Me.voorraad_koppelingfust2_cmb.FormattingEnabled = True
        Me.voorraad_koppelingfust2_cmb.Location = New System.Drawing.Point(103, 338)
        Me.voorraad_koppelingfust2_cmb.Name = "voorraad_koppelingfust2_cmb"
        Me.voorraad_koppelingfust2_cmb.Size = New System.Drawing.Size(139, 21)
        Me.voorraad_koppelingfust2_cmb.TabIndex = 30
        '
        'voorraad_id
        '
        Me.voorraad_id.AutoSize = True
        Me.voorraad_id.Location = New System.Drawing.Point(48, 533)
        Me.voorraad_id.Name = "voorraad_id"
        Me.voorraad_id.Size = New System.Drawing.Size(13, 13)
        Me.voorraad_id.TabIndex = 28
        Me.voorraad_id.Text = "0"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(24, 533)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(19, 13)
        Me.Label22.TabIndex = 27
        Me.Label22.Text = "Id:"
        '
        'voorraad_opslaan_but
        '
        Me.voorraad_opslaan_but.Location = New System.Drawing.Point(27, 549)
        Me.voorraad_opslaan_but.Name = "voorraad_opslaan_but"
        Me.voorraad_opslaan_but.Size = New System.Drawing.Size(196, 31)
        Me.voorraad_opslaan_but.TabIndex = 26
        Me.voorraad_opslaan_but.Text = "Opslaan"
        Me.voorraad_opslaan_but.UseVisualStyleBackColor = True
        '
        'voorraad_inkoopstuks_but
        '
        Me.voorraad_inkoopstuks_but.Location = New System.Drawing.Point(206, 94)
        Me.voorraad_inkoopstuks_but.Name = "voorraad_inkoopstuks_but"
        Me.voorraad_inkoopstuks_but.Size = New System.Drawing.Size(36, 20)
        Me.voorraad_inkoopstuks_but.TabIndex = 24
        Me.voorraad_inkoopstuks_but.Text = "Add"
        Me.voorraad_inkoopstuks_but.UseVisualStyleBackColor = True
        '
        'voorraad_inkooppallets_but
        '
        Me.voorraad_inkooppallets_but.Location = New System.Drawing.Point(206, 68)
        Me.voorraad_inkooppallets_but.Name = "voorraad_inkooppallets_but"
        Me.voorraad_inkooppallets_but.Size = New System.Drawing.Size(36, 20)
        Me.voorraad_inkooppallets_but.TabIndex = 23
        Me.voorraad_inkooppallets_but.Text = "Add"
        Me.voorraad_inkooppallets_but.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 314)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(54, 13)
        Me.Label21.TabIndex = 22
        Me.Label21.Text = "Koppeling"
        '
        'voorraad_koppelingacce1_cmb
        '
        Me.voorraad_koppelingacce1_cmb.FormattingEnabled = True
        Me.voorraad_koppelingacce1_cmb.Location = New System.Drawing.Point(103, 455)
        Me.voorraad_koppelingacce1_cmb.Name = "voorraad_koppelingacce1_cmb"
        Me.voorraad_koppelingacce1_cmb.Size = New System.Drawing.Size(139, 21)
        Me.voorraad_koppelingacce1_cmb.TabIndex = 21
        '
        'voorraad_koppelingfust1_cmb
        '
        Me.voorraad_koppelingfust1_cmb.FormattingEnabled = True
        Me.voorraad_koppelingfust1_cmb.Location = New System.Drawing.Point(103, 311)
        Me.voorraad_koppelingfust1_cmb.Name = "voorraad_koppelingfust1_cmb"
        Me.voorraad_koppelingfust1_cmb.Size = New System.Drawing.Size(139, 21)
        Me.voorraad_koppelingfust1_cmb.TabIndex = 20
        '
        'voorraad_koppelingacce_radio
        '
        Me.voorraad_koppelingacce_radio.AutoSize = True
        Me.voorraad_koppelingacce_radio.Location = New System.Drawing.Point(79, 458)
        Me.voorraad_koppelingacce_radio.Name = "voorraad_koppelingacce_radio"
        Me.voorraad_koppelingacce_radio.Size = New System.Drawing.Size(14, 13)
        Me.voorraad_koppelingacce_radio.TabIndex = 19
        Me.voorraad_koppelingacce_radio.UseVisualStyleBackColor = True
        '
        'voorraad_koppelingfust_radio
        '
        Me.voorraad_koppelingfust_radio.AutoSize = True
        Me.voorraad_koppelingfust_radio.Checked = True
        Me.voorraad_koppelingfust_radio.Location = New System.Drawing.Point(79, 314)
        Me.voorraad_koppelingfust_radio.Name = "voorraad_koppelingfust_radio"
        Me.voorraad_koppelingfust_radio.Size = New System.Drawing.Size(14, 13)
        Me.voorraad_koppelingfust_radio.TabIndex = 18
        Me.voorraad_koppelingfust_radio.TabStop = True
        Me.voorraad_koppelingfust_radio.UseVisualStyleBackColor = True
        '
        'voorraad_besteltijd_txt
        '
        Me.voorraad_besteltijd_txt.Location = New System.Drawing.Point(103, 276)
        Me.voorraad_besteltijd_txt.Name = "voorraad_besteltijd_txt"
        Me.voorraad_besteltijd_txt.Size = New System.Drawing.Size(120, 20)
        Me.voorraad_besteltijd_txt.TabIndex = 17
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 279)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(90, 13)
        Me.Label20.TabIndex = 16
        Me.Label20.Text = "Besteltijd (weken)"
        '
        'voorraad_aantalperpallet_txt
        '
        Me.voorraad_aantalperpallet_txt.Location = New System.Drawing.Point(103, 250)
        Me.voorraad_aantalperpallet_txt.Name = "voorraad_aantalperpallet_txt"
        Me.voorraad_aantalperpallet_txt.Size = New System.Drawing.Size(120, 20)
        Me.voorraad_aantalperpallet_txt.TabIndex = 15
        '
        'voorraad_minimum_txt
        '
        Me.voorraad_minimum_txt.Location = New System.Drawing.Point(103, 226)
        Me.voorraad_minimum_txt.Name = "voorraad_minimum_txt"
        Me.voorraad_minimum_txt.Size = New System.Drawing.Size(120, 20)
        Me.voorraad_minimum_txt.TabIndex = 14
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 253)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(95, 13)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Aantal/verpakking"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 229)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Minimale voorraad"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 199)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Bestelling gedaan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Waarschuwing"
        '
        'voorraad_waarschuwing_chk
        '
        Me.voorraad_waarschuwing_chk.AutoSize = True
        Me.voorraad_waarschuwing_chk.Location = New System.Drawing.Point(103, 172)
        Me.voorraad_waarschuwing_chk.Name = "voorraad_waarschuwing_chk"
        Me.voorraad_waarschuwing_chk.Size = New System.Drawing.Size(15, 14)
        Me.voorraad_waarschuwing_chk.TabIndex = 8
        Me.voorraad_waarschuwing_chk.UseVisualStyleBackColor = True
        '
        'voorraad_voorraad_txt
        '
        Me.voorraad_voorraad_txt.Location = New System.Drawing.Point(103, 120)
        Me.voorraad_voorraad_txt.Name = "voorraad_voorraad_txt"
        Me.voorraad_voorraad_txt.Size = New System.Drawing.Size(97, 20)
        Me.voorraad_voorraad_txt.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Voorraad"
        '
        'voorraad_inkoopstuks_txt
        '
        Me.voorraad_inkoopstuks_txt.Location = New System.Drawing.Point(103, 94)
        Me.voorraad_inkoopstuks_txt.Name = "voorraad_inkoopstuks_txt"
        Me.voorraad_inkoopstuks_txt.Size = New System.Drawing.Size(97, 20)
        Me.voorraad_inkoopstuks_txt.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Inkoop stuks"
        '
        'voorraad_inkooppallets_txt
        '
        Me.voorraad_inkooppallets_txt.Location = New System.Drawing.Point(103, 68)
        Me.voorraad_inkooppallets_txt.Name = "voorraad_inkooppallets_txt"
        Me.voorraad_inkooppallets_txt.Size = New System.Drawing.Size(97, 20)
        Me.voorraad_inkooppallets_txt.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Inkoop verpakking"
        '
        'voorraad_artikelnaam_txt
        '
        Me.voorraad_artikelnaam_txt.Location = New System.Drawing.Point(103, 42)
        Me.voorraad_artikelnaam_txt.Name = "voorraad_artikelnaam_txt"
        Me.voorraad_artikelnaam_txt.Size = New System.Drawing.Size(139, 20)
        Me.voorraad_artikelnaam_txt.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Naam"
        '
        'voorraad_bereken_but
        '
        Me.voorraad_bereken_but.Location = New System.Drawing.Point(3, 16)
        Me.voorraad_bereken_but.Name = "voorraad_bereken_but"
        Me.voorraad_bereken_but.Size = New System.Drawing.Size(244, 40)
        Me.voorraad_bereken_but.TabIndex = 0
        Me.voorraad_bereken_but.Text = "Voorraad overzicht opvragen"
        Me.voorraad_bereken_but.UseVisualStyleBackColor = True
        '
        'C1TabWPS
        '
        Me.C1TabWPS.Controls.Add(Me.C1SizerWpsFilters)
        Me.C1TabWPS.Location = New System.Drawing.Point(1, 24)
        Me.C1TabWPS.Name = "C1TabWPS"
        Me.C1TabWPS.Size = New System.Drawing.Size(883, 940)
        Me.C1TabWPS.TabIndex = 10
        Me.C1TabWPS.Text = "Wps filters"
        '
        'C1SizerWpsFilters
        '
        Me.C1SizerWpsFilters.Controls.Add(Me.WpsFilter_flexcombo)
        Me.C1SizerWpsFilters.Controls.Add(Me.PanelWpsFilterMidBar)
        Me.C1SizerWpsFilters.Controls.Add(Me.PanelWpsFilterTopBar)
        Me.C1SizerWpsFilters.Controls.Add(Me.PanelWpsFilter)
        Me.C1SizerWpsFilters.Controls.Add(Me.WpsFilter_FilterFlex)
        Me.C1SizerWpsFilters.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1SizerWpsFilters.GridDefinition = "4.04255319148936:False:True;51.4893617021277:False:False;4.04255319148936:False:T" &
    "rue;38.2978723404255:False:False;" & Global.Microsoft.VisualBasic.ChrW(9) & "99.0939977349943:False:False;"
        Me.C1SizerWpsFilters.Location = New System.Drawing.Point(0, 0)
        Me.C1SizerWpsFilters.Name = "C1SizerWpsFilters"
        Me.C1SizerWpsFilters.Size = New System.Drawing.Size(883, 940)
        Me.C1SizerWpsFilters.TabIndex = 0
        Me.C1SizerWpsFilters.Text = "C1Sizer2"
        '
        'WpsFilter_flexcombo
        '
        Me.WpsFilter_flexcombo.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.WpsFilter_flexcombo.Caption = ""
        Me.WpsFilter_flexcombo.CaptionHeight = 17
        Me.WpsFilter_flexcombo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.WpsFilter_flexcombo.ColumnCaptionHeight = 17
        Me.WpsFilter_flexcombo.ColumnFooterHeight = 17
        Me.WpsFilter_flexcombo.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.WpsFilter_flexcombo.EditorBackColor = System.Drawing.SystemColors.Window
        Me.WpsFilter_flexcombo.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.WpsFilter_flexcombo.Images.Add(CType(resources.GetObject("WpsFilter_flexcombo.Images"), System.Drawing.Image))
        Me.WpsFilter_flexcombo.ItemHeight = 15
        Me.WpsFilter_flexcombo.Location = New System.Drawing.Point(4, 576)
        Me.WpsFilter_flexcombo.MatchEntryTimeout = CType(2000, Long)
        Me.WpsFilter_flexcombo.MaxDropDownItems = CType(5, Short)
        Me.WpsFilter_flexcombo.MaxLength = 32767
        Me.WpsFilter_flexcombo.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.WpsFilter_flexcombo.Name = "WpsFilter_flexcombo"
        Me.WpsFilter_flexcombo.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.WpsFilter_flexcombo.Size = New System.Drawing.Size(875, 21)
        Me.WpsFilter_flexcombo.TabIndex = 3
        Me.WpsFilter_flexcombo.Visible = False
        Me.WpsFilter_flexcombo.PropBag = resources.GetString("WpsFilter_flexcombo.PropBag")
        '
        'PanelWpsFilterMidBar
        '
        Me.PanelWpsFilterMidBar.Controls.Add(Me.WpsFilter_filternaam_lbl)
        Me.PanelWpsFilterMidBar.Controls.Add(Me.WpsFilter_filternaam_txt)
        Me.PanelWpsFilterMidBar.Controls.Add(Me.WpsFilter_FilterOpslaan_but)
        Me.PanelWpsFilterMidBar.Location = New System.Drawing.Point(4, 534)
        Me.PanelWpsFilterMidBar.Name = "PanelWpsFilterMidBar"
        Me.PanelWpsFilterMidBar.Size = New System.Drawing.Size(875, 38)
        Me.PanelWpsFilterMidBar.TabIndex = 4
        '
        'WpsFilter_filternaam_lbl
        '
        Me.WpsFilter_filternaam_lbl.AutoSize = True
        Me.WpsFilter_filternaam_lbl.Location = New System.Drawing.Point(306, 17)
        Me.WpsFilter_filternaam_lbl.Name = "WpsFilter_filternaam_lbl"
        Me.WpsFilter_filternaam_lbl.Size = New System.Drawing.Size(55, 13)
        Me.WpsFilter_filternaam_lbl.TabIndex = 2
        Me.WpsFilter_filternaam_lbl.Text = "Filternaam"
        '
        'WpsFilter_filternaam_txt
        '
        Me.WpsFilter_filternaam_txt.Location = New System.Drawing.Point(367, 13)
        Me.WpsFilter_filternaam_txt.Name = "WpsFilter_filternaam_txt"
        Me.WpsFilter_filternaam_txt.Size = New System.Drawing.Size(165, 20)
        Me.WpsFilter_filternaam_txt.TabIndex = 1
        '
        'WpsFilter_FilterOpslaan_but
        '
        Me.WpsFilter_FilterOpslaan_but.Enabled = False
        Me.WpsFilter_FilterOpslaan_but.Location = New System.Drawing.Point(3, 9)
        Me.WpsFilter_FilterOpslaan_but.Name = "WpsFilter_FilterOpslaan_but"
        Me.WpsFilter_FilterOpslaan_but.Size = New System.Drawing.Size(284, 27)
        Me.WpsFilter_FilterOpslaan_but.TabIndex = 0
        Me.WpsFilter_FilterOpslaan_but.Text = "Wps filter instellingen groep 1 opslaan"
        Me.WpsFilter_FilterOpslaan_but.UseVisualStyleBackColor = True
        '
        'PanelWpsFilterTopBar
        '
        Me.PanelWpsFilterTopBar.Controls.Add(Me.WpsFilter_koperIndelingOphalen_but)
        Me.PanelWpsFilterTopBar.Location = New System.Drawing.Point(4, 4)
        Me.PanelWpsFilterTopBar.Name = "PanelWpsFilterTopBar"
        Me.PanelWpsFilterTopBar.Size = New System.Drawing.Size(875, 38)
        Me.PanelWpsFilterTopBar.TabIndex = 3
        '
        'WpsFilter_koperIndelingOphalen_but
        '
        Me.WpsFilter_koperIndelingOphalen_but.Location = New System.Drawing.Point(7, 5)
        Me.WpsFilter_koperIndelingOphalen_but.Name = "WpsFilter_koperIndelingOphalen_but"
        Me.WpsFilter_koperIndelingOphalen_but.Size = New System.Drawing.Size(163, 30)
        Me.WpsFilter_koperIndelingOphalen_but.TabIndex = 0
        Me.WpsFilter_koperIndelingOphalen_but.Text = "Koper indeling ophalen"
        Me.WpsFilter_koperIndelingOphalen_but.UseVisualStyleBackColor = True
        '
        'PanelWpsFilter
        '
        Me.PanelWpsFilter.AutoScroll = True
        Me.PanelWpsFilter.Controls.Add(Me.WpsFilter_Scrollbar)
        Me.PanelWpsFilter.Controls.Add(Me.WpsFilter_Instel5_but)
        Me.PanelWpsFilter.Controls.Add(Me.WpsFilter_Instel4_but)
        Me.PanelWpsFilter.Controls.Add(Me.WpsFilter_Instel3_but)
        Me.PanelWpsFilter.Controls.Add(Me.WpsFilter_Instel2_but)
        Me.PanelWpsFilter.Controls.Add(Me.WpsFilter_Instel1_but)
        Me.PanelWpsFilter.Controls.Add(Me.WpsFilter_ChkList5_lst)
        Me.PanelWpsFilter.Controls.Add(Me.WpsFilter_ChkList4_lst)
        Me.PanelWpsFilter.Controls.Add(Me.WpsFilter_ChkList3_lst)
        Me.PanelWpsFilter.Controls.Add(Me.WpsFilter_ChkList2_lst)
        Me.PanelWpsFilter.Controls.Add(Me.WpsFilter_ChkList1_lst)
        Me.PanelWpsFilter.Controls.Add(Me.WpsFilter_Add5_but)
        Me.PanelWpsFilter.Controls.Add(Me.WpsFilter_Add4_but)
        Me.PanelWpsFilter.Controls.Add(Me.WpsFilter_Add3_but)
        Me.PanelWpsFilter.Controls.Add(Me.WpsFilter_Add2_but)
        Me.PanelWpsFilter.Controls.Add(Me.WpsFilter_Add1_but)
        Me.PanelWpsFilter.Location = New System.Drawing.Point(4, 46)
        Me.PanelWpsFilter.Name = "PanelWpsFilter"
        Me.PanelWpsFilter.Size = New System.Drawing.Size(875, 484)
        Me.PanelWpsFilter.TabIndex = 2
        '
        'WpsFilter_Scrollbar
        '
        Me.WpsFilter_Scrollbar.Enabled = False
        Me.WpsFilter_Scrollbar.LargeChange = 5
        Me.WpsFilter_Scrollbar.Location = New System.Drawing.Point(7, 434)
        Me.WpsFilter_Scrollbar.Maximum = 50
        Me.WpsFilter_Scrollbar.Minimum = 1
        Me.WpsFilter_Scrollbar.Name = "WpsFilter_Scrollbar"
        Me.WpsFilter_Scrollbar.Size = New System.Drawing.Size(835, 28)
        Me.WpsFilter_Scrollbar.TabIndex = 15
        Me.WpsFilter_Scrollbar.Value = 1
        '
        'WpsFilter_Instel5_but
        '
        Me.WpsFilter_Instel5_but.Enabled = False
        Me.WpsFilter_Instel5_but.Location = New System.Drawing.Point(683, 388)
        Me.WpsFilter_Instel5_but.Name = "WpsFilter_Instel5_but"
        Me.WpsFilter_Instel5_but.Size = New System.Drawing.Size(163, 35)
        Me.WpsFilter_Instel5_but.TabIndex = 14
        Me.WpsFilter_Instel5_but.Text = "Instelling groep 5"
        Me.WpsFilter_Instel5_but.UseVisualStyleBackColor = True
        '
        'WpsFilter_Instel4_but
        '
        Me.WpsFilter_Instel4_but.Enabled = False
        Me.WpsFilter_Instel4_but.Location = New System.Drawing.Point(514, 388)
        Me.WpsFilter_Instel4_but.Name = "WpsFilter_Instel4_but"
        Me.WpsFilter_Instel4_but.Size = New System.Drawing.Size(163, 35)
        Me.WpsFilter_Instel4_but.TabIndex = 13
        Me.WpsFilter_Instel4_but.Text = "Instelling groep 4"
        Me.WpsFilter_Instel4_but.UseVisualStyleBackColor = True
        '
        'WpsFilter_Instel3_but
        '
        Me.WpsFilter_Instel3_but.Enabled = False
        Me.WpsFilter_Instel3_but.Location = New System.Drawing.Point(345, 388)
        Me.WpsFilter_Instel3_but.Name = "WpsFilter_Instel3_but"
        Me.WpsFilter_Instel3_but.Size = New System.Drawing.Size(163, 35)
        Me.WpsFilter_Instel3_but.TabIndex = 12
        Me.WpsFilter_Instel3_but.Text = "Instelling groep 3"
        Me.WpsFilter_Instel3_but.UseVisualStyleBackColor = True
        '
        'WpsFilter_Instel2_but
        '
        Me.WpsFilter_Instel2_but.Enabled = False
        Me.WpsFilter_Instel2_but.Location = New System.Drawing.Point(176, 388)
        Me.WpsFilter_Instel2_but.Name = "WpsFilter_Instel2_but"
        Me.WpsFilter_Instel2_but.Size = New System.Drawing.Size(163, 35)
        Me.WpsFilter_Instel2_but.TabIndex = 11
        Me.WpsFilter_Instel2_but.Text = "Instelling groep 2"
        Me.WpsFilter_Instel2_but.UseVisualStyleBackColor = True
        '
        'WpsFilter_Instel1_but
        '
        Me.WpsFilter_Instel1_but.Enabled = False
        Me.WpsFilter_Instel1_but.Location = New System.Drawing.Point(7, 388)
        Me.WpsFilter_Instel1_but.Name = "WpsFilter_Instel1_but"
        Me.WpsFilter_Instel1_but.Size = New System.Drawing.Size(163, 35)
        Me.WpsFilter_Instel1_but.TabIndex = 10
        Me.WpsFilter_Instel1_but.Text = "Instelling groep 1"
        Me.WpsFilter_Instel1_but.UseVisualStyleBackColor = True
        '
        'WpsFilter_ChkList5_lst
        '
        Me.WpsFilter_ChkList5_lst.CheckOnClick = True
        Me.WpsFilter_ChkList5_lst.FormattingEnabled = True
        Me.WpsFilter_ChkList5_lst.Location = New System.Drawing.Point(683, 48)
        Me.WpsFilter_ChkList5_lst.Name = "WpsFilter_ChkList5_lst"
        Me.WpsFilter_ChkList5_lst.Size = New System.Drawing.Size(163, 334)
        Me.WpsFilter_ChkList5_lst.TabIndex = 9
        '
        'WpsFilter_ChkList4_lst
        '
        Me.WpsFilter_ChkList4_lst.CheckOnClick = True
        Me.WpsFilter_ChkList4_lst.FormattingEnabled = True
        Me.WpsFilter_ChkList4_lst.Location = New System.Drawing.Point(514, 48)
        Me.WpsFilter_ChkList4_lst.Name = "WpsFilter_ChkList4_lst"
        Me.WpsFilter_ChkList4_lst.Size = New System.Drawing.Size(163, 334)
        Me.WpsFilter_ChkList4_lst.TabIndex = 8
        '
        'WpsFilter_ChkList3_lst
        '
        Me.WpsFilter_ChkList3_lst.CheckOnClick = True
        Me.WpsFilter_ChkList3_lst.FormattingEnabled = True
        Me.WpsFilter_ChkList3_lst.Location = New System.Drawing.Point(345, 48)
        Me.WpsFilter_ChkList3_lst.Name = "WpsFilter_ChkList3_lst"
        Me.WpsFilter_ChkList3_lst.Size = New System.Drawing.Size(163, 334)
        Me.WpsFilter_ChkList3_lst.TabIndex = 7
        '
        'WpsFilter_ChkList2_lst
        '
        Me.WpsFilter_ChkList2_lst.CheckOnClick = True
        Me.WpsFilter_ChkList2_lst.FormattingEnabled = True
        Me.WpsFilter_ChkList2_lst.Location = New System.Drawing.Point(176, 48)
        Me.WpsFilter_ChkList2_lst.Name = "WpsFilter_ChkList2_lst"
        Me.WpsFilter_ChkList2_lst.Size = New System.Drawing.Size(163, 334)
        Me.WpsFilter_ChkList2_lst.TabIndex = 6
        '
        'WpsFilter_ChkList1_lst
        '
        Me.WpsFilter_ChkList1_lst.CheckOnClick = True
        Me.WpsFilter_ChkList1_lst.FormattingEnabled = True
        Me.WpsFilter_ChkList1_lst.Location = New System.Drawing.Point(7, 48)
        Me.WpsFilter_ChkList1_lst.Name = "WpsFilter_ChkList1_lst"
        Me.WpsFilter_ChkList1_lst.Size = New System.Drawing.Size(163, 334)
        Me.WpsFilter_ChkList1_lst.TabIndex = 5
        '
        'WpsFilter_Add5_but
        '
        Me.WpsFilter_Add5_but.Enabled = False
        Me.WpsFilter_Add5_but.Location = New System.Drawing.Point(683, 7)
        Me.WpsFilter_Add5_but.Name = "WpsFilter_Add5_but"
        Me.WpsFilter_Add5_but.Size = New System.Drawing.Size(163, 35)
        Me.WpsFilter_Add5_but.TabIndex = 4
        Me.WpsFilter_Add5_but.Text = "+"
        Me.WpsFilter_Add5_but.UseVisualStyleBackColor = True
        '
        'WpsFilter_Add4_but
        '
        Me.WpsFilter_Add4_but.Enabled = False
        Me.WpsFilter_Add4_but.Location = New System.Drawing.Point(514, 7)
        Me.WpsFilter_Add4_but.Name = "WpsFilter_Add4_but"
        Me.WpsFilter_Add4_but.Size = New System.Drawing.Size(163, 35)
        Me.WpsFilter_Add4_but.TabIndex = 3
        Me.WpsFilter_Add4_but.Text = "+"
        Me.WpsFilter_Add4_but.UseVisualStyleBackColor = True
        '
        'WpsFilter_Add3_but
        '
        Me.WpsFilter_Add3_but.Enabled = False
        Me.WpsFilter_Add3_but.Location = New System.Drawing.Point(345, 7)
        Me.WpsFilter_Add3_but.Name = "WpsFilter_Add3_but"
        Me.WpsFilter_Add3_but.Size = New System.Drawing.Size(163, 35)
        Me.WpsFilter_Add3_but.TabIndex = 2
        Me.WpsFilter_Add3_but.Text = "+"
        Me.WpsFilter_Add3_but.UseVisualStyleBackColor = True
        '
        'WpsFilter_Add2_but
        '
        Me.WpsFilter_Add2_but.Enabled = False
        Me.WpsFilter_Add2_but.Location = New System.Drawing.Point(176, 7)
        Me.WpsFilter_Add2_but.Name = "WpsFilter_Add2_but"
        Me.WpsFilter_Add2_but.Size = New System.Drawing.Size(163, 35)
        Me.WpsFilter_Add2_but.TabIndex = 1
        Me.WpsFilter_Add2_but.Text = "+"
        Me.WpsFilter_Add2_but.UseVisualStyleBackColor = True
        '
        'WpsFilter_Add1_but
        '
        Me.WpsFilter_Add1_but.Enabled = False
        Me.WpsFilter_Add1_but.Location = New System.Drawing.Point(7, 7)
        Me.WpsFilter_Add1_but.Name = "WpsFilter_Add1_but"
        Me.WpsFilter_Add1_but.Size = New System.Drawing.Size(163, 35)
        Me.WpsFilter_Add1_but.TabIndex = 0
        Me.WpsFilter_Add1_but.Text = "+"
        Me.WpsFilter_Add1_but.UseVisualStyleBackColor = True
        '
        'WpsFilter_FilterFlex
        '
        Me.WpsFilter_FilterFlex.ColumnInfo = "3,0,0,0,0,85,Columns:0{Width:146;Caption:""Soort"";}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.WpsFilter_FilterFlex.Location = New System.Drawing.Point(4, 576)
        Me.WpsFilter_FilterFlex.Name = "WpsFilter_FilterFlex"
        Me.WpsFilter_FilterFlex.Rows.Count = 1
        Me.WpsFilter_FilterFlex.Rows.DefaultSize = 17
        Me.WpsFilter_FilterFlex.Size = New System.Drawing.Size(875, 360)
        Me.WpsFilter_FilterFlex.TabIndex = 1
        '
        'C1TabInloggen
        '
        Me.C1TabInloggen.Controls.Add(Me.C1SizerInloggen)
        Me.C1TabInloggen.Location = New System.Drawing.Point(1, 24)
        Me.C1TabInloggen.Name = "C1TabInloggen"
        Me.C1TabInloggen.Size = New System.Drawing.Size(883, 940)
        Me.C1TabInloggen.TabIndex = 7
        Me.C1TabInloggen.Text = "Inloggen"
        '
        'C1SizerInloggen
        '
        Me.C1SizerInloggen.Controls.Add(Me.LoginPanelDown)
        Me.C1SizerInloggen.Controls.Add(Me.LoginPanelup)
        Me.C1SizerInloggen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1SizerInloggen.GridDefinition = "19.1489361702128:False:True;79.5744680851064:False:False;" & Global.Microsoft.VisualBasic.ChrW(9) & "99.0939977349943:False:" &
    "False;"
        Me.C1SizerInloggen.Location = New System.Drawing.Point(0, 0)
        Me.C1SizerInloggen.Name = "C1SizerInloggen"
        Me.C1SizerInloggen.Size = New System.Drawing.Size(883, 940)
        Me.C1SizerInloggen.TabIndex = 32
        Me.C1SizerInloggen.Text = "C1Sizer2"
        '
        'LoginPanelDown
        '
        Me.LoginPanelDown.Controls.Add(Me.AgendaFlexGrid)
        Me.LoginPanelDown.Location = New System.Drawing.Point(4, 188)
        Me.LoginPanelDown.Name = "LoginPanelDown"
        Me.LoginPanelDown.Size = New System.Drawing.Size(875, 748)
        Me.LoginPanelDown.TabIndex = 1
        '
        'AgendaFlexGrid
        '
        Me.AgendaFlexGrid.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.AgendaFlexGrid.AllowEditing = False
        Me.AgendaFlexGrid.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.AgendaFlexGrid.ColumnInfo = resources.GetString("AgendaFlexGrid.ColumnInfo")
        Me.AgendaFlexGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AgendaFlexGrid.Location = New System.Drawing.Point(0, 0)
        Me.AgendaFlexGrid.Name = "AgendaFlexGrid"
        Me.AgendaFlexGrid.Rows.Count = 98
        Me.AgendaFlexGrid.Rows.DefaultSize = 17
        Me.AgendaFlexGrid.Size = New System.Drawing.Size(875, 748)
        Me.AgendaFlexGrid.TabIndex = 0
        '
        'LoginPanelup
        '
        Me.LoginPanelup.Controls.Add(Me.Inloglijst_lst)
        Me.LoginPanelup.Controls.Add(Me.Label50)
        Me.LoginPanelup.Controls.Add(Me.Inlog_agenda_invullen_txt)
        Me.LoginPanelup.Controls.Add(Me.Inlog_opslaan_agenda_but)
        Me.LoginPanelup.Controls.Add(Me.Tdebug)
        Me.LoginPanelup.Controls.Add(Me.Inlog_Datum_but)
        Me.LoginPanelup.Controls.Add(Me.InlogAgendaDatum)
        Me.LoginPanelup.Controls.Add(Me.inlogdatum_lbl)
        Me.LoginPanelup.Controls.Add(Me.LoginNaam1_but)
        Me.LoginPanelup.Controls.Add(Me.LoginNaam8_but)
        Me.LoginPanelup.Controls.Add(Me.LoginNaam2_but)
        Me.LoginPanelup.Controls.Add(Me.LoginNaam7_but)
        Me.LoginPanelup.Controls.Add(Me.LoginNaam3_but)
        Me.LoginPanelup.Controls.Add(Me.LoginNaam6_but)
        Me.LoginPanelup.Controls.Add(Me.LoginNaam4_but)
        Me.LoginPanelup.Controls.Add(Me.LoginNaam5_but)
        Me.LoginPanelup.Location = New System.Drawing.Point(4, 4)
        Me.LoginPanelup.Name = "LoginPanelup"
        Me.LoginPanelup.Size = New System.Drawing.Size(875, 180)
        Me.LoginPanelup.TabIndex = 0
        '
        'Inloglijst_lst
        '
        Me.Inloglijst_lst.FormattingEnabled = True
        Me.Inloglijst_lst.Location = New System.Drawing.Point(593, 13)
        Me.Inloglijst_lst.Name = "Inloglijst_lst"
        Me.Inloglijst_lst.Size = New System.Drawing.Size(184, 134)
        Me.Inloglijst_lst.TabIndex = 39
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(315, 141)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(254, 13)
        Me.Label50.TabIndex = 38
        Me.Label50.Text = "Agenda invullen (selecteer datum(s) daarna opslaan)"
        '
        'Inlog_agenda_invullen_txt
        '
        Me.Inlog_agenda_invullen_txt.Location = New System.Drawing.Point(318, 157)
        Me.Inlog_agenda_invullen_txt.Name = "Inlog_agenda_invullen_txt"
        Me.Inlog_agenda_invullen_txt.Size = New System.Drawing.Size(298, 20)
        Me.Inlog_agenda_invullen_txt.TabIndex = 37
        '
        'Inlog_opslaan_agenda_but
        '
        Me.Inlog_opslaan_agenda_but.Location = New System.Drawing.Point(622, 153)
        Me.Inlog_opslaan_agenda_but.Name = "Inlog_opslaan_agenda_but"
        Me.Inlog_opslaan_agenda_but.Size = New System.Drawing.Size(71, 26)
        Me.Inlog_opslaan_agenda_but.TabIndex = 36
        Me.Inlog_opslaan_agenda_but.Text = "Opslaan"
        Me.Inlog_opslaan_agenda_but.UseVisualStyleBackColor = True
        '
        'Tdebug
        '
        Me.Tdebug.AutoSize = True
        Me.Tdebug.Location = New System.Drawing.Point(721, 155)
        Me.Tdebug.Name = "Tdebug"
        Me.Tdebug.Size = New System.Drawing.Size(0, 13)
        Me.Tdebug.TabIndex = 35
        '
        'Inlog_Datum_but
        '
        Me.Inlog_Datum_but.Location = New System.Drawing.Point(233, 155)
        Me.Inlog_Datum_but.Name = "Inlog_Datum_but"
        Me.Inlog_Datum_but.Size = New System.Drawing.Size(39, 22)
        Me.Inlog_Datum_but.TabIndex = 34
        Me.Inlog_Datum_but.Text = "OK"
        Me.Inlog_Datum_but.UseVisualStyleBackColor = True
        '
        'InlogAgendaDatum
        '
        Me.InlogAgendaDatum.Location = New System.Drawing.Point(50, 156)
        Me.InlogAgendaDatum.Name = "InlogAgendaDatum"
        Me.InlogAgendaDatum.Size = New System.Drawing.Size(177, 20)
        Me.InlogAgendaDatum.TabIndex = 33
        '
        'inlogdatum_lbl
        '
        Me.inlogdatum_lbl.AutoSize = True
        Me.inlogdatum_lbl.Location = New System.Drawing.Point(6, 160)
        Me.inlogdatum_lbl.Name = "inlogdatum_lbl"
        Me.inlogdatum_lbl.Size = New System.Drawing.Size(38, 13)
        Me.inlogdatum_lbl.TabIndex = 32
        Me.inlogdatum_lbl.Text = "Datum"
        '
        'LoginNaam1_but
        '
        Me.LoginNaam1_but.Location = New System.Drawing.Point(9, 13)
        Me.LoginNaam1_but.Name = "LoginNaam1_but"
        Me.LoginNaam1_but.Size = New System.Drawing.Size(138, 35)
        Me.LoginNaam1_but.TabIndex = 24
        Me.LoginNaam1_but.Text = "-"
        Me.LoginNaam1_but.UseVisualStyleBackColor = True
        '
        'LoginNaam8_but
        '
        Me.LoginNaam8_but.Location = New System.Drawing.Point(432, 64)
        Me.LoginNaam8_but.Name = "LoginNaam8_but"
        Me.LoginNaam8_but.Size = New System.Drawing.Size(138, 35)
        Me.LoginNaam8_but.TabIndex = 31
        Me.LoginNaam8_but.Text = "-"
        Me.LoginNaam8_but.UseVisualStyleBackColor = True
        '
        'LoginNaam2_but
        '
        Me.LoginNaam2_but.Location = New System.Drawing.Point(149, 13)
        Me.LoginNaam2_but.Name = "LoginNaam2_but"
        Me.LoginNaam2_but.Size = New System.Drawing.Size(138, 35)
        Me.LoginNaam2_but.TabIndex = 25
        Me.LoginNaam2_but.Text = "-"
        Me.LoginNaam2_but.UseVisualStyleBackColor = True
        '
        'LoginNaam7_but
        '
        Me.LoginNaam7_but.Location = New System.Drawing.Point(290, 64)
        Me.LoginNaam7_but.Name = "LoginNaam7_but"
        Me.LoginNaam7_but.Size = New System.Drawing.Size(138, 35)
        Me.LoginNaam7_but.TabIndex = 30
        Me.LoginNaam7_but.Text = "-"
        Me.LoginNaam7_but.UseVisualStyleBackColor = True
        '
        'LoginNaam3_but
        '
        Me.LoginNaam3_but.Location = New System.Drawing.Point(290, 13)
        Me.LoginNaam3_but.Name = "LoginNaam3_but"
        Me.LoginNaam3_but.Size = New System.Drawing.Size(138, 35)
        Me.LoginNaam3_but.TabIndex = 26
        Me.LoginNaam3_but.Text = "-"
        Me.LoginNaam3_but.UseVisualStyleBackColor = True
        '
        'LoginNaam6_but
        '
        Me.LoginNaam6_but.Location = New System.Drawing.Point(149, 66)
        Me.LoginNaam6_but.Name = "LoginNaam6_but"
        Me.LoginNaam6_but.Size = New System.Drawing.Size(138, 33)
        Me.LoginNaam6_but.TabIndex = 29
        Me.LoginNaam6_but.Text = "-"
        Me.LoginNaam6_but.UseVisualStyleBackColor = True
        '
        'LoginNaam4_but
        '
        Me.LoginNaam4_but.Location = New System.Drawing.Point(432, 13)
        Me.LoginNaam4_but.Name = "LoginNaam4_but"
        Me.LoginNaam4_but.Size = New System.Drawing.Size(138, 35)
        Me.LoginNaam4_but.TabIndex = 27
        Me.LoginNaam4_but.Text = "-"
        Me.LoginNaam4_but.UseVisualStyleBackColor = True
        '
        'LoginNaam5_but
        '
        Me.LoginNaam5_but.Location = New System.Drawing.Point(9, 64)
        Me.LoginNaam5_but.Name = "LoginNaam5_but"
        Me.LoginNaam5_but.Size = New System.Drawing.Size(138, 35)
        Me.LoginNaam5_but.TabIndex = 28
        Me.LoginNaam5_but.Text = "-"
        Me.LoginNaam5_but.UseVisualStyleBackColor = True
        '
        'C1NavBar1
        '
        Me.C1NavBar1.Collapsed = False
        Me.C1NavBar1.Controls.Add(Me.C1NavBarPanelOrders)
        Me.C1NavBar1.Controls.Add(Me.C1NavBarFloriday)
        Me.C1NavBar1.Controls.Add(Me.C1NavBarFlorecom)
        Me.C1NavBar1.Controls.Add(Me.C1NavBarPanelDatabase)
        Me.C1NavBar1.Controls.Add(Me.C1NavBarPanelInstellingen)
        Me.C1NavBar1.Controls.Add(Me.C1NavBarPrijzen)
        Me.C1NavBar1.Location = New System.Drawing.Point(376, 4)
        Me.C1NavBar1.Name = "C1NavBar1"
        Me.C1NavBar1.ShowOptionsMenu = False
        Me.C1NavBar1.Size = New System.Drawing.Size(207, 965)
        Me.C1NavBar1.VisualStyle = C1.Win.C1Command.VisualStyle.Office2007Silver
        Me.C1NavBar1.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2007Silver
        '
        'C1NavBarPanelOrders
        '
        Me.C1NavBarPanelOrders.Button.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.C1NavBarPanelOrders.Button.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.C1NavBarPanelOrders.Button.Text = "Orders"
        Me.C1NavBarPanelOrders.Controls.Add(Me.C1NavPanelOrders2)
        Me.C1NavBarPanelOrders.Controls.Add(Me.C1NavPanelOrders1)
        Me.C1NavBarPanelOrders.ID = 1
        Me.C1NavBarPanelOrders.Name = "C1NavBarPanelOrders"
        Me.C1NavBarPanelOrders.Size = New System.Drawing.Size(205, 707)
        '
        'C1NavPanelOrders2
        '
        Me.C1NavPanelOrders2.AutoScroll = True
        Me.C1NavPanelOrders2.Controls.Add(Me.OrdersMenuBekijken)
        Me.C1NavPanelOrders2.Controls.Add(Me.Orders_pakbonnenprinten)
        Me.C1NavPanelOrders2.Controls.Add(Me.OrdersMenuVerzamelkar)
        Me.C1NavPanelOrders2.Controls.Add(Me.Order_PrintBriefFloriday)
        Me.C1NavPanelOrders2.Controls.Add(Me.OrdersMenuAanvulling)
        Me.C1NavPanelOrders2.Controls.Add(Me.Orders_WpsXML_but)
        Me.C1NavPanelOrders2.Controls.Add(Me.Orders_Mark)
        Me.C1NavPanelOrders2.Controls.Add(Me.Orders_WpsKlaar)
        Me.C1NavPanelOrders2.Controls.Add(Me.Orders_SdfVersturen)
        Me.C1NavPanelOrders2.Controls.Add(Me.Orders_WpsVersturen)
        Me.C1NavPanelOrders2.Controls.Add(Me.Orders_Karindeling)
        Me.C1NavPanelOrders2.Controls.Add(Me.Order_zoek_but)
        Me.C1NavPanelOrders2.Controls.Add(Me.Order_zoek_txt)
        Me.C1NavPanelOrders2.Controls.Add(Me.Order_zoeken_chk)
        Me.C1NavPanelOrders2.Controls.Add(Me.OrdersMenuAnnuleren)
        Me.C1NavPanelOrders2.Controls.Add(Me.OrdersMenuSamenvoegen)
        Me.C1NavPanelOrders2.Controls.Add(Me.OrdersMenuAanpassen)
        Me.C1NavPanelOrders2.Controls.Add(Me.OrdersMenuNieuw)
        Me.C1NavPanelOrders2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1NavPanelOrders2.Location = New System.Drawing.Point(0, 196)
        Me.C1NavPanelOrders2.Name = "C1NavPanelOrders2"
        Me.C1NavPanelOrders2.Size = New System.Drawing.Size(205, 511)
        Me.C1NavPanelOrders2.TabIndex = 1
        '
        'OrdersMenuBekijken
        '
        Me.OrdersMenuBekijken.Location = New System.Drawing.Point(21, 220)
        Me.OrdersMenuBekijken.Name = "OrdersMenuBekijken"
        Me.OrdersMenuBekijken.Size = New System.Drawing.Size(162, 32)
        Me.OrdersMenuBekijken.TabIndex = 20
        Me.OrdersMenuBekijken.Text = "Order bekijken"
        Me.OrdersMenuBekijken.UseVisualStyleBackColor = True
        '
        'Orders_pakbonnenprinten
        '
        Me.Orders_pakbonnenprinten.Location = New System.Drawing.Point(108, 85)
        Me.Orders_pakbonnenprinten.Name = "Orders_pakbonnenprinten"
        Me.Orders_pakbonnenprinten.Size = New System.Drawing.Size(77, 32)
        Me.Orders_pakbonnenprinten.TabIndex = 19
        Me.Orders_pakbonnenprinten.Text = "Pakbon pr."
        Me.Orders_pakbonnenprinten.UseVisualStyleBackColor = True
        '
        'OrdersMenuVerzamelkar
        '
        Me.OrdersMenuVerzamelkar.Location = New System.Drawing.Point(19, 443)
        Me.OrdersMenuVerzamelkar.Name = "OrdersMenuVerzamelkar"
        Me.OrdersMenuVerzamelkar.Size = New System.Drawing.Size(163, 32)
        Me.OrdersMenuVerzamelkar.TabIndex = 18
        Me.OrdersMenuVerzamelkar.Text = "Toevoegen aan Verzamel kar"
        Me.OrdersMenuVerzamelkar.UseVisualStyleBackColor = True
        '
        'Order_PrintBriefFloriday
        '
        Me.Order_PrintBriefFloriday.Location = New System.Drawing.Point(22, 193)
        Me.Order_PrintBriefFloriday.Name = "Order_PrintBriefFloriday"
        Me.Order_PrintBriefFloriday.Size = New System.Drawing.Size(163, 21)
        Me.Order_PrintBriefFloriday.TabIndex = 17
        Me.Order_PrintBriefFloriday.Text = "Print Brief Floriday"
        Me.Order_PrintBriefFloriday.UseVisualStyleBackColor = True
        '
        'OrdersMenuAanvulling
        '
        Me.OrdersMenuAanvulling.Location = New System.Drawing.Point(20, 371)
        Me.OrdersMenuAanvulling.Name = "OrdersMenuAanvulling"
        Me.OrdersMenuAanvulling.Size = New System.Drawing.Size(162, 28)
        Me.OrdersMenuAanvulling.TabIndex = 16
        Me.OrdersMenuAanvulling.Text = "Aanvulling"
        Me.OrdersMenuAanvulling.UseVisualStyleBackColor = True
        '
        'Orders_WpsXML_but
        '
        Me.Orders_WpsXML_but.Location = New System.Drawing.Point(22, 47)
        Me.Orders_WpsXML_but.Name = "Orders_WpsXML_but"
        Me.Orders_WpsXML_but.Size = New System.Drawing.Size(162, 32)
        Me.Orders_WpsXML_but.TabIndex = 15
        Me.Orders_WpsXML_but.Text = "WPS XML"
        Me.Orders_WpsXML_but.UseVisualStyleBackColor = True
        '
        'Orders_Mark
        '
        Me.Orders_Mark.Location = New System.Drawing.Point(108, 123)
        Me.Orders_Mark.Name = "Orders_Mark"
        Me.Orders_Mark.Size = New System.Drawing.Size(77, 32)
        Me.Orders_Mark.TabIndex = 13
        Me.Orders_Mark.Text = "Markeer"
        Me.Orders_Mark.UseVisualStyleBackColor = True
        '
        'Orders_WpsKlaar
        '
        Me.Orders_WpsKlaar.Location = New System.Drawing.Point(22, 123)
        Me.Orders_WpsKlaar.Name = "Orders_WpsKlaar"
        Me.Orders_WpsKlaar.Size = New System.Drawing.Size(77, 32)
        Me.Orders_WpsKlaar.TabIndex = 12
        Me.Orders_WpsKlaar.Text = "Wps klaar"
        Me.Orders_WpsKlaar.UseVisualStyleBackColor = True
        '
        'Orders_SdfVersturen
        '
        Me.Orders_SdfVersturen.Location = New System.Drawing.Point(24, 161)
        Me.Orders_SdfVersturen.Name = "Orders_SdfVersturen"
        Me.Orders_SdfVersturen.Size = New System.Drawing.Size(161, 26)
        Me.Orders_SdfVersturen.TabIndex = 11
        Me.Orders_SdfVersturen.Text = "Sdf verstuur"
        Me.Orders_SdfVersturen.UseVisualStyleBackColor = True
        '
        'Orders_WpsVersturen
        '
        Me.Orders_WpsVersturen.Location = New System.Drawing.Point(22, 85)
        Me.Orders_WpsVersturen.Name = "Orders_WpsVersturen"
        Me.Orders_WpsVersturen.Size = New System.Drawing.Size(77, 32)
        Me.Orders_WpsVersturen.TabIndex = 10
        Me.Orders_WpsVersturen.Text = "Wps Handm"
        Me.Orders_WpsVersturen.UseVisualStyleBackColor = True
        '
        'Orders_Karindeling
        '
        Me.Orders_Karindeling.Location = New System.Drawing.Point(20, 258)
        Me.Orders_Karindeling.Name = "Orders_Karindeling"
        Me.Orders_Karindeling.Size = New System.Drawing.Size(163, 32)
        Me.Orders_Karindeling.TabIndex = 9
        Me.Orders_Karindeling.Text = "Karindeling"
        Me.Orders_Karindeling.UseVisualStyleBackColor = True
        '
        'Order_zoek_but
        '
        Me.Order_zoek_but.Location = New System.Drawing.Point(22, 508)
        Me.Order_zoek_but.Name = "Order_zoek_but"
        Me.Order_zoek_but.Size = New System.Drawing.Size(160, 25)
        Me.Order_zoek_but.TabIndex = 7
        Me.Order_zoek_but.Text = "Zoek"
        Me.Order_zoek_but.UseVisualStyleBackColor = True
        '
        'Order_zoek_txt
        '
        Me.Order_zoek_txt.Location = New System.Drawing.Point(90, 481)
        Me.Order_zoek_txt.Name = "Order_zoek_txt"
        Me.Order_zoek_txt.Size = New System.Drawing.Size(93, 20)
        Me.Order_zoek_txt.TabIndex = 6
        '
        'Order_zoeken_chk
        '
        Me.Order_zoeken_chk.AutoSize = True
        Me.Order_zoeken_chk.Location = New System.Drawing.Point(22, 481)
        Me.Order_zoeken_chk.Name = "Order_zoeken_chk"
        Me.Order_zoeken_chk.Size = New System.Drawing.Size(63, 17)
        Me.Order_zoeken_chk.TabIndex = 5
        Me.Order_zoeken_chk.Text = "Zoeken"
        Me.Order_zoeken_chk.UseVisualStyleBackColor = True
        '
        'OrdersMenuAnnuleren
        '
        Me.OrdersMenuAnnuleren.Location = New System.Drawing.Point(20, 405)
        Me.OrdersMenuAnnuleren.Name = "OrdersMenuAnnuleren"
        Me.OrdersMenuAnnuleren.Size = New System.Drawing.Size(163, 32)
        Me.OrdersMenuAnnuleren.TabIndex = 3
        Me.OrdersMenuAnnuleren.Text = "Order annuleren"
        Me.OrdersMenuAnnuleren.UseVisualStyleBackColor = True
        '
        'OrdersMenuSamenvoegen
        '
        Me.OrdersMenuSamenvoegen.Location = New System.Drawing.Point(20, 334)
        Me.OrdersMenuSamenvoegen.Name = "OrdersMenuSamenvoegen"
        Me.OrdersMenuSamenvoegen.Size = New System.Drawing.Size(162, 31)
        Me.OrdersMenuSamenvoegen.TabIndex = 2
        Me.OrdersMenuSamenvoegen.Text = "Orders samenvoegen"
        Me.OrdersMenuSamenvoegen.UseVisualStyleBackColor = True
        '
        'OrdersMenuAanpassen
        '
        Me.OrdersMenuAanpassen.Location = New System.Drawing.Point(20, 296)
        Me.OrdersMenuAanpassen.Name = "OrdersMenuAanpassen"
        Me.OrdersMenuAanpassen.Size = New System.Drawing.Size(162, 32)
        Me.OrdersMenuAanpassen.TabIndex = 1
        Me.OrdersMenuAanpassen.Text = "Order aanpassen"
        Me.OrdersMenuAanpassen.UseVisualStyleBackColor = True
        '
        'OrdersMenuNieuw
        '
        Me.OrdersMenuNieuw.Location = New System.Drawing.Point(22, 11)
        Me.OrdersMenuNieuw.Name = "OrdersMenuNieuw"
        Me.OrdersMenuNieuw.Size = New System.Drawing.Size(163, 32)
        Me.OrdersMenuNieuw.TabIndex = 0
        Me.OrdersMenuNieuw.Text = "Nieuwe order"
        Me.OrdersMenuNieuw.UseVisualStyleBackColor = True
        '
        'C1NavPanelOrders1
        '
        Me.C1NavPanelOrders1.Controls.Add(Me.Order_MonthCalendar)
        Me.C1NavPanelOrders1.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1NavPanelOrders1.Location = New System.Drawing.Point(0, 0)
        Me.C1NavPanelOrders1.Name = "C1NavPanelOrders1"
        Me.C1NavPanelOrders1.Size = New System.Drawing.Size(205, 196)
        Me.C1NavPanelOrders1.TabIndex = 0
        '
        'Order_MonthCalendar
        '
        Me.Order_MonthCalendar.Location = New System.Drawing.Point(20, 19)
        Me.Order_MonthCalendar.MaxSelectionCount = 60
        Me.Order_MonthCalendar.Name = "Order_MonthCalendar"
        Me.Order_MonthCalendar.ShowWeekNumbers = True
        Me.Order_MonthCalendar.TabIndex = 0
        '
        'C1NavBarFloriday
        '
        Me.C1NavBarFloriday.Button.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.C1NavBarFloriday.Button.Text = "Floriday"
        Me.C1NavBarFloriday.Controls.Add(Me.FdMenu_Nietverwerken_but)
        Me.C1NavBarFloriday.Controls.Add(Me.FdMenu_ordernr_chk)
        Me.C1NavBarFloriday.Controls.Add(Me.fd_updatelist_but)
        Me.C1NavBarFloriday.Controls.Add(Me.Fd_archief_rb)
        Me.C1NavBarFloriday.Controls.Add(Me.Fd_nieuweOrders_rb)
        Me.C1NavBarFloriday.Controls.Add(Me.Floriday_Calendar)
        Me.C1NavBarFloriday.Controls.Add(Me.FdMenu_Zoek_chk)
        Me.C1NavBarFloriday.Controls.Add(Me.FdMenu_Zoek_txt)
        Me.C1NavBarFloriday.Controls.Add(Me.FdMenu_floridaynr_txt)
        Me.C1NavBarFloriday.Controls.Add(Me.FdMenu_Verwerk_but)
        Me.C1NavBarFloriday.ID = 6
        Me.C1NavBarFloriday.Name = "C1NavBarFloriday"
        Me.C1NavBarFloriday.Size = New System.Drawing.Size(205, 707)
        '
        'FdMenu_Nietverwerken_but
        '
        Me.FdMenu_Nietverwerken_but.Location = New System.Drawing.Point(46, 620)
        Me.FdMenu_Nietverwerken_but.Name = "FdMenu_Nietverwerken_but"
        Me.FdMenu_Nietverwerken_but.Size = New System.Drawing.Size(107, 48)
        Me.FdMenu_Nietverwerken_but.TabIndex = 25
        Me.FdMenu_Nietverwerken_but.Text = "Niet verwerken via floriday"
        Me.FdMenu_Nietverwerken_but.UseVisualStyleBackColor = True
        '
        'FdMenu_ordernr_chk
        '
        Me.FdMenu_ordernr_chk.AutoSize = True
        Me.FdMenu_ordernr_chk.Location = New System.Drawing.Point(4, 245)
        Me.FdMenu_ordernr_chk.Name = "FdMenu_ordernr_chk"
        Me.FdMenu_ordernr_chk.Size = New System.Drawing.Size(77, 17)
        Me.FdMenu_ordernr_chk.TabIndex = 24
        Me.FdMenu_ordernr_chk.Text = "Fd ordernr:"
        Me.FdMenu_ordernr_chk.UseVisualStyleBackColor = True
        '
        'fd_updatelist_but
        '
        Me.fd_updatelist_but.Location = New System.Drawing.Point(4, 268)
        Me.fd_updatelist_but.Name = "fd_updatelist_but"
        Me.fd_updatelist_but.Size = New System.Drawing.Size(198, 28)
        Me.fd_updatelist_but.TabIndex = 23
        Me.fd_updatelist_but.Text = "Update"
        Me.fd_updatelist_but.UseVisualStyleBackColor = True
        '
        'Fd_archief_rb
        '
        Me.Fd_archief_rb.AutoSize = True
        Me.Fd_archief_rb.Location = New System.Drawing.Point(138, 184)
        Me.Fd_archief_rb.Name = "Fd_archief_rb"
        Me.Fd_archief_rb.Size = New System.Drawing.Size(58, 17)
        Me.Fd_archief_rb.TabIndex = 22
        Me.Fd_archief_rb.Text = "Archief"
        Me.Fd_archief_rb.UseVisualStyleBackColor = True
        '
        'Fd_nieuweOrders_rb
        '
        Me.Fd_nieuweOrders_rb.AutoSize = True
        Me.Fd_nieuweOrders_rb.Checked = True
        Me.Fd_nieuweOrders_rb.Location = New System.Drawing.Point(13, 184)
        Me.Fd_nieuweOrders_rb.Name = "Fd_nieuweOrders_rb"
        Me.Fd_nieuweOrders_rb.Size = New System.Drawing.Size(93, 17)
        Me.Fd_nieuweOrders_rb.TabIndex = 21
        Me.Fd_nieuweOrders_rb.TabStop = True
        Me.Fd_nieuweOrders_rb.Text = "Nieuwe orders"
        Me.Fd_nieuweOrders_rb.UseVisualStyleBackColor = True
        '
        'Floriday_Calendar
        '
        Me.Floriday_Calendar.Location = New System.Drawing.Point(13, 9)
        Me.Floriday_Calendar.Name = "Floriday_Calendar"
        Me.Floriday_Calendar.ShowWeekNumbers = True
        Me.Floriday_Calendar.TabIndex = 20
        '
        'FdMenu_Zoek_chk
        '
        Me.FdMenu_Zoek_chk.AutoSize = True
        Me.FdMenu_Zoek_chk.Location = New System.Drawing.Point(4, 219)
        Me.FdMenu_Zoek_chk.Name = "FdMenu_Zoek_chk"
        Me.FdMenu_Zoek_chk.Size = New System.Drawing.Size(84, 17)
        Me.FdMenu_Zoek_chk.TabIndex = 19
        Me.FdMenu_Zoek_chk.Text = "Zoek koper:"
        Me.FdMenu_Zoek_chk.UseVisualStyleBackColor = True
        '
        'FdMenu_Zoek_txt
        '
        Me.FdMenu_Zoek_txt.Location = New System.Drawing.Point(94, 217)
        Me.FdMenu_Zoek_txt.Name = "FdMenu_Zoek_txt"
        Me.FdMenu_Zoek_txt.Size = New System.Drawing.Size(108, 20)
        Me.FdMenu_Zoek_txt.TabIndex = 18
        '
        'FdMenu_floridaynr_txt
        '
        Me.FdMenu_floridaynr_txt.Location = New System.Drawing.Point(94, 243)
        Me.FdMenu_floridaynr_txt.Name = "FdMenu_floridaynr_txt"
        Me.FdMenu_floridaynr_txt.Size = New System.Drawing.Size(108, 20)
        Me.FdMenu_floridaynr_txt.TabIndex = 17
        '
        'FdMenu_Verwerk_but
        '
        Me.FdMenu_Verwerk_but.Location = New System.Drawing.Point(4, 367)
        Me.FdMenu_Verwerk_but.Name = "FdMenu_Verwerk_but"
        Me.FdMenu_Verwerk_but.Size = New System.Drawing.Size(198, 39)
        Me.FdMenu_Verwerk_but.TabIndex = 15
        Me.FdMenu_Verwerk_but.Text = "Verwerk"
        Me.FdMenu_Verwerk_but.UseVisualStyleBackColor = True
        '
        'C1NavBarFlorecom
        '
        Me.C1NavBarFlorecom.Button.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
        Me.C1NavBarFlorecom.Button.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.C1NavBarFlorecom.Button.SmallImage = CType(resources.GetObject("resource.SmallImage"), System.Drawing.Image)
        Me.C1NavBarFlorecom.Button.Text = "Florecom"
        Me.C1NavBarFlorecom.Controls.Add(Me.C1NavPanelFlorecom)
        Me.C1NavBarFlorecom.ID = 5
        Me.C1NavBarFlorecom.Name = "C1NavBarFlorecom"
        Me.C1NavBarFlorecom.Size = New System.Drawing.Size(205, 707)
        '
        'C1NavPanelFlorecom
        '
        Me.C1NavPanelFlorecom.Controls.Add(Me.FCMenu_Nietverwerken_but)
        Me.C1NavPanelFlorecom.Controls.Add(Me.FcMenu_fczoek_chk)
        Me.C1NavPanelFlorecom.Controls.Add(Me.FcMenu_fczoek_txt)
        Me.C1NavPanelFlorecom.Controls.Add(Me.FcMenu_fcnummer_txt)
        Me.C1NavPanelFlorecom.Controls.Add(Me.FcMenu_fcnummer_lbl)
        Me.C1NavPanelFlorecom.Controls.Add(Me.FcMenu_Verwerk_but)
        Me.C1NavPanelFlorecom.Controls.Add(Me.FcMenu_Archief)
        Me.C1NavPanelFlorecom.Controls.Add(Me.Fc_DateTimePicker)
        Me.C1NavPanelFlorecom.Controls.Add(Me.FcMenu_vandaag_but)
        Me.C1NavPanelFlorecom.Controls.Add(Me.FcMenu_nieuw_but)
        Me.C1NavPanelFlorecom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1NavPanelFlorecom.Location = New System.Drawing.Point(0, 0)
        Me.C1NavPanelFlorecom.Name = "C1NavPanelFlorecom"
        Me.C1NavPanelFlorecom.Size = New System.Drawing.Size(205, 707)
        Me.C1NavPanelFlorecom.TabIndex = 0
        '
        'FCMenu_Nietverwerken_but
        '
        Me.FCMenu_Nietverwerken_but.Location = New System.Drawing.Point(33, 574)
        Me.FCMenu_Nietverwerken_but.Name = "FCMenu_Nietverwerken_but"
        Me.FCMenu_Nietverwerken_but.Size = New System.Drawing.Size(141, 39)
        Me.FCMenu_Nietverwerken_but.TabIndex = 11
        Me.FCMenu_Nietverwerken_but.Text = "Florecom niet verwerken (verwerking via Floriday)"
        Me.FCMenu_Nietverwerken_but.UseVisualStyleBackColor = True
        '
        'FcMenu_fczoek_chk
        '
        Me.FcMenu_fczoek_chk.AutoSize = True
        Me.FcMenu_fczoek_chk.Location = New System.Drawing.Point(33, 124)
        Me.FcMenu_fczoek_chk.Name = "FcMenu_fczoek_chk"
        Me.FcMenu_fczoek_chk.Size = New System.Drawing.Size(54, 17)
        Me.FcMenu_fczoek_chk.TabIndex = 10
        Me.FcMenu_fczoek_chk.Text = "Zoek:"
        Me.FcMenu_fczoek_chk.UseVisualStyleBackColor = True
        '
        'FcMenu_fczoek_txt
        '
        Me.FcMenu_fczoek_txt.Location = New System.Drawing.Point(101, 122)
        Me.FcMenu_fczoek_txt.Name = "FcMenu_fczoek_txt"
        Me.FcMenu_fczoek_txt.Size = New System.Drawing.Size(75, 20)
        Me.FcMenu_fczoek_txt.TabIndex = 9
        '
        'FcMenu_fcnummer_txt
        '
        Me.FcMenu_fcnummer_txt.Location = New System.Drawing.Point(101, 148)
        Me.FcMenu_fcnummer_txt.Name = "FcMenu_fcnummer_txt"
        Me.FcMenu_fcnummer_txt.Size = New System.Drawing.Size(75, 20)
        Me.FcMenu_fcnummer_txt.TabIndex = 6
        '
        'FcMenu_fcnummer_lbl
        '
        Me.FcMenu_fcnummer_lbl.AutoSize = True
        Me.FcMenu_fcnummer_lbl.Location = New System.Drawing.Point(30, 151)
        Me.FcMenu_fcnummer_lbl.Name = "FcMenu_fcnummer_lbl"
        Me.FcMenu_fcnummer_lbl.Size = New System.Drawing.Size(65, 13)
        Me.FcMenu_fcnummer_lbl.TabIndex = 5
        Me.FcMenu_fcnummer_lbl.Text = "Florecom nr:"
        '
        'FcMenu_Verwerk_but
        '
        Me.FcMenu_Verwerk_but.Location = New System.Drawing.Point(37, 266)
        Me.FcMenu_Verwerk_but.Name = "FcMenu_Verwerk_but"
        Me.FcMenu_Verwerk_but.Size = New System.Drawing.Size(141, 39)
        Me.FcMenu_Verwerk_but.TabIndex = 4
        Me.FcMenu_Verwerk_but.Text = "Verwerk"
        Me.FcMenu_Verwerk_but.UseVisualStyleBackColor = True
        '
        'FcMenu_Archief
        '
        Me.FcMenu_Archief.Location = New System.Drawing.Point(35, 200)
        Me.FcMenu_Archief.Name = "FcMenu_Archief"
        Me.FcMenu_Archief.Size = New System.Drawing.Size(141, 31)
        Me.FcMenu_Archief.TabIndex = 3
        Me.FcMenu_Archief.Text = "Archief"
        Me.FcMenu_Archief.UseVisualStyleBackColor = True
        '
        'Fc_DateTimePicker
        '
        Me.Fc_DateTimePicker.Location = New System.Drawing.Point(35, 174)
        Me.Fc_DateTimePicker.Name = "Fc_DateTimePicker"
        Me.Fc_DateTimePicker.Size = New System.Drawing.Size(143, 20)
        Me.Fc_DateTimePicker.TabIndex = 2
        '
        'FcMenu_vandaag_but
        '
        Me.FcMenu_vandaag_but.Location = New System.Drawing.Point(33, 67)
        Me.FcMenu_vandaag_but.Name = "FcMenu_vandaag_but"
        Me.FcMenu_vandaag_but.Size = New System.Drawing.Size(141, 31)
        Me.FcMenu_vandaag_but.TabIndex = 1
        Me.FcMenu_vandaag_but.Text = "Archief Vandaag"
        Me.FcMenu_vandaag_but.UseVisualStyleBackColor = True
        '
        'FcMenu_nieuw_but
        '
        Me.FcMenu_nieuw_but.Location = New System.Drawing.Point(33, 23)
        Me.FcMenu_nieuw_but.Name = "FcMenu_nieuw_but"
        Me.FcMenu_nieuw_but.Size = New System.Drawing.Size(141, 38)
        Me.FcMenu_nieuw_but.TabIndex = 0
        Me.FcMenu_nieuw_but.Text = "Nieuwe florecom's ophalen"
        Me.FcMenu_nieuw_but.UseVisualStyleBackColor = True
        '
        'C1NavBarPanelDatabase
        '
        Me.C1NavBarPanelDatabase.Button.Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
        Me.C1NavBarPanelDatabase.Button.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.C1NavBarPanelDatabase.Button.SmallImage = CType(resources.GetObject("resource.SmallImage1"), System.Drawing.Image)
        Me.C1NavBarPanelDatabase.Button.Text = "Database"
        Me.C1NavBarPanelDatabase.Controls.Add(Me.C1NavPanelDatabase1)
        Me.C1NavBarPanelDatabase.ID = 2
        Me.C1NavBarPanelDatabase.Name = "C1NavBarPanelDatabase"
        Me.C1NavBarPanelDatabase.Size = New System.Drawing.Size(205, 707)
        '
        'C1NavPanelDatabase1
        '
        Me.C1NavPanelDatabase1.Controls.Add(Me.DBOverzichten_but)
        Me.C1NavPanelDatabase1.Controls.Add(Me.DatabaseMenuCopy_but)
        Me.C1NavPanelDatabase1.Controls.Add(Me.DatabaseMenuHerladen_but)
        Me.C1NavPanelDatabase1.Controls.Add(Me.Database_preselect_cmb)
        Me.C1NavPanelDatabase1.Controls.Add(Me.DatabaseMenuSDFPL_but)
        Me.C1NavPanelDatabase1.Controls.Add(Me.database_lbl)
        Me.C1NavPanelDatabase1.Controls.Add(Me.DatabaseMenuOpslaan)
        Me.C1NavPanelDatabase1.Controls.Add(Me.DatabaseMenuAanpassen)
        Me.C1NavPanelDatabase1.Controls.Add(Me.DatabaseMenuNieuw)
        Me.C1NavPanelDatabase1.Controls.Add(Me.Database_Combo)
        Me.C1NavPanelDatabase1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1NavPanelDatabase1.Location = New System.Drawing.Point(0, 0)
        Me.C1NavPanelDatabase1.Name = "C1NavPanelDatabase1"
        Me.C1NavPanelDatabase1.Size = New System.Drawing.Size(205, 707)
        Me.C1NavPanelDatabase1.TabIndex = 0
        '
        'DBOverzichten_but
        '
        Me.DBOverzichten_but.Location = New System.Drawing.Point(15, 407)
        Me.DBOverzichten_but.Name = "DBOverzichten_but"
        Me.DBOverzichten_but.Size = New System.Drawing.Size(174, 35)
        Me.DBOverzichten_but.TabIndex = 14
        Me.DBOverzichten_but.Text = "Overzichten"
        Me.DBOverzichten_but.UseVisualStyleBackColor = True
        Me.DBOverzichten_but.Visible = False
        '
        'DatabaseMenuCopy_but
        '
        Me.DatabaseMenuCopy_but.Location = New System.Drawing.Point(14, 216)
        Me.DatabaseMenuCopy_but.Name = "DatabaseMenuCopy_but"
        Me.DatabaseMenuCopy_but.Size = New System.Drawing.Size(175, 35)
        Me.DatabaseMenuCopy_but.TabIndex = 13
        Me.DatabaseMenuCopy_but.Text = "Copy"
        Me.DatabaseMenuCopy_but.UseVisualStyleBackColor = True
        Me.DatabaseMenuCopy_but.Visible = False
        '
        'DatabaseMenuHerladen_but
        '
        Me.DatabaseMenuHerladen_but.Location = New System.Drawing.Point(14, 93)
        Me.DatabaseMenuHerladen_but.Name = "DatabaseMenuHerladen_but"
        Me.DatabaseMenuHerladen_but.Size = New System.Drawing.Size(175, 35)
        Me.DatabaseMenuHerladen_but.TabIndex = 12
        Me.DatabaseMenuHerladen_but.Text = "Herladen"
        Me.DatabaseMenuHerladen_but.UseVisualStyleBackColor = True
        Me.DatabaseMenuHerladen_but.Visible = False
        '
        'Database_preselect_cmb
        '
        Me.Database_preselect_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Database_preselect_cmb.FormattingEnabled = True
        Me.Database_preselect_cmb.Items.AddRange(New Object() {"Accessoires", "Accessoire prijzen", "Agenda", "Fusten", "Favorieten", "Kopers", "Koper alias", "Kopersgroepen", "Mixen naam", "Mixen vullen", "Mix lagen", "Soorten", "Soortgroepen", "Soort volgorde", "Florecom soortmatch opm", "Florecom soortmatch -", "Fust categorie vullen", "Hoes categorie vullen", "Kwekerscode", "Prijslijst J&P importeren", "Prijslijst kortingtabel", "Prijslijst koppelingen"})
        Me.Database_preselect_cmb.Location = New System.Drawing.Point(15, 49)
        Me.Database_preselect_cmb.MaxDropDownItems = 16
        Me.Database_preselect_cmb.Name = "Database_preselect_cmb"
        Me.Database_preselect_cmb.Size = New System.Drawing.Size(174, 21)
        Me.Database_preselect_cmb.TabIndex = 11
        Me.Database_preselect_cmb.Visible = False
        '
        'DatabaseMenuSDFPL_but
        '
        Me.DatabaseMenuSDFPL_but.Location = New System.Drawing.Point(15, 366)
        Me.DatabaseMenuSDFPL_but.Name = "DatabaseMenuSDFPL_but"
        Me.DatabaseMenuSDFPL_but.Size = New System.Drawing.Size(174, 35)
        Me.DatabaseMenuSDFPL_but.TabIndex = 5
        Me.DatabaseMenuSDFPL_but.Text = "SDF Prijslijst importeren"
        Me.DatabaseMenuSDFPL_but.UseVisualStyleBackColor = True
        Me.DatabaseMenuSDFPL_but.Visible = False
        '
        'database_lbl
        '
        Me.database_lbl.AutoSize = True
        Me.database_lbl.Location = New System.Drawing.Point(51, 75)
        Me.database_lbl.Name = "database_lbl"
        Me.database_lbl.Size = New System.Drawing.Size(94, 13)
        Me.database_lbl.TabIndex = 4
        Me.database_lbl.Text = "Maak een selectie"
        '
        'DatabaseMenuOpslaan
        '
        Me.DatabaseMenuOpslaan.Location = New System.Drawing.Point(14, 257)
        Me.DatabaseMenuOpslaan.Name = "DatabaseMenuOpslaan"
        Me.DatabaseMenuOpslaan.Size = New System.Drawing.Size(175, 35)
        Me.DatabaseMenuOpslaan.TabIndex = 3
        Me.DatabaseMenuOpslaan.Text = "Opslaan"
        Me.DatabaseMenuOpslaan.UseVisualStyleBackColor = True
        Me.DatabaseMenuOpslaan.Visible = False
        '
        'DatabaseMenuAanpassen
        '
        Me.DatabaseMenuAanpassen.Location = New System.Drawing.Point(14, 175)
        Me.DatabaseMenuAanpassen.Name = "DatabaseMenuAanpassen"
        Me.DatabaseMenuAanpassen.Size = New System.Drawing.Size(175, 35)
        Me.DatabaseMenuAanpassen.TabIndex = 2
        Me.DatabaseMenuAanpassen.Text = "Aanpassen"
        Me.DatabaseMenuAanpassen.UseVisualStyleBackColor = True
        Me.DatabaseMenuAanpassen.Visible = False
        '
        'DatabaseMenuNieuw
        '
        Me.DatabaseMenuNieuw.Location = New System.Drawing.Point(14, 134)
        Me.DatabaseMenuNieuw.Name = "DatabaseMenuNieuw"
        Me.DatabaseMenuNieuw.Size = New System.Drawing.Size(175, 35)
        Me.DatabaseMenuNieuw.TabIndex = 1
        Me.DatabaseMenuNieuw.Text = "Nieuw"
        Me.DatabaseMenuNieuw.UseVisualStyleBackColor = True
        Me.DatabaseMenuNieuw.Visible = False
        '
        'Database_Combo
        '
        Me.Database_Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Database_Combo.FormattingEnabled = True
        Me.Database_Combo.Items.AddRange(New Object() {"Favorieten", "Kopersgroepen", "Mixen naam", "Mixen vullen", "Mix lagen", "Soortgroepen", "Soort volgorde", "Fust categorie vullen", "Hoes categorie vullen", "Kwekerscode", "Prijslijst J&P importeren", "Prijslijst kortingtabel", "Prijslijst koppelingen"})
        Me.Database_Combo.Location = New System.Drawing.Point(14, 22)
        Me.Database_Combo.MaxDropDownItems = 16
        Me.Database_Combo.Name = "Database_Combo"
        Me.Database_Combo.Size = New System.Drawing.Size(175, 21)
        Me.Database_Combo.TabIndex = 0
        '
        'C1NavBarPanelInstellingen
        '
        Me.C1NavBarPanelInstellingen.Button.Image = CType(resources.GetObject("resource.Image4"), System.Drawing.Image)
        Me.C1NavBarPanelInstellingen.Button.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.C1NavBarPanelInstellingen.Button.SmallImage = CType(resources.GetObject("resource.SmallImage2"), System.Drawing.Image)
        Me.C1NavBarPanelInstellingen.Button.Text = "Instellingen"
        Me.C1NavBarPanelInstellingen.Controls.Add(Me.C1NavPanelInstel)
        Me.C1NavBarPanelInstellingen.ID = 3
        Me.C1NavBarPanelInstellingen.Name = "C1NavBarPanelInstellingen"
        Me.C1NavBarPanelInstellingen.Size = New System.Drawing.Size(205, 707)
        '
        'C1NavPanelInstel
        '
        Me.C1NavPanelInstel.Controls.Add(Me.Inst_run_update_but)
        Me.C1NavPanelInstel.Controls.Add(Me.Settings_Cancel_But)
        Me.C1NavPanelInstel.Controls.Add(Me.Settings_Save_But)
        Me.C1NavPanelInstel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1NavPanelInstel.Location = New System.Drawing.Point(0, 0)
        Me.C1NavPanelInstel.Name = "C1NavPanelInstel"
        Me.C1NavPanelInstel.Size = New System.Drawing.Size(205, 707)
        Me.C1NavPanelInstel.TabIndex = 0
        '
        'Inst_run_update_but
        '
        Me.Inst_run_update_but.Location = New System.Drawing.Point(16, 167)
        Me.Inst_run_update_but.Name = "Inst_run_update_but"
        Me.Inst_run_update_but.Size = New System.Drawing.Size(170, 45)
        Me.Inst_run_update_but.TabIndex = 2
        Me.Inst_run_update_but.Text = "Update boek"
        Me.Inst_run_update_but.UseVisualStyleBackColor = True
        '
        'Settings_Cancel_But
        '
        Me.Settings_Cancel_But.Location = New System.Drawing.Point(16, 76)
        Me.Settings_Cancel_But.Name = "Settings_Cancel_But"
        Me.Settings_Cancel_But.Size = New System.Drawing.Size(170, 34)
        Me.Settings_Cancel_But.TabIndex = 1
        Me.Settings_Cancel_But.Text = "Annuleren"
        Me.Settings_Cancel_But.UseVisualStyleBackColor = True
        '
        'Settings_Save_But
        '
        Me.Settings_Save_But.Location = New System.Drawing.Point(16, 24)
        Me.Settings_Save_But.Name = "Settings_Save_But"
        Me.Settings_Save_But.Size = New System.Drawing.Size(170, 34)
        Me.Settings_Save_But.TabIndex = 0
        Me.Settings_Save_But.Text = "Instellingen opslaan"
        Me.Settings_Save_But.UseVisualStyleBackColor = True
        '
        'C1NavBarPrijzen
        '
        Me.C1NavBarPrijzen.Button.Image = CType(resources.GetObject("resource.Image5"), System.Drawing.Image)
        Me.C1NavBarPrijzen.Button.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.C1NavBarPrijzen.Button.SmallImage = CType(resources.GetObject("resource.SmallImage3"), System.Drawing.Image)
        Me.C1NavBarPrijzen.Button.Text = "Prijzen"
        Me.C1NavBarPrijzen.Controls.Add(Me.C1NavPanelPrijzen)
        Me.C1NavBarPrijzen.ID = 4
        Me.C1NavBarPrijzen.Name = "C1NavBarPrijzen"
        Me.C1NavBarPrijzen.Size = New System.Drawing.Size(205, 707)
        '
        'C1NavPanelPrijzen
        '
        Me.C1NavPanelPrijzen.Controls.Add(Me.Prijzen_opslaan_but)
        Me.C1NavPanelPrijzen.Controls.Add(Me.prijzen_aanpassen_but)
        Me.C1NavPanelPrijzen.Controls.Add(Me.prijzen_verwijderen_but)
        Me.C1NavPanelPrijzen.Controls.Add(Me.prijzen_nieuw_but)
        Me.C1NavPanelPrijzen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1NavPanelPrijzen.Location = New System.Drawing.Point(0, 0)
        Me.C1NavPanelPrijzen.Name = "C1NavPanelPrijzen"
        Me.C1NavPanelPrijzen.Size = New System.Drawing.Size(205, 707)
        Me.C1NavPanelPrijzen.TabIndex = 0
        '
        'Prijzen_opslaan_but
        '
        Me.Prijzen_opslaan_but.Location = New System.Drawing.Point(23, 164)
        Me.Prijzen_opslaan_but.Name = "Prijzen_opslaan_but"
        Me.Prijzen_opslaan_but.Size = New System.Drawing.Size(162, 25)
        Me.Prijzen_opslaan_but.TabIndex = 29
        Me.Prijzen_opslaan_but.Text = "Opslaan"
        Me.Prijzen_opslaan_but.UseVisualStyleBackColor = True
        '
        'prijzen_aanpassen_but
        '
        Me.prijzen_aanpassen_but.Location = New System.Drawing.Point(23, 91)
        Me.prijzen_aanpassen_but.Name = "prijzen_aanpassen_but"
        Me.prijzen_aanpassen_but.Size = New System.Drawing.Size(161, 25)
        Me.prijzen_aanpassen_but.TabIndex = 28
        Me.prijzen_aanpassen_but.Text = "Aanpassen"
        Me.prijzen_aanpassen_but.UseVisualStyleBackColor = True
        '
        'prijzen_verwijderen_but
        '
        Me.prijzen_verwijderen_but.Location = New System.Drawing.Point(23, 122)
        Me.prijzen_verwijderen_but.Name = "prijzen_verwijderen_but"
        Me.prijzen_verwijderen_but.Size = New System.Drawing.Size(161, 24)
        Me.prijzen_verwijderen_but.TabIndex = 22
        Me.prijzen_verwijderen_but.Text = "Verwijderen"
        Me.prijzen_verwijderen_but.UseVisualStyleBackColor = True
        '
        'prijzen_nieuw_but
        '
        Me.prijzen_nieuw_but.Location = New System.Drawing.Point(23, 60)
        Me.prijzen_nieuw_but.Name = "prijzen_nieuw_but"
        Me.prijzen_nieuw_but.Size = New System.Drawing.Size(161, 25)
        Me.prijzen_nieuw_but.TabIndex = 9
        Me.prijzen_nieuw_but.Text = "Nieuw"
        Me.prijzen_nieuw_but.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(80, 40)
        Me.Panel1.TabIndex = 0
        '
        'Timer_Activity
        '
        Me.Timer_Activity.Interval = 30000
        '
        'Tree_MenuStrip
        '
        Me.Tree_MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrderToolStripMenuItem, Me.TreeMenu_Selectie, Me.TreeMenu_OrderAanpassen, Me.TreeMenu_Karindeling, Me.WpsVersturenToolStripMenuItem, Me.OrderKopierenToolStripMenuItem, Me.OrderResetToolStripMenuItem, Me.OrderStikkersVerzamelkarToolStripMenuItem, Me.LabelberichtStatusToolStripMenuItem, Me.OrderNaar900VolgendeDagToolStripMenuItem, Me.OvergooienHieropAanvullenToolStripMenuItem, Me.PakbonSamenvatting, Me.FloridayOrderAanpassenToolStripMenuItem, Me.ToolStripMenuItem2, Me.TreeMenu_SortInvoer, Me.TreeMenu_SortStatus, Me.TreeMenu_SortAlfabet, Me.TreeMenu_SortLoc, Me.TreeMenu_TijdAlles, Me.TreeMenu_Tijd10, Me.TreeMenu_Tijd13, Me.TreeMenu_StatusAlles, Me.TreeMenu_StatusVerkort, Me.TreeMenu_StatusNieuw, Me.TreeMenu_StatusNenI, Me.TreeMenu_StatusIngepakt, Me.TreeMenu_StatusVracht, Me.TreeMenu_StatusGeannuleerd})
        Me.Tree_MenuStrip.Name = "ContextMenuStrip1"
        Me.Tree_MenuStrip.Size = New System.Drawing.Size(246, 620)
        '
        'OrderToolStripMenuItem
        '
        Me.OrderToolStripMenuItem.Name = "OrderToolStripMenuItem"
        Me.OrderToolStripMenuItem.Size = New System.Drawing.Size(245, 22)
        Me.OrderToolStripMenuItem.Text = "-------------- Order -------------"
        '
        'TreeMenu_Selectie
        '
        Me.TreeMenu_Selectie.Name = "TreeMenu_Selectie"
        Me.TreeMenu_Selectie.Size = New System.Drawing.Size(245, 22)
        Me.TreeMenu_Selectie.Text = "Selectie"
        '
        'TreeMenu_OrderAanpassen
        '
        Me.TreeMenu_OrderAanpassen.Name = "TreeMenu_OrderAanpassen"
        Me.TreeMenu_OrderAanpassen.Size = New System.Drawing.Size(245, 22)
        Me.TreeMenu_OrderAanpassen.Text = "Order Aanpassen"
        '
        'TreeMenu_Karindeling
        '
        Me.TreeMenu_Karindeling.Name = "TreeMenu_Karindeling"
        Me.TreeMenu_Karindeling.Size = New System.Drawing.Size(245, 22)
        Me.TreeMenu_Karindeling.Text = "Karindeling"
        '
        'WpsVersturenToolStripMenuItem
        '
        Me.WpsVersturenToolStripMenuItem.Name = "WpsVersturenToolStripMenuItem"
        Me.WpsVersturenToolStripMenuItem.Size = New System.Drawing.Size(245, 22)
        Me.WpsVersturenToolStripMenuItem.Text = "Wps versturen"
        '
        'OrderKopierenToolStripMenuItem
        '
        Me.OrderKopierenToolStripMenuItem.Name = "OrderKopierenToolStripMenuItem"
        Me.OrderKopierenToolStripMenuItem.Size = New System.Drawing.Size(245, 22)
        Me.OrderKopierenToolStripMenuItem.Text = "Order Kopieren"
        '
        'OrderResetToolStripMenuItem
        '
        Me.OrderResetToolStripMenuItem.Name = "OrderResetToolStripMenuItem"
        Me.OrderResetToolStripMenuItem.Size = New System.Drawing.Size(245, 22)
        Me.OrderResetToolStripMenuItem.Text = "Order Gecorrigeerd"
        '
        'OrderStikkersVerzamelkarToolStripMenuItem
        '
        Me.OrderStikkersVerzamelkarToolStripMenuItem.Name = "OrderStikkersVerzamelkarToolStripMenuItem"
        Me.OrderStikkersVerzamelkarToolStripMenuItem.Size = New System.Drawing.Size(245, 22)
        Me.OrderStikkersVerzamelkarToolStripMenuItem.Text = "Stikkers verzamelkar printen"
        '
        'LabelberichtStatusToolStripMenuItem
        '
        Me.LabelberichtStatusToolStripMenuItem.Name = "LabelberichtStatusToolStripMenuItem"
        Me.LabelberichtStatusToolStripMenuItem.Size = New System.Drawing.Size(245, 22)
        Me.LabelberichtStatusToolStripMenuItem.Text = "Labelbericht Status"
        '
        'OrderNaar900VolgendeDagToolStripMenuItem
        '
        Me.OrderNaar900VolgendeDagToolStripMenuItem.Name = "OrderNaar900VolgendeDagToolStripMenuItem"
        Me.OrderNaar900VolgendeDagToolStripMenuItem.Size = New System.Drawing.Size(245, 22)
        Me.OrderNaar900VolgendeDagToolStripMenuItem.Text = "Orders naar 8:00 volgende dag"
        '
        'OvergooienHieropAanvullenToolStripMenuItem
        '
        Me.OvergooienHieropAanvullenToolStripMenuItem.Name = "OvergooienHieropAanvullenToolStripMenuItem"
        Me.OvergooienHieropAanvullenToolStripMenuItem.Size = New System.Drawing.Size(245, 22)
        Me.OvergooienHieropAanvullenToolStripMenuItem.Text = "Overgooien hierop / aanvullen"
        '
        'PakbonSamenvatting
        '
        Me.PakbonSamenvatting.Name = "PakbonSamenvatting"
        Me.PakbonSamenvatting.Size = New System.Drawing.Size(245, 22)
        Me.PakbonSamenvatting.Text = "Print samenvatting pakbon"
        '
        'FloridayOrderAanpassenToolStripMenuItem
        '
        Me.FloridayOrderAanpassenToolStripMenuItem.Name = "FloridayOrderAanpassenToolStripMenuItem"
        Me.FloridayOrderAanpassenToolStripMenuItem.Size = New System.Drawing.Size(245, 22)
        Me.FloridayOrderAanpassenToolStripMenuItem.Text = "Floriday aanpassing"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(245, 22)
        Me.ToolStripMenuItem2.Text = "------------ Sorteren -----------"
        '
        'TreeMenu_SortInvoer
        '
        Me.TreeMenu_SortInvoer.Name = "TreeMenu_SortInvoer"
        Me.TreeMenu_SortInvoer.Size = New System.Drawing.Size(245, 22)
        Me.TreeMenu_SortInvoer.Text = "Sorteren op invoer *"
        '
        'TreeMenu_SortStatus
        '
        Me.TreeMenu_SortStatus.Name = "TreeMenu_SortStatus"
        Me.TreeMenu_SortStatus.Size = New System.Drawing.Size(245, 22)
        Me.TreeMenu_SortStatus.Text = "Sorteren op status"
        '
        'TreeMenu_SortAlfabet
        '
        Me.TreeMenu_SortAlfabet.Name = "TreeMenu_SortAlfabet"
        Me.TreeMenu_SortAlfabet.Size = New System.Drawing.Size(245, 22)
        Me.TreeMenu_SortAlfabet.Text = "Sorteren op alfabet"
        '
        'TreeMenu_SortLoc
        '
        Me.TreeMenu_SortLoc.Name = "TreeMenu_SortLoc"
        Me.TreeMenu_SortLoc.Size = New System.Drawing.Size(245, 22)
        Me.TreeMenu_SortLoc.Text = "Sorteren op afleverlocatie"
        '
        'TreeMenu_TijdAlles
        '
        Me.TreeMenu_TijdAlles.Name = "TreeMenu_TijdAlles"
        Me.TreeMenu_TijdAlles.Size = New System.Drawing.Size(245, 22)
        Me.TreeMenu_TijdAlles.Text = "Tijd : Alles tonen *"
        '
        'TreeMenu_Tijd10
        '
        Me.TreeMenu_Tijd10.Name = "TreeMenu_Tijd10"
        Me.TreeMenu_Tijd10.Size = New System.Drawing.Size(245, 22)
        Me.TreeMenu_Tijd10.Text = "Tijd : Vanaf 10:00"
        '
        'TreeMenu_Tijd13
        '
        Me.TreeMenu_Tijd13.Name = "TreeMenu_Tijd13"
        Me.TreeMenu_Tijd13.Size = New System.Drawing.Size(245, 22)
        Me.TreeMenu_Tijd13.Text = "Tijd: Vanaf 13:00"
        '
        'TreeMenu_StatusAlles
        '
        Me.TreeMenu_StatusAlles.Name = "TreeMenu_StatusAlles"
        Me.TreeMenu_StatusAlles.Size = New System.Drawing.Size(245, 22)
        Me.TreeMenu_StatusAlles.Text = "Status : Alles tonen *"
        '
        'TreeMenu_StatusVerkort
        '
        Me.TreeMenu_StatusVerkort.Name = "TreeMenu_StatusVerkort"
        Me.TreeMenu_StatusVerkort.Size = New System.Drawing.Size(245, 22)
        Me.TreeMenu_StatusVerkort.Text = "Status : Verkort"
        '
        'TreeMenu_StatusNieuw
        '
        Me.TreeMenu_StatusNieuw.Name = "TreeMenu_StatusNieuw"
        Me.TreeMenu_StatusNieuw.Size = New System.Drawing.Size(245, 22)
        Me.TreeMenu_StatusNieuw.Text = "Status : Nieuw"
        '
        'TreeMenu_StatusNenI
        '
        Me.TreeMenu_StatusNenI.Name = "TreeMenu_StatusNenI"
        Me.TreeMenu_StatusNenI.Size = New System.Drawing.Size(245, 22)
        Me.TreeMenu_StatusNenI.Text = "Status : Nieuw + Ingepakt"
        '
        'TreeMenu_StatusIngepakt
        '
        Me.TreeMenu_StatusIngepakt.Name = "TreeMenu_StatusIngepakt"
        Me.TreeMenu_StatusIngepakt.Size = New System.Drawing.Size(245, 22)
        Me.TreeMenu_StatusIngepakt.Text = "Status : Ingepakt"
        '
        'TreeMenu_StatusVracht
        '
        Me.TreeMenu_StatusVracht.Name = "TreeMenu_StatusVracht"
        Me.TreeMenu_StatusVracht.Size = New System.Drawing.Size(245, 22)
        Me.TreeMenu_StatusVracht.Text = "Status : Vracht bepalen"
        '
        'TreeMenu_StatusGeannuleerd
        '
        Me.TreeMenu_StatusGeannuleerd.Name = "TreeMenu_StatusGeannuleerd"
        Me.TreeMenu_StatusGeannuleerd.Size = New System.Drawing.Size(245, 22)
        Me.TreeMenu_StatusGeannuleerd.Text = "Status : Geannuleerd"
        '
        'Florecom_MenuStrip
        '
        Me.Florecom_MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FC_Toolstrip_Soort, Me.FC_Toolstrip_SoortOpmerking, Me.FC_Toolstrip_Opmerking, Me.FC_Toolstrip_PrijsKoperSet})
        Me.Florecom_MenuStrip.Name = "Florecom_MenuStrip"
        Me.Florecom_MenuStrip.Size = New System.Drawing.Size(313, 92)
        '
        'FC_Toolstrip_Soort
        '
        Me.FC_Toolstrip_Soort.Name = "FC_Toolstrip_Soort"
        Me.FC_Toolstrip_Soort.Size = New System.Drawing.Size(312, 22)
        Me.FC_Toolstrip_Soort.Text = "Koppel omschrijving aan soort"
        '
        'FC_Toolstrip_SoortOpmerking
        '
        Me.FC_Toolstrip_SoortOpmerking.Name = "FC_Toolstrip_SoortOpmerking"
        Me.FC_Toolstrip_SoortOpmerking.Size = New System.Drawing.Size(312, 22)
        Me.FC_Toolstrip_SoortOpmerking.Text = "Koppel omschrijving en opmerking aan soort"
        '
        'FC_Toolstrip_Opmerking
        '
        Me.FC_Toolstrip_Opmerking.Name = "FC_Toolstrip_Opmerking"
        Me.FC_Toolstrip_Opmerking.Size = New System.Drawing.Size(312, 22)
        Me.FC_Toolstrip_Opmerking.Text = "Opmerking goedkeuren"
        '
        'FC_Toolstrip_PrijsKoperSet
        '
        Me.FC_Toolstrip_PrijsKoperSet.Name = "FC_Toolstrip_PrijsKoperSet"
        Me.FC_Toolstrip_PrijsKoperSet.Size = New System.Drawing.Size(312, 22)
        Me.FC_Toolstrip_PrijsKoperSet.Text = "Prijs koper naar Aanbodsprijs zetten"
        '
        'Order_MenuStrip
        '
        Me.Order_MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GP2ToolStripMenuItem, Me.GP3ToolStripMenuItem, Me.Order_ToolStripMenuItem1, Me.CodeInvoerToolStripMenuItem, Me.ToolStripMenuItem3, Me.Order_ToolStripMenuItem2, Me.Order_ToolStripMenuItem3, Me.Order_ToolStripMenuItem4, Me.Order_ToolStripMenuItem5, Me.Order_ToolStripMenuItem6})
        Me.Order_MenuStrip.Name = "Order_MenuStrip"
        Me.Order_MenuStrip.Size = New System.Drawing.Size(166, 224)
        '
        'GP2ToolStripMenuItem
        '
        Me.GP2ToolStripMenuItem.Name = "GP2ToolStripMenuItem"
        Me.GP2ToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.GP2ToolStripMenuItem.Text = "GP: 2"
        '
        'GP3ToolStripMenuItem
        '
        Me.GP3ToolStripMenuItem.Name = "GP3ToolStripMenuItem"
        Me.GP3ToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.GP3ToolStripMenuItem.Text = "GP: 3"
        '
        'Order_ToolStripMenuItem1
        '
        Me.Order_ToolStripMenuItem1.Name = "Order_ToolStripMenuItem1"
        Me.Order_ToolStripMenuItem1.Size = New System.Drawing.Size(165, 22)
        Me.Order_ToolStripMenuItem1.Text = "Accessoire lijst"
        '
        'CodeInvoerToolStripMenuItem
        '
        Me.CodeInvoerToolStripMenuItem.Name = "CodeInvoerToolStripMenuItem"
        Me.CodeInvoerToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.CodeInvoerToolStripMenuItem.Text = "Code invoer"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(165, 22)
        Me.ToolStripMenuItem3.Text = "......Favorieten......"
        '
        'Order_ToolStripMenuItem2
        '
        Me.Order_ToolStripMenuItem2.Name = "Order_ToolStripMenuItem2"
        Me.Order_ToolStripMenuItem2.Size = New System.Drawing.Size(165, 22)
        Me.Order_ToolStripMenuItem2.Text = "Favoriet 1"
        '
        'Order_ToolStripMenuItem3
        '
        Me.Order_ToolStripMenuItem3.Name = "Order_ToolStripMenuItem3"
        Me.Order_ToolStripMenuItem3.Size = New System.Drawing.Size(165, 22)
        Me.Order_ToolStripMenuItem3.Text = "Favoriet 2"
        '
        'Order_ToolStripMenuItem4
        '
        Me.Order_ToolStripMenuItem4.Name = "Order_ToolStripMenuItem4"
        Me.Order_ToolStripMenuItem4.Size = New System.Drawing.Size(165, 22)
        Me.Order_ToolStripMenuItem4.Text = "Favoriet 3"
        '
        'Order_ToolStripMenuItem5
        '
        Me.Order_ToolStripMenuItem5.Name = "Order_ToolStripMenuItem5"
        Me.Order_ToolStripMenuItem5.Size = New System.Drawing.Size(165, 22)
        Me.Order_ToolStripMenuItem5.Text = "Favoriet 4"
        '
        'Order_ToolStripMenuItem6
        '
        Me.Order_ToolStripMenuItem6.Name = "Order_ToolStripMenuItem6"
        Me.Order_ToolStripMenuItem6.Size = New System.Drawing.Size(165, 22)
        Me.Order_ToolStripMenuItem6.Text = "Favoriet 5"
        '
        'C1PrintDocument1
        '
        Me.C1PrintDocument1.DocumentInfo.Creator = "C1Reports Engine version 2.6.20101.54005"
        '
        'TimerBarcodeServer
        '
        Me.TimerBarcodeServer.Enabled = True
        Me.TimerBarcodeServer.Interval = 4000
        '
        'TimerFlorecom
        '
        Me.TimerFlorecom.Interval = 30000
        '
        'InlogTimer
        '
        Me.InlogTimer.Enabled = True
        Me.InlogTimer.Interval = 30000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1476, 973)
        Me.Controls.Add(Me.C1SizerMainWindow)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Boek"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.C1SizerMainWindow, System.ComponentModel.ISupportInitialize).EndInit
        Me.C1SizerMainWindow.ResumeLayout(False)
        CType(Me.C1SizerTree, System.ComponentModel.ISupportInitialize).EndInit
        Me.C1SizerTree.ResumeLayout(False)
        Me.TreePanel.ResumeLayout(False)
        Me.TreePanel.PerformLayout
        CType(Me.icon4_pbox, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.icon3_pbox, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.icon2_pbox, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.icon1_pbox, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.C1Tab, System.ComponentModel.ISupportInitialize).EndInit
        Me.C1Tab.ResumeLayout(False)
        Me.C1TabOrderInvoer.ResumeLayout(False)
        CType(Me.C1SizerOrderTab, System.ComponentModel.ISupportInitialize).EndInit
        Me.C1SizerOrderTab.ResumeLayout(False)
        Me.C1SizerOrderTab.PerformLayout
        CType(Me.Invoer_WpsFilterCombo, System.ComponentModel.ISupportInitialize).EndInit
        Me.TabOrdersPanelTop.ResumeLayout(False)
        Me.TabOrdersPanelTop.PerformLayout
        Me.Order_OpmTab.ResumeLayout(False)
        Me.opmerking.ResumeLayout(False)
        Me.opmerking.PerformLayout
        Me.orderinfo.ResumeLayout(False)
        Me.orderinfo.PerformLayout
        Me.pakboninfo.ResumeLayout(False)
        Me.pakboninfo.PerformLayout
        Me.koper1.ResumeLayout(False)
        Me.koper1.PerformLayout
        Me.koper2.ResumeLayout(False)
        Me.koper2.PerformLayout
        Me.koper3.ResumeLayout(False)
        Me.koper3.PerformLayout
        Me.koper4.ResumeLayout(False)
        Me.koper4.PerformLayout
        Me.koper5.ResumeLayout(False)
        Me.koper5.PerformLayout
        Me.koper6.ResumeLayout(False)
        Me.koper6.PerformLayout
        Me.koper7.ResumeLayout(False)
        Me.koper7.PerformLayout
        Me.koper8.ResumeLayout(False)
        Me.koper8.PerformLayout
        Me.kopertoevoegen.ResumeLayout(False)
        Me.Order_Opm_addcontactpannel.ResumeLayout(False)
        Me.Order_Opm_addcontactpannel.PerformLayout
        CType(Me.Order_invoer_FlexGrid, System.ComponentModel.ISupportInitialize).EndInit
        Me.C1TabKarindeling.ResumeLayout(False)
        CType(Me.C1SizerKarIndeling, System.ComponentModel.ISupportInitialize).EndInit
        Me.C1SizerKarIndeling.ResumeLayout(False)
        Me.PanelKarindelingOnder.ResumeLayout(False)
        Me.PanelKarindelingOnder.PerformLayout
        Me.PanelKarindelingMidden.ResumeLayout(False)
        Me.PanelKarindelingMidden.PerformLayout
        CType(Me.Kar_flexgrid4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Kar_flexgrid3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Kar_flexgrid2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Kar_flexgrid1, System.ComponentModel.ISupportInitialize).EndInit
        Me.PanelKarIndelingBoven.ResumeLayout(False)
        Me.PanelKarIndelingBoven.PerformLayout
        Me.C1TabFloriday.ResumeLayout(False)
        CType(Me.C1SizerFloriday, System.ComponentModel.ISupportInitialize).EndInit
        Me.C1SizerFloriday.ResumeLayout(False)
        Me.C1SizerFloriday.PerformLayout
        Me.PanelFloridayorders.ResumeLayout(False)
        CType(Me.FDLineCombo, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.FloridayOrderInfo_flx, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.FloridayOrderLines_flx, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.FloridayOrders_flx, System.ComponentModel.ISupportInitialize).EndInit
        Me.C1TabFlorecom.ResumeLayout(False)
        CType(Me.C1SizerFlorecom, System.ComponentModel.ISupportInitialize).EndInit
        Me.C1SizerFlorecom.ResumeLayout(False)
        Me.C1SizerFlorecom.PerformLayout
        CType(Me.Fc_ContactCombo, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Fc_LineCombo, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Fc_Flexgrid_LineData, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.FC_Flexgrid_contactdata, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.FC_Flexgrid_orderlines, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.FC_Flexgrid_orderlijst, System.ComponentModel.ISupportInitialize).EndInit
        Me.FlorecomDel_menuStrip.ResumeLayout(False)
        Me.C1TabVervoer.ResumeLayout(False)
        CType(Me.SizerVervoer, System.ComponentModel.ISupportInitialize).EndInit
        Me.SizerVervoer.ResumeLayout(False)
        Me.Vervoer_PanelRechts.ResumeLayout(False)
        Me.Vervoer_PanelRechts.PerformLayout
        Me.Vervoer_PanelLinks.ResumeLayout(False)
        Me.Vervoer_PanelLinks.PerformLayout
        Me.C1TabOverzichten.ResumeLayout(False)
        CType(Me.OverzichtSizer1, System.ComponentModel.ISupportInitialize).EndInit
        Me.OverzichtSizer1.ResumeLayout(False)
        CType(Me.OverzichtSizer2, System.ComponentModel.ISupportInitialize).EndInit
        Me.OverzichtSizer2.ResumeLayout(False)
        CType(Me.Overzicht_FlexGrid, System.ComponentModel.ISupportInitialize).EndInit
        Me.Overzicht_Panel.ResumeLayout(False)
        Me.Overzicht_Panel.PerformLayout
        CType(Me.Overzicht_PictureBox, System.ComponentModel.ISupportInitialize).EndInit
        Me.C1TabDatabase.ResumeLayout(False)
        CType(Me.C1Sizer1, System.ComponentModel.ISupportInitialize).EndInit
        Me.C1Sizer1.ResumeLayout(False)
        Me.C1Sizer1.PerformLayout
        CType(Me.DatabaseComboWpsFilter, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DatabaseFlexGridEdit, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DatabaseFlexGridShow, System.ComponentModel.ISupportInitialize).EndInit
        Me.C1TabInstellingen.ResumeLayout(False)
        Me.C1TabInstellingen.PerformLayout
        Me.Inst_Overig_GB.ResumeLayout(False)
        Me.Inst_Overig_GB.PerformLayout
        CType(Me.Inst_odag7_ud, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Inst_odag6_ud, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Inst_odag5_ud, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Inst_odag4_ud, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Inst_odag3_ud, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Inst_odag2_ud, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Inst_odag1_ud, System.ComponentModel.ISupportInitialize).EndInit
        Me.Inst_Westland_GB.ResumeLayout(False)
        Me.Inst_Westland_GB.PerformLayout
        CType(Me.Inst_wdag7_ud, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Inst_wdag6_ud, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Inst_wdag5_ud, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Inst_wdag4_ud, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Inst_wdag3_ud, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Inst_wdag2_ud, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Inst_wdag1_ud, System.ComponentModel.ISupportInitialize).EndInit
        Me.C1TabPrijzen.ResumeLayout(False)
        CType(Me.Prijzen_sizer, System.ComponentModel.ISupportInitialize).EndInit
        Me.Prijzen_sizer.ResumeLayout(False)
        CType(Me.C1prijzensizer3, System.ComponentModel.ISupportInitialize).EndInit
        Me.C1prijzensizer3.ResumeLayout(False)
        Me.prijzenpanelmidleft.ResumeLayout(False)
        Me.prijzenpanelmidleft.PerformLayout
        CType(Me.prijzen_jaar_updown, System.ComponentModel.ISupportInitialize).EndInit
        Me.prijzenpanelmidright.ResumeLayout(False)
        Me.prijzenpanelmidright.PerformLayout
        CType(Me.Prijzen_PictureBox, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Prijzen_Sizer2, System.ComponentModel.ISupportInitialize).EndInit
        Me.Prijzen_Sizer2.ResumeLayout(False)
        CType(Me.Prijzen_flexgrid_soorten, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.prijzen_flexgrid_datums, System.ComponentModel.ISupportInitialize).EndInit
        Me.C1TabVoorraad.ResumeLayout(False)
        CType(Me.C1SizerVoorraad, System.ComponentModel.ISupportInitialize).EndInit
        Me.C1SizerVoorraad.ResumeLayout(False)
        CType(Me.Voorraad_Flexgrid, System.ComponentModel.ISupportInitialize).EndInit
        Me.PanelVoorraad.ResumeLayout(False)
        Me.GroupBoxVoorraad.ResumeLayout(False)
        Me.GroupBoxVoorraad.PerformLayout
        Me.C1TabWPS.ResumeLayout(False)
        CType(Me.C1SizerWpsFilters, System.ComponentModel.ISupportInitialize).EndInit
        Me.C1SizerWpsFilters.ResumeLayout(False)
        Me.C1SizerWpsFilters.PerformLayout
        CType(Me.WpsFilter_flexcombo, System.ComponentModel.ISupportInitialize).EndInit
        Me.PanelWpsFilterMidBar.ResumeLayout(False)
        Me.PanelWpsFilterMidBar.PerformLayout
        Me.PanelWpsFilterTopBar.ResumeLayout(False)
        Me.PanelWpsFilter.ResumeLayout(False)
        CType(Me.WpsFilter_FilterFlex, System.ComponentModel.ISupportInitialize).EndInit
        Me.C1TabInloggen.ResumeLayout(False)
        CType(Me.C1SizerInloggen, System.ComponentModel.ISupportInitialize).EndInit
        Me.C1SizerInloggen.ResumeLayout(False)
        Me.LoginPanelDown.ResumeLayout(False)
        CType(Me.AgendaFlexGrid, System.ComponentModel.ISupportInitialize).EndInit
        Me.LoginPanelup.ResumeLayout(False)
        Me.LoginPanelup.PerformLayout
        CType(Me.C1NavBar1, System.ComponentModel.ISupportInitialize).EndInit
        Me.C1NavBar1.ResumeLayout(False)
        Me.C1NavBarPanelOrders.ResumeLayout(False)
        Me.C1NavPanelOrders2.ResumeLayout(False)
        Me.C1NavPanelOrders2.PerformLayout
        Me.C1NavPanelOrders1.ResumeLayout(False)
        Me.C1NavBarFloriday.ResumeLayout(False)
        Me.C1NavBarFloriday.PerformLayout
        Me.C1NavBarFlorecom.ResumeLayout(False)
        Me.C1NavPanelFlorecom.ResumeLayout(False)
        Me.C1NavPanelFlorecom.PerformLayout
        Me.C1NavBarPanelDatabase.ResumeLayout(False)
        Me.C1NavPanelDatabase1.ResumeLayout(False)
        Me.C1NavPanelDatabase1.PerformLayout
        Me.C1NavBarPanelInstellingen.ResumeLayout(False)
        Me.C1NavPanelInstel.ResumeLayout(False)
        Me.C1NavBarPrijzen.ResumeLayout(False)
        Me.C1NavPanelPrijzen.ResumeLayout(False)
        Me.Tree_MenuStrip.ResumeLayout(False)
        Me.Florecom_MenuStrip.ResumeLayout(False)
        Me.Order_MenuStrip.ResumeLayout(False)
        CType(Me.C1PrintDocument1, System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(False)

    End Sub


    Friend WithEvents C1SizerMainWindow As C1.Win.C1Sizer.C1Sizer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents C1Tab As C1.Win.C1Command.C1DockingTab
    Friend WithEvents C1TabOrderInvoer As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1TabKarindeling As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1TabFlorecom As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1TabVervoer As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1TabOverzichten As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1TabDatabase As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1TabInstellingen As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1SizerOrderTab As C1.Win.C1Sizer.C1Sizer
    Friend WithEvents TabOrdersPanelTop As System.Windows.Forms.Panel
    Friend WithEvents Order_invoer_FlexGrid As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1Sizer1 As C1.Win.C1Sizer.C1Sizer
    Friend WithEvents DatabaseFlexGridShow As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents DatabaseFlexGridEdit As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1TabInloggen As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1TabPrijzen As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents Inst_Login8_Txt As System.Windows.Forms.TextBox
    Friend WithEvents SettingsLogin8 As System.Windows.Forms.Label
    Friend WithEvents Inst_Login7_Txt As System.Windows.Forms.TextBox
    Friend WithEvents SettingsLogin7 As System.Windows.Forms.Label
    Friend WithEvents Inst_Login6_Txt As System.Windows.Forms.TextBox
    Friend WithEvents SettingsLogin6 As System.Windows.Forms.Label
    Friend WithEvents Inst_Login5_Txt As System.Windows.Forms.TextBox
    Friend WithEvents SettingsLogin5 As System.Windows.Forms.Label
    Friend WithEvents Inst_Login4_Txt As System.Windows.Forms.TextBox
    Friend WithEvents SettingsLogin4 As System.Windows.Forms.Label
    Friend WithEvents Inst_Login3_Txt As System.Windows.Forms.TextBox
    Friend WithEvents SettingsLogin3 As System.Windows.Forms.Label
    Friend WithEvents Inst_Login2_Txt As System.Windows.Forms.TextBox
    Friend WithEvents SettingsLogin2 As System.Windows.Forms.Label
    Friend WithEvents Inst_Login1_Txt As System.Windows.Forms.TextBox
    Friend WithEvents SettingsLogin1 As System.Windows.Forms.Label
    Friend WithEvents Inst_MySQLPass_Txt As System.Windows.Forms.TextBox
    Friend WithEvents SettingsMySQL_lbl4 As System.Windows.Forms.Label
    Friend WithEvents Inst_MySQLUser_Txt As System.Windows.Forms.TextBox
    Friend WithEvents SettingsMySQL_lbl3 As System.Windows.Forms.Label
    Friend WithEvents Inst_MySQLServer_Txt As System.Windows.Forms.TextBox
    Friend WithEvents SettingsMySQL_lbl2 As System.Windows.Forms.Label
    Friend WithEvents Inst_MySQLODBC_Txt As System.Windows.Forms.TextBox
    Friend WithEvents SettingsMySQL_lbl1 As System.Windows.Forms.Label
    Friend WithEvents Timer_Activity As System.Windows.Forms.Timer
    Friend WithEvents Order_admnr_lbl As System.Windows.Forms.Label
    Friend WithEvents Order_ean_lbl As System.Windows.Forms.Label
    Friend WithEvents Order_Aflevertijd17_but As System.Windows.Forms.Button
    Friend WithEvents Order_Aflevertijd12_but As System.Windows.Forms.Button
    Friend WithEvents Order_Aflevertijd9_but As System.Windows.Forms.Button
    Friend WithEvents Order_Aflevertijd_combo As System.Windows.Forms.ComboBox
    Friend WithEvents Order_Morgen_but As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents OrderDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Order_kar_combo As System.Windows.Forms.ComboBox
    Friend WithEvents Order_afleverloc_combo As System.Windows.Forms.ComboBox
    Friend WithEvents Order_InstelOpslaan_but As System.Windows.Forms.Button
    Friend WithEvents Order_Opslaan_but As System.Windows.Forms.Button
    Friend WithEvents Order_prijsopslag_txt As System.Windows.Forms.TextBox
    Friend WithEvents Order_vervoerder_combo As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Order_veilingbrief_combo As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Inst_test_server As System.Windows.Forms.Button
    Friend WithEvents LoginNaam1_but As System.Windows.Forms.Button
    Friend WithEvents LoginNaam8_but As System.Windows.Forms.Button
    Friend WithEvents LoginNaam7_but As System.Windows.Forms.Button
    Friend WithEvents LoginNaam6_but As System.Windows.Forms.Button
    Friend WithEvents LoginNaam5_but As System.Windows.Forms.Button
    Friend WithEvents LoginNaam4_but As System.Windows.Forms.Button
    Friend WithEvents LoginNaam3_but As System.Windows.Forms.Button
    Friend WithEvents LoginNaam2_but As System.Windows.Forms.Button
    Friend WithEvents C1SizerInloggen As C1.Win.C1Sizer.C1Sizer
    Friend WithEvents LoginPanelDown As System.Windows.Forms.Panel
    Friend WithEvents LoginPanelup As System.Windows.Forms.Panel
    Friend WithEvents AgendaFlexGrid As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1NavBar1 As C1.Win.C1Command.C1NavBar
    Friend WithEvents C1NavBarPanelOrders As C1.Win.C1Command.C1NavBarPanel
    Friend WithEvents C1NavPanelOrders2 As System.Windows.Forms.Panel
    Friend WithEvents OrdersMenuAnnuleren As System.Windows.Forms.Button
    Friend WithEvents OrdersMenuSamenvoegen As System.Windows.Forms.Button
    Friend WithEvents OrdersMenuAanpassen As System.Windows.Forms.Button
    Friend WithEvents OrdersMenuNieuw As System.Windows.Forms.Button
    Friend WithEvents C1NavPanelOrders1 As System.Windows.Forms.Panel
    Friend WithEvents Order_MonthCalendar As System.Windows.Forms.MonthCalendar
    Friend WithEvents C1NavBarPanelDatabase As C1.Win.C1Command.C1NavBarPanel
    Friend WithEvents C1NavPanelDatabase1 As System.Windows.Forms.Panel
    Friend WithEvents database_lbl As System.Windows.Forms.Label
    Friend WithEvents DatabaseMenuOpslaan As System.Windows.Forms.Button
    Friend WithEvents DatabaseMenuAanpassen As System.Windows.Forms.Button
    Friend WithEvents DatabaseMenuNieuw As System.Windows.Forms.Button
    Friend WithEvents Database_Combo As System.Windows.Forms.ComboBox
    Friend WithEvents C1NavBarPanelInstellingen As C1.Win.C1Command.C1NavBarPanel
    Friend WithEvents C1NavPanelInstel As System.Windows.Forms.Panel
    Friend WithEvents Settings_Cancel_But As System.Windows.Forms.Button
    Friend WithEvents Settings_Save_But As System.Windows.Forms.Button
    Friend WithEvents C1NavBarPrijzen As C1.Win.C1Command.C1NavBarPanel
    Friend WithEvents C1NavPanelPrijzen As System.Windows.Forms.Panel
    Friend WithEvents prijzen_verwijderen_but As System.Windows.Forms.Button
    Friend WithEvents prijzen_prijs_lbl As System.Windows.Forms.Label
    Friend WithEvents prijzen_prijs_txt As System.Windows.Forms.TextBox
    Friend WithEvents prijzen_datum_pick As System.Windows.Forms.DateTimePicker
    Friend WithEvents prijzen_koper_combo As System.Windows.Forms.ComboBox
    Friend WithEvents prijzen_klant_rb As System.Windows.Forms.RadioButton
    Friend WithEvents prijzen_algemeen_rb As System.Windows.Forms.RadioButton
    Friend WithEvents prijzen_klantgroep_rb As System.Windows.Forms.RadioButton
    Friend WithEvents prijzen_soort_lbl As System.Windows.Forms.Label
    Friend WithEvents prijzen_nieuw_but As System.Windows.Forms.Button
    Friend WithEvents prijzen_kopergroep_combo As System.Windows.Forms.ComboBox
    Friend WithEvents prijzen_soort_combo As System.Windows.Forms.ComboBox
    Friend WithEvents Inlog_Datum_but As System.Windows.Forms.Button
    Friend WithEvents InlogAgendaDatum As System.Windows.Forms.DateTimePicker
    Friend WithEvents inlogdatum_lbl As System.Windows.Forms.Label
    Friend WithEvents prijzen_verwijderdatum_but As System.Windows.Forms.Button
    Friend WithEvents prijzen_toevoegendatum_but As System.Windows.Forms.Button
    Friend WithEvents Prijzen_opslaan_but As System.Windows.Forms.Button
    Friend WithEvents prijzen_aanpassen_but As System.Windows.Forms.Button
    Friend WithEvents prijzen_naam_lbl As System.Windows.Forms.Label
    Friend WithEvents prijzen_naam_txt As System.Windows.Forms.TextBox
    Friend WithEvents Prijzen_sizer As C1.Win.C1Sizer.C1Sizer
    Friend WithEvents Prijzen_PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Prijzen_Sizer2 As C1.Win.C1Sizer.C1Sizer
    Friend WithEvents prijzen_flexgrid_datums As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents prijzenpanelmidleft As System.Windows.Forms.Panel
    Friend WithEvents prijzen_jaar_lbl As System.Windows.Forms.Label
    Friend WithEvents prijzen_jaar_updown As System.Windows.Forms.NumericUpDown
    Friend WithEvents prijzen_actief_check As System.Windows.Forms.CheckBox
    Friend WithEvents Prijzen_flexgrid_soorten As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Order_groep1_but As System.Windows.Forms.Button
    Friend WithEvents Order_Vandaag_but As System.Windows.Forms.Button
    Friend WithEvents Order_AflevertijdZA_but As System.Windows.Forms.Button
    Friend WithEvents Order_groep5_but As System.Windows.Forms.Button
    Friend WithEvents Order_groep4_but As System.Windows.Forms.Button
    Friend WithEvents Order_groep3_but As System.Windows.Forms.Button
    Friend WithEvents Order_groep2_but As System.Windows.Forms.Button
    Friend WithEvents IconList As System.Windows.Forms.ImageList
    Friend WithEvents Order_koper_combo As System.Windows.Forms.ComboBox
    Friend WithEvents Order_Decorum_chk As System.Windows.Forms.CheckBox
    Friend WithEvents order_contacts_combo As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Order_admnr_txt As System.Windows.Forms.TextBox
    Friend WithEvents Order_idtxt_lbl As System.Windows.Forms.Label
    Friend WithEvents Order_id_lbl As System.Windows.Forms.Label
    Friend WithEvents Order_OverMorgen_but As System.Windows.Forms.Button
    Friend WithEvents Order_Slot_Chk As System.Windows.Forms.CheckBox
    Friend WithEvents C1SizerTree As C1.Win.C1Sizer.C1Sizer
    Friend WithEvents TreePanel As System.Windows.Forms.Panel
    Friend WithEvents Tree_Datum_lbl As System.Windows.Forms.Label
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents Order_zoek_txt As System.Windows.Forms.TextBox
    Friend WithEvents Order_zoeken_chk As System.Windows.Forms.CheckBox
    Friend WithEvents Order_zoek_but As System.Windows.Forms.Button
    Friend WithEvents Tree_MenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents TreeMenu_SortInvoer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TreeMenu_SortAlfabet As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TreeMenu_TijdAlles As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TreeMenu_Tijd10 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TreeMenu_Tijd13 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TreeMenu_StatusAlles As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TreeMenu_StatusNieuw As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TreeMenu_StatusIngepakt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Tree_Status_lbl As System.Windows.Forms.Label
    Friend WithEvents Tree_Tijd_lbl As System.Windows.Forms.Label


    Friend WithEvents TreeMenu_SortLoc As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TreeMenu_OrderAanpassen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TreeMenu_Selectie As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TreeMenu_StatusGeannuleerd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents C1SizerKarIndeling As C1.Win.C1Sizer.C1Sizer
    Friend WithEvents Orders_Karindeling As System.Windows.Forms.Button
    Friend WithEvents TreeMenu_Karindeling As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Order_versietxt_lbl As System.Windows.Forms.Label
    Friend WithEvents Order_versie_lbl As System.Windows.Forms.Label
    Friend WithEvents PanelKarindelingMidden As System.Windows.Forms.Panel
    Friend WithEvents PanelKarIndelingBoven As System.Windows.Forms.Panel
    Friend WithEvents Kar_kopernaam_lbl As System.Windows.Forms.Label



    Friend WithEvents Kar_rfid1_lbl As System.Windows.Forms.Label
    Friend WithEvents Kar_barcode1_lbl As System.Windows.Forms.Label
    Friend WithEvents Kar_rfid1_txt As System.Windows.Forms.TextBox
    Friend WithEvents Kar_barcode1_txt As System.Windows.Forms.TextBox
    Friend WithEvents Kar_aantaltotaal1_lbl As System.Windows.Forms.Label
    Friend WithEvents Kar_down1_but As System.Windows.Forms.Button
    Friend WithEvents Kar_up1_but As System.Windows.Forms.Button
    Friend WithEvents Kar_plus1_but As System.Windows.Forms.Button
    Friend WithEvents Kar_flexgrid1 As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Kar_vervoer1_chk As System.Windows.Forms.CheckBox
    Friend WithEvents Kar_sdfverzonden1_chk As System.Windows.Forms.CheckBox
    Friend WithEvents HScrollBar1 As System.Windows.Forms.HScrollBar
    Friend WithEvents Kar_lagen1_lbl As System.Windows.Forms.Label
    Friend WithEvents Kar_lagen1_txt As System.Windows.Forms.TextBox
    Friend WithEvents Kar_lagen4_lbl As System.Windows.Forms.Label
    Friend WithEvents Kar_lagen4_txt As System.Windows.Forms.TextBox
    Friend WithEvents Kar_vervoer4_chk As System.Windows.Forms.CheckBox
    Friend WithEvents Kar_sdfverzonden4_chk As System.Windows.Forms.CheckBox
    Friend WithEvents Kar_flexgrid4 As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Kar_rfid4_lbl As System.Windows.Forms.Label
    Friend WithEvents Kar_barcode4_lbl As System.Windows.Forms.Label
    Friend WithEvents Kar_rfid4_txt As System.Windows.Forms.TextBox
    Friend WithEvents Kar_barcode4_txt As System.Windows.Forms.TextBox
    Friend WithEvents Kar_aantaltotaal4_lbl As System.Windows.Forms.Label
    Friend WithEvents Kar_down4_but As System.Windows.Forms.Button
    Friend WithEvents Kar_up4_but As System.Windows.Forms.Button
    Friend WithEvents Kar_plus4_but As System.Windows.Forms.Button
    Friend WithEvents Kar_lagen3_lbl As System.Windows.Forms.Label
    Friend WithEvents Kar_lagen3_txt As System.Windows.Forms.TextBox
    Friend WithEvents Kar_vervoer3_chk As System.Windows.Forms.CheckBox
    Friend WithEvents Kar_sdfverzonden3_chk As System.Windows.Forms.CheckBox
    Friend WithEvents Kar_flexgrid3 As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Kar_rfid3_lbl As System.Windows.Forms.Label
    Friend WithEvents Kar_barcode3_lbl As System.Windows.Forms.Label
    Friend WithEvents Kar_rfid3_txt As System.Windows.Forms.TextBox
    Friend WithEvents Kar_barcode3_txt As System.Windows.Forms.TextBox
    Friend WithEvents Kar_aantaltotaal3_lbl As System.Windows.Forms.Label
    Friend WithEvents Kar_down3_but As System.Windows.Forms.Button
    Friend WithEvents Kar_up3_but As System.Windows.Forms.Button
    Friend WithEvents Kar_plus3_but As System.Windows.Forms.Button
    Friend WithEvents Kar_lagen2_lbl As System.Windows.Forms.Label
    Friend WithEvents Kar_lagen2_txt As System.Windows.Forms.TextBox
    Friend WithEvents Kar_vervoer2_chk As System.Windows.Forms.CheckBox
    Friend WithEvents Kar_sdfverzonden2_chk As System.Windows.Forms.CheckBox
    Friend WithEvents Kar_flexgrid2 As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Kar_rfid2_lbl As System.Windows.Forms.Label
    Friend WithEvents Kar_barcode2_lbl As System.Windows.Forms.Label
    Friend WithEvents Kar_rfid2_txt As System.Windows.Forms.TextBox
    Friend WithEvents Kar_barcode2_txt As System.Windows.Forms.TextBox
    Friend WithEvents Kar_aantaltotaal2_lbl As System.Windows.Forms.Label
    Friend WithEvents Kar_down2_but As System.Windows.Forms.Button
    Friend WithEvents Kar_up2_but As System.Windows.Forms.Button
    Friend WithEvents Kar_plus2_but As System.Windows.Forms.Button
    Friend WithEvents Kar_nummer4_lbl As System.Windows.Forms.Label
    Friend WithEvents Kar_nummer3_lbl As System.Windows.Forms.Label
    Friend WithEvents Kar_nummer2_lbl As System.Windows.Forms.Label
    Friend WithEvents Kar_nummer1_lbl As System.Windows.Forms.Label
    Friend WithEvents Kar_selectietot_lbl As System.Windows.Forms.Label
    Friend WithEvents Kar_selectie_txt As System.Windows.Forms.TextBox
    Friend WithEvents KarBut20 As System.Windows.Forms.Button
    Friend WithEvents KarBut16 As System.Windows.Forms.Button
    Friend WithEvents KarBut12 As System.Windows.Forms.Button
    Friend WithEvents KarBut10 As System.Windows.Forms.Button
    Friend WithEvents KarBut9 As System.Windows.Forms.Button
    Friend WithEvents KarBut8 As System.Windows.Forms.Button
    Friend WithEvents KarBut7 As System.Windows.Forms.Button
    Friend WithEvents KarBut6 As System.Windows.Forms.Button
    Friend WithEvents KarBut5 As System.Windows.Forms.Button
    Friend WithEvents KarBut4 As System.Windows.Forms.Button
    Friend WithEvents KarBut3 As System.Windows.Forms.Button
    Friend WithEvents KarBut2 As System.Windows.Forms.Button
    Friend WithEvents KarBut1 As System.Windows.Forms.Button
    Friend WithEvents KarBut100 As System.Windows.Forms.Button
    Friend WithEvents Kar_autosamenvoegen4_chk As System.Windows.Forms.CheckBox
    Friend WithEvents Kar_autosamenvoegen3_chk As System.Windows.Forms.CheckBox
    Friend WithEvents Kar_autosamenvoegen2_chk As System.Windows.Forms.CheckBox
    Friend WithEvents Kar_autosamenvoegen1_chk As System.Windows.Forms.CheckBox
    Friend WithEvents Kar_karvoorkeur_lbl As System.Windows.Forms.Label
    Friend WithEvents Orders_SdfVersturen As System.Windows.Forms.Button
    Friend WithEvents Orders_WpsVersturen As System.Windows.Forms.Button
    Friend WithEvents Orders_Mark As System.Windows.Forms.Button
    Friend WithEvents Orders_WpsKlaar As System.Windows.Forms.Button
    Friend WithEvents Kar_lagenlock4_but As System.Windows.Forms.Button
    Friend WithEvents Kar_lagenlock3_but As System.Windows.Forms.Button
    Friend WithEvents Kar_lagenlock2_but As System.Windows.Forms.Button
    Friend WithEvents Kar_lagenlock1_but As System.Windows.Forms.Button
    Friend WithEvents KarOrder_versie_lbl As System.Windows.Forms.Label
    Friend WithEvents PanelKarindelingOnder As System.Windows.Forms.Panel
    Friend WithEvents Kar_verdelenals2_but As System.Windows.Forms.Button
    Friend WithEvents Kar_allesop1_but As System.Windows.Forms.Button
    Friend WithEvents Kar_opnieuwberekenen_but As System.Windows.Forms.Button
    Friend WithEvents Kar_opslaan2_but As System.Windows.Forms.Button
    Friend WithEvents WpsVersturenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTipKar As System.Windows.Forms.ToolTip
    Friend WithEvents Inst_Login8_v1_chk As System.Windows.Forms.CheckBox
    Friend WithEvents Inst_Login7_v1_chk As System.Windows.Forms.CheckBox
    Friend WithEvents Inst_Login6_v1_chk As System.Windows.Forms.CheckBox
    Friend WithEvents Inst_Login5_v1_chk As System.Windows.Forms.CheckBox
    Friend WithEvents Inst_Login4_v1_chk As System.Windows.Forms.CheckBox
    Friend WithEvents Inst_Login3_v1_chk As System.Windows.Forms.CheckBox
    Friend WithEvents Inst_Login2_v1_chk As System.Windows.Forms.CheckBox
    Friend WithEvents Inst_Login1_v1_chk As System.Windows.Forms.CheckBox
    Friend WithEvents C1SizerFlorecom As C1.Win.C1Sizer.C1Sizer
    Friend WithEvents Fc_Flexgrid_LineData As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents FC_Flexgrid_contactdata As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents FC_Flexgrid_orderlines As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents FC_Flexgrid_orderlijst As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1NavBarFlorecom As C1.Win.C1Command.C1NavBarPanel
    Friend WithEvents C1NavPanelFlorecom As System.Windows.Forms.Panel
    Friend WithEvents FcMenu_fcnummer_txt As System.Windows.Forms.TextBox
    Friend WithEvents FcMenu_fcnummer_lbl As System.Windows.Forms.Label
    Friend WithEvents FcMenu_Verwerk_but As System.Windows.Forms.Button
    Friend WithEvents FcMenu_Archief As System.Windows.Forms.Button
    Friend WithEvents Fc_DateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents FcMenu_vandaag_but As System.Windows.Forms.Button
    Friend WithEvents FcMenu_nieuw_but As System.Windows.Forms.Button
    Friend WithEvents Fc_LineCombo As C1.Win.C1List.C1Combo
    Friend WithEvents Fc_ContactCombo As C1.Win.C1List.C1Combo
    Friend WithEvents Florecom_MenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents FC_Toolstrip_Soort As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FC_Toolstrip_Opmerking As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Order_reservering_chk As System.Windows.Forms.CheckBox
    Friend WithEvents Order_MenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Order_ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Order_ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Order_ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Order_ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Order_ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Order_ToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OverzichtSizer1 As C1.Win.C1Sizer.C1Sizer
    Friend WithEvents Overzicht_PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents OverzichtSizer2 As C1.Win.C1Sizer.C1Sizer
    Friend WithEvents Overzicht_FlexGrid As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Overzicht_Panel As System.Windows.Forms.Panel
    Friend WithEvents Overzicht_MonthCalendar As System.Windows.Forms.MonthCalendar
    Friend WithEvents OrderKopierenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Order_herbereken_prijzen As System.Windows.Forms.Button
    Friend WithEvents TreeMenu_StatusNenI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TreeMenu_StatusVerkort As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TreeMenu_StatusVracht As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Order_Prijscor_min_but As System.Windows.Forms.Button
    Friend WithEvents Order_Prijs_correctie_lbl As System.Windows.Forms.Label
    Friend WithEvents Order_Prijscor_plus_but As System.Windows.Forms.Button
    Friend WithEvents Order_Prijscor_prijs_txt As System.Windows.Forms.TextBox
    Friend WithEvents TreeMenu_SortStatus As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Kar_opnieuwberekeneninvoer_but As System.Windows.Forms.Button
    Friend WithEvents Order_OpmTab As System.Windows.Forms.TabControl
    Friend WithEvents opmerking As System.Windows.Forms.TabPage
    Friend WithEvents orderinfo As System.Windows.Forms.TabPage
    Friend WithEvents pakboninfo As System.Windows.Forms.TabPage
    Friend WithEvents koper1 As System.Windows.Forms.TabPage
    Friend WithEvents koper2 As System.Windows.Forms.TabPage
    Friend WithEvents koper3 As System.Windows.Forms.TabPage
    Friend WithEvents koper4 As System.Windows.Forms.TabPage
    Friend WithEvents koper5 As System.Windows.Forms.TabPage
    Friend WithEvents koper6 As System.Windows.Forms.TabPage
    Friend WithEvents koper7 As System.Windows.Forms.TabPage
    Friend WithEvents koper8 As System.Windows.Forms.TabPage
    Friend WithEvents kopertoevoegen As System.Windows.Forms.TabPage
    Friend WithEvents Order_OpmKoper1_txt As System.Windows.Forms.TextBox
    Friend WithEvents Order_OpmKoper2_txt As System.Windows.Forms.TextBox
    Friend WithEvents Order_OpmKoper3_txt As System.Windows.Forms.TextBox
    Friend WithEvents Order_OpmKoper4_txt As System.Windows.Forms.TextBox
    Friend WithEvents Order_OpmKoper5_txt As System.Windows.Forms.TextBox
    Friend WithEvents Order_OpmKoper6_txt As System.Windows.Forms.TextBox
    Friend WithEvents Order_OpmKoper7_txt As System.Windows.Forms.TextBox
    Friend WithEvents Order_OpmKoper8_txt As System.Windows.Forms.TextBox
    Friend WithEvents Order_Opm_addcontactpannel As System.Windows.Forms.Panel
    Friend WithEvents Order_Opm_addcontact_but As System.Windows.Forms.Button
    Friend WithEvents Order_Opm_addcontact_lbl As System.Windows.Forms.Label
    Friend WithEvents Order_Opm_addcontact_txt As System.Windows.Forms.TextBox
    Friend WithEvents orders_opmerking_opslaan As System.Windows.Forms.Button
    Friend WithEvents C1TabVoorraad As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents prijzen_id_lbl As System.Windows.Forms.Label
    Friend WithEvents prijzen_idsel_lbl As System.Windows.Forms.Label
    Friend WithEvents C1prijzensizer3 As C1.Win.C1Sizer.C1Sizer
    Friend WithEvents prijzenpanelmidright As System.Windows.Forms.Panel
    Friend WithEvents Tdebug As System.Windows.Forms.Label
    Friend WithEvents SizerVervoer As C1.Win.C1Sizer.C1Sizer
    Friend WithEvents Vervoer_Listbox As System.Windows.Forms.ListBox
    Friend WithEvents Vervoer_Treeview As System.Windows.Forms.TreeView
    Friend WithEvents Vervoer_PanelRechts As System.Windows.Forms.Panel
    Friend WithEvents Vervoer_MonthCalendar As System.Windows.Forms.MonthCalendar
    Friend WithEvents Vervoer_PanelLinks As System.Windows.Forms.Panel
    Friend WithEvents Vervoer_VervoerderMail_but As System.Windows.Forms.Button
    Friend WithEvents Vervoer_OverzichtPrint_but As System.Windows.Forms.Button
    Friend WithEvents Vervoer_Vervoerder_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents Vervoer_OphalenBrieven_but As System.Windows.Forms.Button
    Friend WithEvents vervoer_wordtopgehaald_but As System.Windows.Forms.Button
    Friend WithEvents Vervoer_OverzichtSelectAll As System.Windows.Forms.Button
    Friend WithEvents Vervoer_OverzichtDeSelectAll As System.Windows.Forms.Button
    Friend WithEvents C1PrintDocument1 As C1.C1Preview.C1PrintDocument
    Friend WithEvents vervoer_karrentotaal_lbl As System.Windows.Forms.Label
    Friend WithEvents C1TabWPS As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1SizerWpsFilters As C1.Win.C1Sizer.C1Sizer
    Friend WithEvents PanelWpsFilterMidBar As System.Windows.Forms.Panel
    Friend WithEvents WpsFilter_FilterOpslaan_but As System.Windows.Forms.Button
    Friend WithEvents PanelWpsFilterTopBar As System.Windows.Forms.Panel
    Friend WithEvents WpsFilter_koperIndelingOphalen_but As System.Windows.Forms.Button
    Friend WithEvents PanelWpsFilter As System.Windows.Forms.Panel
    Friend WithEvents WpsFilter_Scrollbar As System.Windows.Forms.HScrollBar
    Friend WithEvents WpsFilter_Instel5_but As System.Windows.Forms.Button
    Friend WithEvents WpsFilter_Instel4_but As System.Windows.Forms.Button
    Friend WithEvents WpsFilter_Instel3_but As System.Windows.Forms.Button
    Friend WithEvents WpsFilter_Instel2_but As System.Windows.Forms.Button
    Friend WithEvents WpsFilter_Instel1_but As System.Windows.Forms.Button
    Friend WithEvents WpsFilter_ChkList5_lst As System.Windows.Forms.CheckedListBox
    Friend WithEvents WpsFilter_ChkList4_lst As System.Windows.Forms.CheckedListBox
    Friend WithEvents WpsFilter_ChkList3_lst As System.Windows.Forms.CheckedListBox
    Friend WithEvents WpsFilter_ChkList2_lst As System.Windows.Forms.CheckedListBox
    Friend WithEvents WpsFilter_ChkList1_lst As System.Windows.Forms.CheckedListBox
    Friend WithEvents WpsFilter_Add5_but As System.Windows.Forms.Button
    Friend WithEvents WpsFilter_Add4_but As System.Windows.Forms.Button
    Friend WithEvents WpsFilter_Add3_but As System.Windows.Forms.Button
    Friend WithEvents WpsFilter_Add2_but As System.Windows.Forms.Button
    Friend WithEvents WpsFilter_Add1_but As System.Windows.Forms.Button
    Friend WithEvents WpsFilter_FilterFlex As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents WpsFilter_filternaam_lbl As System.Windows.Forms.Label
    Friend WithEvents WpsFilter_filternaam_txt As System.Windows.Forms.TextBox
    Friend WithEvents WpsFilter_flexcombo As C1.Win.C1List.C1Combo
    Friend WithEvents DatabaseComboWpsFilter As C1.Win.C1List.C1Combo
    Friend WithEvents Invoer_WpsFilterCombo As C1.Win.C1List.C1Combo
    Friend WithEvents Orders_WpsXML_but As System.Windows.Forms.Button
    Friend WithEvents Order_aanvulling_chk As System.Windows.Forms.CheckBox
    Friend WithEvents Tree_Update_but As System.Windows.Forms.Button
    Friend WithEvents OrderResetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StickerType_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents Stikker_lbl As System.Windows.Forms.Label
    Friend WithEvents Order_opmerking_txt As System.Windows.Forms.TextBox
    Friend WithEvents Order_OpmOrderinfo_txt As System.Windows.Forms.TextBox
    Friend WithEvents Order_Pakboninfo_txt As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CodeInvoerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrdersMenuAanvulling As System.Windows.Forms.Button
    Friend WithEvents Vervoer_OphalenSelectie_but As System.Windows.Forms.Button
    Friend WithEvents C1SizerVoorraad As C1.Win.C1Sizer.C1Sizer
    Friend WithEvents PanelVoorraad As System.Windows.Forms.Panel
    Friend WithEvents Voorraad_Flexgrid As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents voorraad_nieuw_but As System.Windows.Forms.Button
    Friend WithEvents GroupBoxVoorraad As System.Windows.Forms.GroupBox
    Friend WithEvents voorraad_opslaan_but As System.Windows.Forms.Button
    Friend WithEvents voorraad_inkoopstuks_but As System.Windows.Forms.Button
    Friend WithEvents voorraad_inkooppallets_but As System.Windows.Forms.Button
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents voorraad_koppelingacce1_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents voorraad_koppelingfust1_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents voorraad_koppelingacce_radio As System.Windows.Forms.RadioButton
    Friend WithEvents voorraad_koppelingfust_radio As System.Windows.Forms.RadioButton
    Friend WithEvents voorraad_besteltijd_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents voorraad_aantalperpallet_txt As System.Windows.Forms.TextBox
    Friend WithEvents voorraad_minimum_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents voorraad_waarschuwing_chk As System.Windows.Forms.CheckBox
    Friend WithEvents voorraad_voorraad_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents voorraad_inkoopstuks_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents voorraad_inkooppallets_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents voorraad_artikelnaam_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents voorraad_bereken_but As System.Windows.Forms.Button
    Friend WithEvents voorraad_id As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Overzicht_gegevensophalen_but As System.Windows.Forms.Button
    Friend WithEvents Overzicht_klantspecifiek_chk As System.Windows.Forms.CheckBox
    Friend WithEvents Overzicht_klantspecifiek_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents Order_PrintBriefFloriday As System.Windows.Forms.Button
    Friend WithEvents TimerBarcodeServer As System.Windows.Forms.Timer
    Friend WithEvents OrdersMenuVerzamelkar As System.Windows.Forms.Button
    Friend WithEvents FC_Toolstrip_SoortOpmerking As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrderStikkersVerzamelkarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents prijzen_actiecode As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents prijzen_accessoire_chk As System.Windows.Forms.CheckBox
    Friend WithEvents LabelberichtStatusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents kar_aanvulling4_but As System.Windows.Forms.Button
    Friend WithEvents kar_aanvulling3_but As System.Windows.Forms.Button
    Friend WithEvents kar_aanvulling2_but As System.Windows.Forms.Button
    Friend WithEvents kar_aanvulling1_but As System.Windows.Forms.Button
    Friend WithEvents Kar_SortMartin_but As System.Windows.Forms.Button
    Friend WithEvents voorraad_koppelingfust4_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents voorraad_koppelingfust3_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents voorraad_koppelingfust2_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents voorraad_koppelingfust5_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents voorraad_koppelingacce3_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents voorraad_koppelingacce2_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents Voorraad_Besteld_chk As System.Windows.Forms.CheckBox
    Friend WithEvents Voorraad_aanpassen_but As System.Windows.Forms.Button
    Friend WithEvents voorraad_annuleer_but As System.Windows.Forms.Button
    Friend WithEvents FcMenu_fczoek_chk As System.Windows.Forms.CheckBox
    Friend WithEvents FcMenu_fczoek_txt As System.Windows.Forms.TextBox
    Friend WithEvents Inst_barcodeserver As System.Windows.Forms.CheckBox
    Friend WithEvents Inst_Overig_GB As System.Windows.Forms.GroupBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Inst_oboektijd7_txt As System.Windows.Forms.TextBox
    Friend WithEvents Inst_odag7_ud As System.Windows.Forms.NumericUpDown
    Friend WithEvents Inst_o7_chk As System.Windows.Forms.CheckBox
    Friend WithEvents Inst_ochktijd7_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Inst_oboektijd6_txt As System.Windows.Forms.TextBox
    Friend WithEvents Inst_odag6_ud As System.Windows.Forms.NumericUpDown
    Friend WithEvents Inst_o6_chk As System.Windows.Forms.CheckBox
    Friend WithEvents Inst_ochktijd6_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Inst_oboektijd5_txt As System.Windows.Forms.TextBox
    Friend WithEvents Inst_odag5_ud As System.Windows.Forms.NumericUpDown
    Friend WithEvents Inst_o5_chk As System.Windows.Forms.CheckBox
    Friend WithEvents Inst_ochktijd5_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Inst_oboektijd4_txt As System.Windows.Forms.TextBox
    Friend WithEvents Inst_odag4_ud As System.Windows.Forms.NumericUpDown
    Friend WithEvents Inst_o4_chk As System.Windows.Forms.CheckBox
    Friend WithEvents Inst_ochktijd4_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Inst_oboektijd3_txt As System.Windows.Forms.TextBox
    Friend WithEvents Inst_odag3_ud As System.Windows.Forms.NumericUpDown
    Friend WithEvents Inst_o3_chk As System.Windows.Forms.CheckBox
    Friend WithEvents Inst_ochktijd3_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Inst_oboektijd2_txt As System.Windows.Forms.TextBox
    Friend WithEvents Inst_odag2_ud As System.Windows.Forms.NumericUpDown
    Friend WithEvents Inst_o2_chk As System.Windows.Forms.CheckBox
    Friend WithEvents Inst_ochktijd2_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Inst_oboektijd1_txt As System.Windows.Forms.TextBox
    Friend WithEvents Inst_odag1_ud As System.Windows.Forms.NumericUpDown
    Friend WithEvents Inst_o1_chk As System.Windows.Forms.CheckBox
    Friend WithEvents Inst_ochktijd1_txt As System.Windows.Forms.TextBox
    Friend WithEvents Inst_Vervoer_annuleren_but As System.Windows.Forms.Button
    Friend WithEvents Inst_Vervoer_opslaan_but As System.Windows.Forms.Button
    Friend WithEvents Inst_Westland_GB As System.Windows.Forms.GroupBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Inst_wboektijd7_txt As System.Windows.Forms.TextBox
    Friend WithEvents Inst_wdag7_ud As System.Windows.Forms.NumericUpDown
    Friend WithEvents Inst_w7_chk As System.Windows.Forms.CheckBox
    Friend WithEvents Inst_wchktijd7_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Inst_wboektijd6_txt As System.Windows.Forms.TextBox
    Friend WithEvents Inst_wdag6_ud As System.Windows.Forms.NumericUpDown
    Friend WithEvents Inst_w6_chk As System.Windows.Forms.CheckBox
    Friend WithEvents Inst_wchktijd6_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Inst_wboektijd5_txt As System.Windows.Forms.TextBox
    Friend WithEvents Inst_wdag5_ud As System.Windows.Forms.NumericUpDown
    Friend WithEvents Inst_w5_chk As System.Windows.Forms.CheckBox
    Friend WithEvents Inst_wchktijd5_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Inst_wboektijd4_txt As System.Windows.Forms.TextBox
    Friend WithEvents Inst_wdag4_ud As System.Windows.Forms.NumericUpDown
    Friend WithEvents Inst_w4_chk As System.Windows.Forms.CheckBox
    Friend WithEvents Inst_wchktijd4_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Inst_wboektijd3_txt As System.Windows.Forms.TextBox
    Friend WithEvents Inst_wdag3_ud As System.Windows.Forms.NumericUpDown
    Friend WithEvents Inst_w3_chk As System.Windows.Forms.CheckBox
    Friend WithEvents Inst_wchktijd3_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Inst_wboektijd2_txt As System.Windows.Forms.TextBox
    Friend WithEvents Inst_wdag2_ud As System.Windows.Forms.NumericUpDown
    Friend WithEvents Inst_w2_chk As System.Windows.Forms.CheckBox
    Friend WithEvents Inst_wchktijd2_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Inst_wboektijd1_txt As System.Windows.Forms.TextBox
    Friend WithEvents Inst_wdag1_ud As System.Windows.Forms.NumericUpDown
    Friend WithEvents Inst_w1_chk As System.Windows.Forms.CheckBox
    Friend WithEvents Inst_wchktijd1_txt As System.Windows.Forms.TextBox
    Friend WithEvents Inst_Vervoer_aanpassen_but As System.Windows.Forms.Button
    Friend WithEvents Inst_dag_lbl As System.Windows.Forms.Label
    Friend WithEvents Inst_vervoerstijden_lbl As System.Windows.Forms.Label
    Friend WithEvents Inst_weekdag_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Inst_Login8_v2_chk As System.Windows.Forms.CheckBox
    Friend WithEvents Inst_Login7_v2_chk As System.Windows.Forms.CheckBox
    Friend WithEvents Inst_Login6_v2_chk As System.Windows.Forms.CheckBox
    Friend WithEvents Inst_Login5_v2_chk As System.Windows.Forms.CheckBox
    Friend WithEvents Inst_Login4_v2_chk As System.Windows.Forms.CheckBox
    Friend WithEvents Inst_Login3_v2_chk As System.Windows.Forms.CheckBox
    Friend WithEvents Inst_Login2_v2_chk As System.Windows.Forms.CheckBox
    Friend WithEvents Inst_Login1_v2_chk As System.Windows.Forms.CheckBox
    Friend WithEvents Inst_run_update_but As System.Windows.Forms.Button
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Inst_Login8_T_chk As System.Windows.Forms.CheckBox
    Friend WithEvents Inst_Login7_T_chk As System.Windows.Forms.CheckBox
    Friend WithEvents Inst_Login6_T_chk As System.Windows.Forms.CheckBox
    Friend WithEvents Inst_Login5_T_chk As System.Windows.Forms.CheckBox
    Friend WithEvents Inst_Login4_T_chk As System.Windows.Forms.CheckBox
    Friend WithEvents Inst_Login3_T_chk As System.Windows.Forms.CheckBox
    Friend WithEvents Inst_Login2_T_chk As System.Windows.Forms.CheckBox
    Friend WithEvents Inst_Login1_T_chk As System.Windows.Forms.CheckBox
    Friend WithEvents TreeVest2_but As System.Windows.Forms.Button
    Friend WithEvents TreeVest1_but As System.Windows.Forms.Button
    Friend WithEvents TreeVestTotaal_but As System.Windows.Forms.Button
    Friend WithEvents Kar_vestiging_lbl As System.Windows.Forms.Label
    Friend WithEvents Orders_pakbonnenprinten As System.Windows.Forms.Button
    Friend WithEvents TimerFlorecom As System.Windows.Forms.Timer
    Friend WithEvents Inst_printerip_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Order_hoescat_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Order_fustcat_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents Order_Prijscor_minS_but As System.Windows.Forms.Button
    Friend WithEvents Order_Prijscor_plusS_but As System.Windows.Forms.Button
    Friend WithEvents DatabaseMenuSDFPL_but As System.Windows.Forms.Button
    Friend WithEvents kar_overgooien4_wis_but As System.Windows.Forms.Button
    Friend WithEvents kar_overgooien4_hierop_but As System.Windows.Forms.Button
    Friend WithEvents kar_overgooien4_naar_but As System.Windows.Forms.Button
    Friend WithEvents kar_overgooien3_wis_but As System.Windows.Forms.Button
    Friend WithEvents kar_overgooien3_hierop_but As System.Windows.Forms.Button
    Friend WithEvents kar_overgooien3_naar_but As System.Windows.Forms.Button
    Friend WithEvents kar_overgooien2_wis_but As System.Windows.Forms.Button
    Friend WithEvents kar_overgooien2_hierop_but As System.Windows.Forms.Button
    Friend WithEvents kar_overgooien2_naar_but As System.Windows.Forms.Button
    Friend WithEvents kar_overgooien1_wis_but As System.Windows.Forms.Button
    Friend WithEvents kar_overgooien1_hierop_but As System.Windows.Forms.Button
    Friend WithEvents kar_overgooien1_naar_but As System.Windows.Forms.Button
    Friend WithEvents kar_wissel_vestiging_but As System.Windows.Forms.Button
    Friend WithEvents OrdersMenuBekijken As System.Windows.Forms.Button
    Friend WithEvents icon1_pbox As System.Windows.Forms.PictureBox
    Friend WithEvents icon1_chk As System.Windows.Forms.CheckBox
    Friend WithEvents icon3_pbox As System.Windows.Forms.PictureBox
    Friend WithEvents icon3_chk As System.Windows.Forms.CheckBox
    Friend WithEvents icon2_pbox As System.Windows.Forms.PictureBox
    Friend WithEvents icon2_chk As System.Windows.Forms.CheckBox
    Friend WithEvents icon4_pbox As System.Windows.Forms.PictureBox
    Friend WithEvents icon4_chk As System.Windows.Forms.CheckBox
    Friend WithEvents GP2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GP3ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrderNaar900VolgendeDagToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents vervoer_vervoerder_klant_but As System.Windows.Forms.Button
    Friend WithEvents vervoer_afleverloc_klant_but As System.Windows.Forms.Button
    Friend WithEvents vervoer_omboek_vervoerder_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents vervoer_omboek_afleverloc_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents vervoer_vervoerder_order_but As System.Windows.Forms.Button
    Friend WithEvents vervoer_afleverloc_order_but As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Overzicht_TotaalNieuw_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents Overzicht_Soortgroep_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents Overzicht_soortgroep_chk As System.Windows.Forms.CheckBox
    Friend WithEvents overzicht_week_lbl As System.Windows.Forms.Label
    Friend WithEvents KarBut40 As System.Windows.Forms.Button
    Friend WithEvents KarBut35 As System.Windows.Forms.Button
    Friend WithEvents Kar_markeer_chk As System.Windows.Forms.CheckBox
    Friend WithEvents OvergooienHieropAanvullenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Inst_printerselect_chk As System.Windows.Forms.CheckBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Inlog_agenda_invullen_txt As System.Windows.Forms.TextBox
    Friend WithEvents Inlog_opslaan_agenda_but As System.Windows.Forms.Button
    Friend WithEvents PakbonSamenvatting As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Inloglijst_lst As System.Windows.Forms.ListBox
    Friend WithEvents InlogTimer As System.Windows.Forms.Timer
    Friend WithEvents FC_Toolstrip_PrijsKoperSet As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActivityTimer_lbl As System.Windows.Forms.Label
    Friend WithEvents inst_boekreload_lbl As System.Windows.Forms.Label
    Friend WithEvents inst_database_boekjenp As System.Windows.Forms.CheckBox
    Friend WithEvents inst_dfdkleinprint As System.Windows.Forms.CheckBox
    Friend WithEvents Overzicht_ExcelExport_but As System.Windows.Forms.Button
    Friend WithEvents Inst_paspoort2_txt As System.Windows.Forms.TextBox
    Friend WithEvents Inst_paspoort1_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Order_bakstikkers_chk As System.Windows.Forms.CheckBox
    Friend WithEvents Order_plantenpaspoort_chk As System.Windows.Forms.CheckBox
    Friend WithEvents Inst_paspoortb2_txt As System.Windows.Forms.TextBox
    Friend WithEvents Inst_paspoortb1_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents FlorecomDel_menuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteFlorecomMenuStrip As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents C1TabFloriday As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1NavBarFloriday As C1.Win.C1Command.C1NavBarPanel
    Friend WithEvents C1SizerFloriday As C1.Win.C1Sizer.C1Sizer
    Friend WithEvents FloridayOrders_flx As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents FdMenu_Zoek_chk As CheckBox
    Friend WithEvents FdMenu_Zoek_txt As TextBox
    Friend WithEvents FdMenu_floridaynr_txt As TextBox
    Friend WithEvents FdMenu_Verwerk_but As Button
    Friend WithEvents FloridayOrderInfo_flx As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents FloridayOrderLines_flx As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents FDLineCombo As C1.Win.C1List.C1Combo
    Friend WithEvents PanelFloridayorders As Panel
    Friend WithEvents Floriday_Filterstoepassen_but As Button
    Friend WithEvents Floriday_orderlineherstellen_but As Button
    Friend WithEvents DatabaseMenuCopy_but As Button
    Friend WithEvents DatabaseMenuHerladen_but As Button
    Friend WithEvents Database_preselect_cmb As ComboBox
    Friend WithEvents TestBuild_but As Button
    Friend WithEvents Orders_PlusAccessoires_but As Button
    Friend WithEvents Floriday_Calendar As MonthCalendar
    Friend WithEvents Fd_archief_rb As RadioButton
    Friend WithEvents Fd_nieuweOrders_rb As RadioButton
    Friend WithEvents fd_updatelist_but As Button
    Friend WithEvents Tree_BBKlok_cmb As ComboBox
    Friend WithEvents KarCommand1_but As Button
    Friend WithEvents KarCommand1_cmb As ComboBox
    Friend WithEvents KarCommand4_but As Button
    Friend WithEvents KarCommand4_cmb As ComboBox
    Friend WithEvents KarCommand3_but As Button
    Friend WithEvents KarCommand3_cmb As ComboBox
    Friend WithEvents KarCommand2_but As Button
    Friend WithEvents KarCommand2_cmb As ComboBox
    Friend WithEvents Kar_fdverzonden4_chk As CheckBox
    Friend WithEvents Kar_fdverzonden3_chk As CheckBox
    Friend WithEvents Kar_fdverzonden2_chk As CheckBox
    Friend WithEvents Kar_fdverzonden1_chk As CheckBox
    Friend WithEvents FdMenu_ordernr_chk As CheckBox
    Friend WithEvents FdMenu_Nietverwerken_but As Button
    Friend WithEvents FCMenu_Nietverwerken_but As Button
    Friend WithEvents FloridayOrderAanpassenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Kar_Kartype4_cmb As ComboBox
    Friend WithEvents Kar_Kartype3_cmb As ComboBox
    Friend WithEvents Kar_Kartype2_cmb As ComboBox
    Friend WithEvents Kar_Kartype1_cmb As ComboBox
    Friend WithEvents DBOverzichten_but As Button
End Class