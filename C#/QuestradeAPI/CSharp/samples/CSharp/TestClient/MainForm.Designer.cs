namespace QuestradeAPI.Net.TestClient
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.m_rtbActivityLog = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_grpAuthenticate = new System.Windows.Forms.GroupBox();
            this.m_chkIsDemo = new System.Windows.Forms.CheckBox();
            this.m_txtRefreshToken = new System.Windows.Forms.TextBox();
            this.m_lblRefreshToken = new System.Windows.Forms.Label();
            this.m_btnGetTime = new System.Windows.Forms.Button();
            this.m_lblAuthStatus = new System.Windows.Forms.Label();
            this.m_btnAuth = new System.Windows.Forms.Button();
            this.m_btnReplaceOrder = new System.Windows.Forms.Button();
            this.m_btnCancelOrder = new System.Windows.Forms.Button();
            this.m_btnInsertOrder = new System.Windows.Forms.Button();
            this.m_lblActivityLog = new System.Windows.Forms.Label();
            this.m_tabs = new System.Windows.Forms.TabControl();
            this.m_tabAccountData = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.m_tabsAccounts = new System.Windows.Forms.TabControl();
            this.m_tabBalances = new System.Windows.Forms.TabPage();
            this.m_tabAccountBalances = new System.Windows.Forms.TabControl();
            this.m_tabCurrentBalances = new System.Windows.Forms.TabPage();
            this.m_grdCurrentBalances = new System.Windows.Forms.DataGridView();
            this.m_colCurrentBalancesCurrentBalances = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colCurrentBalancesCad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colCurrentBalancesUsd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colCurrentBalancesCadCombined = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colCurrentBalancesUsdCombined = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_tabSodBalances = new System.Windows.Forms.TabPage();
            this.m_grdSodBalances = new System.Windows.Forms.DataGridView();
            this.m_colSodBalancesSodBalances = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colSodBalancesCad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colSodBalancesUsd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colSodBalancesCadCombined = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colSodBalancesUsdCombined = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_btnRefreshBalancesAsync = new System.Windows.Forms.Button();
            this.m_btnRefreshBalancesSync = new System.Windows.Forms.Button();
            this.m_tabPositions = new System.Windows.Forms.TabPage();
            this.m_btnRefreshPositionsAsync = new System.Windows.Forms.Button();
            this.m_btnRefreshPositionsSync = new System.Windows.Forms.Button();
            this.m_grdPositions = new System.Windows.Forms.DataGridView();
            this.m_colPositionsSymbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colPositionsSymbolId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colPositionsOpenQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colPositionsClosedQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colPositionsCurrMktVal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colPositionsCurrPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colPositionsAvgEntryPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colPositionsClosedPnl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colPositionsOpenPnl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colPositionsTotalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colPositionsIsRealTime = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.m_colPositionsIsUnderReorg = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.m_tabOrders = new System.Windows.Forms.TabPage();
            this.label21 = new System.Windows.Forms.Label();
            this.m_grdOrderLegs = new System.Windows.Forms.DataGridView();
            this.m_colOrderLegsLegId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colOrderLegsSymbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colOrderLegsSymbolId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colOrderLegsLegRatioQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colOrderLegsSide = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colOrderLegsAvgExecPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colOrderLegsLastExecPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.m_cmbStateFilter = new System.Windows.Forms.ComboBox();
            this.m_lblGetOrdersByDateStateFilter = new System.Windows.Forms.Label();
            this.m_txtGetOrderByIdOrderId = new System.Windows.Forms.TextBox();
            this.m_lblGetOrderByIdOrderId = new System.Windows.Forms.Label();
            this.m_rbGetOrderByID = new System.Windows.Forms.RadioButton();
            this.m_rbGetOrdersByDate = new System.Windows.Forms.RadioButton();
            this.m_dtpGetOrdersEndTime = new System.Windows.Forms.DateTimePicker();
            this.m_lblGetOrdersByDateStartTime = new System.Windows.Forms.Label();
            this.m_lblGetOrdersByDateEndTime = new System.Windows.Forms.Label();
            this.m_dtpGetOrdersStartTime = new System.Windows.Forms.DateTimePicker();
            this.m_lblGetOrdersRateLimitRequestsResetTime = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.m_lblGetOrdersRateLimitRemainingRequestsCount = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.m_btnRefreshOrdersAsync = new System.Windows.Forms.Button();
            this.m_btnRefreshOrdersSync = new System.Windows.Forms.Button();
            this.m_grdOrders = new System.Windows.Forms.DataGridView();
            this.m_colOrdersId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colOrdersSymbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colOrdersSymbolId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colOrdersTotalQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colOrdersOpenQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colOrdersFilledQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colOrdersCanceledQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colOrdersSide = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colOrdersOrderType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colOrdersLimitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colOrdersStopPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colOrdersIsAllOrNone = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.m_colOrdersIsAnon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.m_colOrdersIcebergQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colOrdersMinQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colOrdersAvgExecPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colOrdersLastExecPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colOrdersSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colOrdersTimeInForce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colOrdersGtdDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colOrdersState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colOrdersRejectionReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colOrdersChainId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colOrdersCreationTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colOrdersUpdateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colOrdersNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colOrdersPrimaryRoute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colOrdersSecondaryRoute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colOrdersOrderRoute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colOrdersVenueHoldingOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colOrdersCommissionCharged = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colOrdersExchangeOrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colOrdersIsSigShareHolder = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.m_colOrdersIsInsider = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.m_colOrdersIsLimitOffsetInDollar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.m_colOrdersUserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colOrdersPlacementCommission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colOrdersStrategyType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colOrdersTriggerStopPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colOrdersOrderGroupId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colOrdersOrderClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_tabExecutions = new System.Windows.Forms.TabPage();
            this.m_dtpGetExecutionsEndTime = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.m_dtpGetExecutionsStartTime = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.m_btnRefreshExecutionsAsync = new System.Windows.Forms.Button();
            this.m_btnRefreshExecutionsSync = new System.Windows.Forms.Button();
            this.m_grdExecutions = new System.Windows.Forms.DataGridView();
            this.m_colExecutionsSymbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colExecutionsSymbolId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colExecutionsQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colExecutionsSide = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colExecutionsPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colExecutionsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colExecutionsOrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colExecutionsOrderChainId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colExecutionsExchangeExecId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colExecutionsTimestamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colExecutionsNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colExecutionsVenue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colExecutionsTotalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colExecutionsPlacementCommission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colExecutionsCommission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colExecutionsExecFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colExecutionsSecFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colExecutionsLegId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colExecutionsCdnExecFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colExecutionsParentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.m_btnRefreshAsync = new System.Windows.Forms.Button();
            this.m_lblAccountDataRateLimitRemainingRequestsCount = new System.Windows.Forms.Label();
            this.m_lblGetAccountsUserId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.m_btnRefreshAccountsSync = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.m_grdAccounts = new System.Windows.Forms.DataGridView();
            this.m_colAccountType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colAccountNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colAccountStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colAccountIsPrimary = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.m_colAccountIsBilling = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.m_colAccountClientAccountType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_lblAccountDataRateLimitRequestsResetTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.m_tabMarketData = new System.Windows.Forms.TabPage();
            this.panel10 = new System.Windows.Forms.Panel();
            this.m_tabsMarketData = new System.Windows.Forms.TabControl();
            this.m_tabSearchSymbols = new System.Windows.Forms.TabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.m_grdSymbolSearch = new System.Windows.Forms.DataGridView();
            this.m_colSymbolSearchSymbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colSymbolSearchSymbolId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colSymbolSearchDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colSymbolSearchSecurityType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colSymbolSearchIsCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colSymbolSearchListingExchange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colSymbolSearchIsTradable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.m_colSymbolSearchIsQuotable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel7 = new System.Windows.Forms.Panel();
            this.m_btnRefreshSymbolSearchAsync = new System.Windows.Forms.Button();
            this.m_btnRefreshSymbolSearchSync = new System.Windows.Forms.Button();
            this.m_lblSymbolSearchSelectedSymbols = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.m_txtOffset = new System.Windows.Forms.TextBox();
            this.m_lblOffset = new System.Windows.Forms.Label();
            this.m_txtPrefix = new System.Windows.Forms.TextBox();
            this.m_lblPrefix = new System.Windows.Forms.Label();
            this.m_tabGetSymbols = new System.Windows.Forms.TabPage();
            this.m_txtSymbolDataSymbolIds = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.m_grdSymbolsContractDeliverables = new System.Windows.Forms.DataGridView();
            this.m_colSymbolDataContractDeliverablesMultiplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colSymbolDataContractDeliverablesUnderlyingSymbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colSymbolDataContractDeliverablesUnderlyingSymbolId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.m_grdSymbolsMinTicks = new System.Windows.Forms.DataGridView();
            this.m_colSymbolDataMinTicksPivot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colSymbolDataMinTicksMinTick = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.m_btnRefreshSymbolsAsync = new System.Windows.Forms.Button();
            this.m_btnRefreshSymbolsSync = new System.Windows.Forms.Button();
            this.m_grdSymbols = new System.Windows.Forms.DataGridView();
            this.m_colSymbolsSymbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colSymbolsSymbolId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colSymbolsPrevDayClosePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colSymbolsHighPrice52 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colSymbolsLowPrice52 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colSymbolsAverageVol3Months = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colSymbolsAverageVol20Days = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colSymbolsOutstandingShares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colSymbolsEps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colSymbolsPe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colSymbolsDividend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colSymbolsYield = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colSymbolsExDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colSymbolsMarketCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colSymbolsTradeUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colSymbolsOptionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colSymbolsOptionDurationType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colSymbolsOptionRoot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colSymbolsOptionExerciseType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colSymbolsListingExchange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colSymbolsDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colSymbolsSecurityType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colSymbolsOptionExpiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colSymbolsDividendDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colSymbolsOptionStrikePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colSymbolsIsTradable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.m_colSymbolsIsQuotable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.m_colSymbolsHasOptions = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.m_colSymbolsCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colSymbolsContractDeliverablesCashInLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_tabGetQuotes = new System.Windows.Forms.TabPage();
            this.m_txtQuotesSymbolIds = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.m_btnRefreshQuotesAsync = new System.Windows.Forms.Button();
            this.m_btnRefreshQuotesSync = new System.Windows.Forms.Button();
            this.m_grdQuotes = new System.Windows.Forms.DataGridView();
            this.m_colQuotesSymbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colQuotesSymbolId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colQuotesBidPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colQuotesBidSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colQuotesAskPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colQuotesAskSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colQuotesLastTradePriceTrHrs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colQuotesLastTradePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colQuotesLastTradeSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colQuotesLastTradeTick = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colQuotesLastTradeTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colQuotesVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colQuotesOpenPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colQuotesHighPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colQuotesLowPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colQuotesDelay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colQuotesIsHalted = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.m_tabGetCandles = new System.Windows.Forms.TabPage();
            this.m_dtpGetCandlesEndTime = new System.Windows.Forms.DateTimePicker();
            this.m_lblEndTime = new System.Windows.Forms.Label();
            this.m_dtpGetCandlesStartTime = new System.Windows.Forms.DateTimePicker();
            this.m_lblStartTime = new System.Windows.Forms.Label();
            this.m_cmbInterval = new System.Windows.Forms.ComboBox();
            this.m_lblInterval = new System.Windows.Forms.Label();
            this.m_btnRefreshCandlesAsync = new System.Windows.Forms.Button();
            this.m_btnRefreshCandlesSync = new System.Windows.Forms.Button();
            this.m_grdCandles = new System.Windows.Forms.DataGridView();
            this.m_colCandlesStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colCandlesEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colCandlesLow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colCandlesHigh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colCandlesOpen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colCandlesClose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colCandlesVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_tabGetOptions = new System.Windows.Forms.TabPage();
            this.m_txtOptionChainSymbolIds = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.m_btnRefreshOptionsAsync = new System.Windows.Forms.Button();
            this.m_btnRefreshOptionsSync = new System.Windows.Forms.Button();
            this.m_grdOptions = new System.Windows.Forms.DataGridView();
            this.m_colOptionsExpiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colOptionsOptionRoot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colOptionsMultiplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colOptionsStrikePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colOptionsCallSymbolId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colOptionsPutSymbolId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_tabGetMarkets = new System.Windows.Forms.TabPage();
            this.m_lstLevel2Feeds = new System.Windows.Forms.ListBox();
            this.m_lstLevel1Feeds = new System.Windows.Forms.ListBox();
            this.m_lstSecondaryOrderRoutes = new System.Windows.Forms.ListBox();
            this.m_lstPrimaryOrderRoutes = new System.Windows.Forms.ListBox();
            this.m_lstTradingVenues = new System.Windows.Forms.ListBox();
            this.label48 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.m_btnRefreshMarketsAsync = new System.Windows.Forms.Button();
            this.m_btnRefreshMarketsSync = new System.Windows.Forms.Button();
            this.m_grdMarkets = new System.Windows.Forms.DataGridView();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.m_lblMarketDataRateLimitRemainingRequestsCount = new System.Windows.Forms.Label();
            this.m_lblMarketDataRateLimitRequestsResetTime = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_colMarketsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colMarketsDefaultTradingVenue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colMarketsExtendedStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colMarketsStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colMarketsEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colMarketsExtendedEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colMarketsSnapQuotesLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1.SuspendLayout();
            this.m_grpAuthenticate.SuspendLayout();
            this.m_tabs.SuspendLayout();
            this.m_tabAccountData.SuspendLayout();
            this.panel6.SuspendLayout();
            this.m_tabsAccounts.SuspendLayout();
            this.m_tabBalances.SuspendLayout();
            this.m_tabAccountBalances.SuspendLayout();
            this.m_tabCurrentBalances.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grdCurrentBalances)).BeginInit();
            this.m_tabSodBalances.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grdSodBalances)).BeginInit();
            this.m_tabPositions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grdPositions)).BeginInit();
            this.m_tabOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grdOrderLegs)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grdOrders)).BeginInit();
            this.m_tabExecutions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grdExecutions)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grdAccounts)).BeginInit();
            this.m_tabMarketData.SuspendLayout();
            this.panel10.SuspendLayout();
            this.m_tabsMarketData.SuspendLayout();
            this.m_tabSearchSymbols.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grdSymbolSearch)).BeginInit();
            this.panel7.SuspendLayout();
            this.m_tabGetSymbols.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grdSymbolsContractDeliverables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grdSymbolsMinTicks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grdSymbols)).BeginInit();
            this.m_tabGetQuotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grdQuotes)).BeginInit();
            this.m_tabGetCandles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grdCandles)).BeginInit();
            this.m_tabGetOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grdOptions)).BeginInit();
            this.m_tabGetMarkets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grdMarkets)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_rtbActivityLog
            // 
            this.m_rtbActivityLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_rtbActivityLog.BackColor = System.Drawing.SystemColors.Window;
            this.m_rtbActivityLog.ContextMenuStrip = this.contextMenuStrip1;
            this.m_rtbActivityLog.Location = new System.Drawing.Point(5, 21);
            this.m_rtbActivityLog.Name = "m_rtbActivityLog";
            this.m_rtbActivityLog.ReadOnly = true;
            this.m_rtbActivityLog.Size = new System.Drawing.Size(824, 119);
            this.m_rtbActivityLog.TabIndex = 1;
            this.m_rtbActivityLog.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(102, 26);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem.Text = "&Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // m_grpAuthenticate
            // 
            this.m_grpAuthenticate.Controls.Add(this.m_chkIsDemo);
            this.m_grpAuthenticate.Controls.Add(this.m_txtRefreshToken);
            this.m_grpAuthenticate.Controls.Add(this.m_lblRefreshToken);
            this.m_grpAuthenticate.Controls.Add(this.m_btnGetTime);
            this.m_grpAuthenticate.Controls.Add(this.m_lblAuthStatus);
            this.m_grpAuthenticate.Controls.Add(this.m_btnAuth);
            this.m_grpAuthenticate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grpAuthenticate.Location = new System.Drawing.Point(0, 0);
            this.m_grpAuthenticate.Name = "m_grpAuthenticate";
            this.m_grpAuthenticate.Size = new System.Drawing.Size(832, 64);
            this.m_grpAuthenticate.TabIndex = 2;
            this.m_grpAuthenticate.TabStop = false;
            this.m_grpAuthenticate.Text = "Authentication";
            // 
            // m_chkIsDemo
            // 
            this.m_chkIsDemo.AutoSize = true;
            this.m_chkIsDemo.Location = new System.Drawing.Point(281, 18);
            this.m_chkIsDemo.Name = "m_chkIsDemo";
            this.m_chkIsDemo.Size = new System.Drawing.Size(65, 17);
            this.m_chkIsDemo.TabIndex = 12;
            this.m_chkIsDemo.Text = "Practice";
            this.m_chkIsDemo.UseVisualStyleBackColor = true;
            // 
            // m_txtRefreshToken
            // 
            this.m_txtRefreshToken.Location = new System.Drawing.Point(93, 16);
            this.m_txtRefreshToken.Name = "m_txtRefreshToken";
            this.m_txtRefreshToken.Size = new System.Drawing.Size(182, 20);
            this.m_txtRefreshToken.TabIndex = 11;
            this.m_txtRefreshToken.TextChanged += new System.EventHandler(this.m_txtRefreshToken_TextChanged);
            // 
            // m_lblRefreshToken
            // 
            this.m_lblRefreshToken.AutoSize = true;
            this.m_lblRefreshToken.Location = new System.Drawing.Point(6, 19);
            this.m_lblRefreshToken.Name = "m_lblRefreshToken";
            this.m_lblRefreshToken.Size = new System.Drawing.Size(81, 13);
            this.m_lblRefreshToken.TabIndex = 10;
            this.m_lblRefreshToken.Text = "Refresh Token:";
            // 
            // m_btnGetTime
            // 
            this.m_btnGetTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnGetTime.Location = new System.Drawing.Point(730, 14);
            this.m_btnGetTime.Name = "m_btnGetTime";
            this.m_btnGetTime.Size = new System.Drawing.Size(87, 23);
            this.m_btnGetTime.TabIndex = 7;
            this.m_btnGetTime.Text = "Get Time";
            this.m_btnGetTime.UseVisualStyleBackColor = true;
            this.m_btnGetTime.Click += new System.EventHandler(this.m_btnGetTime_Click);
            // 
            // m_lblAuthStatus
            // 
            this.m_lblAuthStatus.AutoSize = true;
            this.m_lblAuthStatus.Location = new System.Drawing.Point(436, 19);
            this.m_lblAuthStatus.Name = "m_lblAuthStatus";
            this.m_lblAuthStatus.Size = new System.Drawing.Size(93, 13);
            this.m_lblAuthStatus.TabIndex = 1;
            this.m_lblAuthStatus.Text = "Not Authenticated";
            // 
            // m_btnAuth
            // 
            this.m_btnAuth.Location = new System.Drawing.Point(347, 14);
            this.m_btnAuth.Name = "m_btnAuth";
            this.m_btnAuth.Size = new System.Drawing.Size(83, 23);
            this.m_btnAuth.TabIndex = 0;
            this.m_btnAuth.Text = "Authenticate";
            this.m_btnAuth.UseVisualStyleBackColor = true;
            this.m_btnAuth.Click += new System.EventHandler(this.m_btnAuth_Click);
            // 
            // m_btnReplaceOrder
            // 
            this.m_btnReplaceOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnReplaceOrder.Location = new System.Drawing.Point(625, 6);
            this.m_btnReplaceOrder.Name = "m_btnReplaceOrder";
            this.m_btnReplaceOrder.Size = new System.Drawing.Size(85, 23);
            this.m_btnReplaceOrder.TabIndex = 2;
            this.m_btnReplaceOrder.Text = "Replace";
            this.m_btnReplaceOrder.UseVisualStyleBackColor = true;
            this.m_btnReplaceOrder.Click += new System.EventHandler(this.m_btnReplaceOrder_Click);
            // 
            // m_btnCancelOrder
            // 
            this.m_btnCancelOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnCancelOrder.Location = new System.Drawing.Point(719, 6);
            this.m_btnCancelOrder.Name = "m_btnCancelOrder";
            this.m_btnCancelOrder.Size = new System.Drawing.Size(85, 23);
            this.m_btnCancelOrder.TabIndex = 1;
            this.m_btnCancelOrder.Text = "Cancel";
            this.m_btnCancelOrder.UseVisualStyleBackColor = true;
            this.m_btnCancelOrder.Click += new System.EventHandler(this.m_btnCancelOrder_Click);
            // 
            // m_btnInsertOrder
            // 
            this.m_btnInsertOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnInsertOrder.Location = new System.Drawing.Point(531, 6);
            this.m_btnInsertOrder.Name = "m_btnInsertOrder";
            this.m_btnInsertOrder.Size = new System.Drawing.Size(85, 23);
            this.m_btnInsertOrder.TabIndex = 0;
            this.m_btnInsertOrder.Text = "New Order";
            this.m_btnInsertOrder.UseVisualStyleBackColor = true;
            this.m_btnInsertOrder.Click += new System.EventHandler(this.m_btnInsertOrder_Click);
            // 
            // m_lblActivityLog
            // 
            this.m_lblActivityLog.AutoSize = true;
            this.m_lblActivityLog.Location = new System.Drawing.Point(3, 5);
            this.m_lblActivityLog.Name = "m_lblActivityLog";
            this.m_lblActivityLog.Size = new System.Drawing.Size(65, 13);
            this.m_lblActivityLog.TabIndex = 6;
            this.m_lblActivityLog.Text = "Activity Log:";
            // 
            // m_tabs
            // 
            this.m_tabs.Controls.Add(this.m_tabAccountData);
            this.m_tabs.Controls.Add(this.m_tabMarketData);
            this.m_tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_tabs.Location = new System.Drawing.Point(0, 0);
            this.m_tabs.Name = "m_tabs";
            this.m_tabs.SelectedIndex = 0;
            this.m_tabs.Size = new System.Drawing.Size(832, 584);
            this.m_tabs.TabIndex = 7;
            // 
            // m_tabAccountData
            // 
            this.m_tabAccountData.Controls.Add(this.panel6);
            this.m_tabAccountData.Controls.Add(this.panel5);
            this.m_tabAccountData.Location = new System.Drawing.Point(4, 22);
            this.m_tabAccountData.Name = "m_tabAccountData";
            this.m_tabAccountData.Padding = new System.Windows.Forms.Padding(3);
            this.m_tabAccountData.Size = new System.Drawing.Size(824, 558);
            this.m_tabAccountData.TabIndex = 0;
            this.m_tabAccountData.Text = "Account Data";
            this.m_tabAccountData.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.m_tabsAccounts);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 123);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(818, 432);
            this.panel6.TabIndex = 12;
            // 
            // m_tabsAccounts
            // 
            this.m_tabsAccounts.Controls.Add(this.m_tabBalances);
            this.m_tabsAccounts.Controls.Add(this.m_tabPositions);
            this.m_tabsAccounts.Controls.Add(this.m_tabOrders);
            this.m_tabsAccounts.Controls.Add(this.m_tabExecutions);
            this.m_tabsAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_tabsAccounts.Location = new System.Drawing.Point(0, 0);
            this.m_tabsAccounts.Name = "m_tabsAccounts";
            this.m_tabsAccounts.SelectedIndex = 0;
            this.m_tabsAccounts.Size = new System.Drawing.Size(818, 432);
            this.m_tabsAccounts.TabIndex = 0;
            // 
            // m_tabBalances
            // 
            this.m_tabBalances.Controls.Add(this.m_tabAccountBalances);
            this.m_tabBalances.Controls.Add(this.m_btnRefreshBalancesAsync);
            this.m_tabBalances.Controls.Add(this.m_btnRefreshBalancesSync);
            this.m_tabBalances.Location = new System.Drawing.Point(4, 22);
            this.m_tabBalances.Name = "m_tabBalances";
            this.m_tabBalances.Padding = new System.Windows.Forms.Padding(3);
            this.m_tabBalances.Size = new System.Drawing.Size(810, 406);
            this.m_tabBalances.TabIndex = 4;
            this.m_tabBalances.Text = "Balances";
            this.m_tabBalances.UseVisualStyleBackColor = true;
            // 
            // m_tabAccountBalances
            // 
            this.m_tabAccountBalances.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_tabAccountBalances.Controls.Add(this.m_tabCurrentBalances);
            this.m_tabAccountBalances.Controls.Add(this.m_tabSodBalances);
            this.m_tabAccountBalances.Location = new System.Drawing.Point(9, 30);
            this.m_tabAccountBalances.Name = "m_tabAccountBalances";
            this.m_tabAccountBalances.SelectedIndex = 0;
            this.m_tabAccountBalances.Size = new System.Drawing.Size(795, 370);
            this.m_tabAccountBalances.TabIndex = 29;
            // 
            // m_tabCurrentBalances
            // 
            this.m_tabCurrentBalances.Controls.Add(this.m_grdCurrentBalances);
            this.m_tabCurrentBalances.Location = new System.Drawing.Point(4, 22);
            this.m_tabCurrentBalances.Name = "m_tabCurrentBalances";
            this.m_tabCurrentBalances.Padding = new System.Windows.Forms.Padding(3);
            this.m_tabCurrentBalances.Size = new System.Drawing.Size(787, 344);
            this.m_tabCurrentBalances.TabIndex = 0;
            this.m_tabCurrentBalances.Text = "Current";
            this.m_tabCurrentBalances.UseVisualStyleBackColor = true;
            // 
            // m_grdCurrentBalances
            // 
            this.m_grdCurrentBalances.AllowUserToAddRows = false;
            this.m_grdCurrentBalances.AllowUserToDeleteRows = false;
            this.m_grdCurrentBalances.AllowUserToOrderColumns = true;
            this.m_grdCurrentBalances.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.m_grdCurrentBalances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_grdCurrentBalances.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.m_colCurrentBalancesCurrentBalances,
            this.m_colCurrentBalancesCad,
            this.m_colCurrentBalancesUsd,
            this.m_colCurrentBalancesCadCombined,
            this.m_colCurrentBalancesUsdCombined});
            this.m_grdCurrentBalances.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grdCurrentBalances.Location = new System.Drawing.Point(3, 3);
            this.m_grdCurrentBalances.MultiSelect = false;
            this.m_grdCurrentBalances.Name = "m_grdCurrentBalances";
            this.m_grdCurrentBalances.ReadOnly = true;
            this.m_grdCurrentBalances.RowHeadersVisible = false;
            this.m_grdCurrentBalances.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.m_grdCurrentBalances.Size = new System.Drawing.Size(781, 338);
            this.m_grdCurrentBalances.TabIndex = 1;
            // 
            // m_colCurrentBalancesCurrentBalances
            // 
            this.m_colCurrentBalancesCurrentBalances.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colCurrentBalancesCurrentBalances.HeaderText = "Current balances";
            this.m_colCurrentBalancesCurrentBalances.MinimumWidth = 100;
            this.m_colCurrentBalancesCurrentBalances.Name = "m_colCurrentBalancesCurrentBalances";
            this.m_colCurrentBalancesCurrentBalances.ReadOnly = true;
            // 
            // m_colCurrentBalancesCad
            // 
            this.m_colCurrentBalancesCad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Format = "C2";
            this.m_colCurrentBalancesCad.DefaultCellStyle = dataGridViewCellStyle1;
            this.m_colCurrentBalancesCad.HeaderText = "CAD";
            this.m_colCurrentBalancesCad.MinimumWidth = 100;
            this.m_colCurrentBalancesCad.Name = "m_colCurrentBalancesCad";
            this.m_colCurrentBalancesCad.ReadOnly = true;
            // 
            // m_colCurrentBalancesUsd
            // 
            this.m_colCurrentBalancesUsd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Format = "C2";
            this.m_colCurrentBalancesUsd.DefaultCellStyle = dataGridViewCellStyle2;
            this.m_colCurrentBalancesUsd.HeaderText = "USD";
            this.m_colCurrentBalancesUsd.MinimumWidth = 100;
            this.m_colCurrentBalancesUsd.Name = "m_colCurrentBalancesUsd";
            this.m_colCurrentBalancesUsd.ReadOnly = true;
            // 
            // m_colCurrentBalancesCadCombined
            // 
            this.m_colCurrentBalancesCadCombined.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Format = "C2";
            this.m_colCurrentBalancesCadCombined.DefaultCellStyle = dataGridViewCellStyle3;
            this.m_colCurrentBalancesCadCombined.HeaderText = "CAD (comb)";
            this.m_colCurrentBalancesCadCombined.MinimumWidth = 100;
            this.m_colCurrentBalancesCadCombined.Name = "m_colCurrentBalancesCadCombined";
            this.m_colCurrentBalancesCadCombined.ReadOnly = true;
            // 
            // m_colCurrentBalancesUsdCombined
            // 
            this.m_colCurrentBalancesUsdCombined.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Format = "C2";
            this.m_colCurrentBalancesUsdCombined.DefaultCellStyle = dataGridViewCellStyle4;
            this.m_colCurrentBalancesUsdCombined.HeaderText = "USD (comb)";
            this.m_colCurrentBalancesUsdCombined.MinimumWidth = 100;
            this.m_colCurrentBalancesUsdCombined.Name = "m_colCurrentBalancesUsdCombined";
            this.m_colCurrentBalancesUsdCombined.ReadOnly = true;
            // 
            // m_tabSodBalances
            // 
            this.m_tabSodBalances.Controls.Add(this.m_grdSodBalances);
            this.m_tabSodBalances.Location = new System.Drawing.Point(4, 22);
            this.m_tabSodBalances.Name = "m_tabSodBalances";
            this.m_tabSodBalances.Padding = new System.Windows.Forms.Padding(3);
            this.m_tabSodBalances.Size = new System.Drawing.Size(787, 344);
            this.m_tabSodBalances.TabIndex = 1;
            this.m_tabSodBalances.Text = "Start of Day";
            this.m_tabSodBalances.UseVisualStyleBackColor = true;
            // 
            // m_grdSodBalances
            // 
            this.m_grdSodBalances.AllowUserToAddRows = false;
            this.m_grdSodBalances.AllowUserToDeleteRows = false;
            this.m_grdSodBalances.AllowUserToOrderColumns = true;
            this.m_grdSodBalances.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.m_grdSodBalances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_grdSodBalances.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.m_colSodBalancesSodBalances,
            this.m_colSodBalancesCad,
            this.m_colSodBalancesUsd,
            this.m_colSodBalancesCadCombined,
            this.m_colSodBalancesUsdCombined});
            this.m_grdSodBalances.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grdSodBalances.Location = new System.Drawing.Point(3, 3);
            this.m_grdSodBalances.MultiSelect = false;
            this.m_grdSodBalances.Name = "m_grdSodBalances";
            this.m_grdSodBalances.ReadOnly = true;
            this.m_grdSodBalances.RowHeadersVisible = false;
            this.m_grdSodBalances.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.m_grdSodBalances.Size = new System.Drawing.Size(781, 338);
            this.m_grdSodBalances.TabIndex = 2;
            // 
            // m_colSodBalancesSodBalances
            // 
            this.m_colSodBalancesSodBalances.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colSodBalancesSodBalances.HeaderText = "Start of day balances";
            this.m_colSodBalancesSodBalances.MinimumWidth = 100;
            this.m_colSodBalancesSodBalances.Name = "m_colSodBalancesSodBalances";
            this.m_colSodBalancesSodBalances.ReadOnly = true;
            // 
            // m_colSodBalancesCad
            // 
            this.m_colSodBalancesCad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Format = "C2";
            this.m_colSodBalancesCad.DefaultCellStyle = dataGridViewCellStyle5;
            this.m_colSodBalancesCad.HeaderText = "CAD";
            this.m_colSodBalancesCad.MinimumWidth = 100;
            this.m_colSodBalancesCad.Name = "m_colSodBalancesCad";
            this.m_colSodBalancesCad.ReadOnly = true;
            // 
            // m_colSodBalancesUsd
            // 
            this.m_colSodBalancesUsd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Format = "C2";
            this.m_colSodBalancesUsd.DefaultCellStyle = dataGridViewCellStyle6;
            this.m_colSodBalancesUsd.HeaderText = "USD";
            this.m_colSodBalancesUsd.MinimumWidth = 100;
            this.m_colSodBalancesUsd.Name = "m_colSodBalancesUsd";
            this.m_colSodBalancesUsd.ReadOnly = true;
            // 
            // m_colSodBalancesCadCombined
            // 
            this.m_colSodBalancesCadCombined.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Format = "C2";
            this.m_colSodBalancesCadCombined.DefaultCellStyle = dataGridViewCellStyle7;
            this.m_colSodBalancesCadCombined.HeaderText = "CAD (comb)";
            this.m_colSodBalancesCadCombined.MinimumWidth = 100;
            this.m_colSodBalancesCadCombined.Name = "m_colSodBalancesCadCombined";
            this.m_colSodBalancesCadCombined.ReadOnly = true;
            // 
            // m_colSodBalancesUsdCombined
            // 
            this.m_colSodBalancesUsdCombined.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.Format = "C2";
            this.m_colSodBalancesUsdCombined.DefaultCellStyle = dataGridViewCellStyle8;
            this.m_colSodBalancesUsdCombined.HeaderText = "USD (comb)";
            this.m_colSodBalancesUsdCombined.MinimumWidth = 100;
            this.m_colSodBalancesUsdCombined.Name = "m_colSodBalancesUsdCombined";
            this.m_colSodBalancesUsdCombined.ReadOnly = true;
            // 
            // m_btnRefreshBalancesAsync
            // 
            this.m_btnRefreshBalancesAsync.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnRefreshBalancesAsync.Location = new System.Drawing.Point(719, 8);
            this.m_btnRefreshBalancesAsync.Name = "m_btnRefreshBalancesAsync";
            this.m_btnRefreshBalancesAsync.Size = new System.Drawing.Size(85, 23);
            this.m_btnRefreshBalancesAsync.TabIndex = 22;
            this.m_btnRefreshBalancesAsync.Text = "Refresh Async";
            this.m_btnRefreshBalancesAsync.UseVisualStyleBackColor = true;
            this.m_btnRefreshBalancesAsync.Click += new System.EventHandler(this.m_btnRefreshBalancesAsync_Click);
            // 
            // m_btnRefreshBalancesSync
            // 
            this.m_btnRefreshBalancesSync.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnRefreshBalancesSync.Location = new System.Drawing.Point(628, 8);
            this.m_btnRefreshBalancesSync.Name = "m_btnRefreshBalancesSync";
            this.m_btnRefreshBalancesSync.Size = new System.Drawing.Size(85, 23);
            this.m_btnRefreshBalancesSync.TabIndex = 21;
            this.m_btnRefreshBalancesSync.Text = "Refresh";
            this.m_btnRefreshBalancesSync.UseVisualStyleBackColor = true;
            this.m_btnRefreshBalancesSync.Click += new System.EventHandler(this.m_btnRefreshBalancesSync_Click);
            // 
            // m_tabPositions
            // 
            this.m_tabPositions.Controls.Add(this.m_btnRefreshPositionsAsync);
            this.m_tabPositions.Controls.Add(this.m_btnRefreshPositionsSync);
            this.m_tabPositions.Controls.Add(this.m_grdPositions);
            this.m_tabPositions.Location = new System.Drawing.Point(4, 22);
            this.m_tabPositions.Name = "m_tabPositions";
            this.m_tabPositions.Padding = new System.Windows.Forms.Padding(3);
            this.m_tabPositions.Size = new System.Drawing.Size(810, 406);
            this.m_tabPositions.TabIndex = 1;
            this.m_tabPositions.Text = "Positions";
            this.m_tabPositions.UseVisualStyleBackColor = true;
            // 
            // m_btnRefreshPositionsAsync
            // 
            this.m_btnRefreshPositionsAsync.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnRefreshPositionsAsync.Location = new System.Drawing.Point(719, 8);
            this.m_btnRefreshPositionsAsync.Name = "m_btnRefreshPositionsAsync";
            this.m_btnRefreshPositionsAsync.Size = new System.Drawing.Size(85, 23);
            this.m_btnRefreshPositionsAsync.TabIndex = 13;
            this.m_btnRefreshPositionsAsync.Text = "Refresh Async";
            this.m_btnRefreshPositionsAsync.UseVisualStyleBackColor = true;
            this.m_btnRefreshPositionsAsync.Click += new System.EventHandler(this.m_btnRefreshPositionsAsync_Click);
            // 
            // m_btnRefreshPositionsSync
            // 
            this.m_btnRefreshPositionsSync.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnRefreshPositionsSync.Location = new System.Drawing.Point(628, 8);
            this.m_btnRefreshPositionsSync.Name = "m_btnRefreshPositionsSync";
            this.m_btnRefreshPositionsSync.Size = new System.Drawing.Size(85, 23);
            this.m_btnRefreshPositionsSync.TabIndex = 12;
            this.m_btnRefreshPositionsSync.Text = "Refresh";
            this.m_btnRefreshPositionsSync.UseVisualStyleBackColor = true;
            this.m_btnRefreshPositionsSync.Click += new System.EventHandler(this.m_btnRefreshPositionsSync_Click);
            // 
            // m_grdPositions
            // 
            this.m_grdPositions.AllowUserToAddRows = false;
            this.m_grdPositions.AllowUserToDeleteRows = false;
            this.m_grdPositions.AllowUserToOrderColumns = true;
            this.m_grdPositions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_grdPositions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.m_grdPositions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_grdPositions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.m_colPositionsSymbol,
            this.m_colPositionsSymbolId,
            this.m_colPositionsOpenQty,
            this.m_colPositionsClosedQty,
            this.m_colPositionsCurrMktVal,
            this.m_colPositionsCurrPrice,
            this.m_colPositionsAvgEntryPrice,
            this.m_colPositionsClosedPnl,
            this.m_colPositionsOpenPnl,
            this.m_colPositionsTotalCost,
            this.m_colPositionsIsRealTime,
            this.m_colPositionsIsUnderReorg});
            this.m_grdPositions.Location = new System.Drawing.Point(6, 37);
            this.m_grdPositions.MultiSelect = false;
            this.m_grdPositions.Name = "m_grdPositions";
            this.m_grdPositions.ReadOnly = true;
            this.m_grdPositions.RowHeadersVisible = false;
            this.m_grdPositions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.m_grdPositions.Size = new System.Drawing.Size(798, 363);
            this.m_grdPositions.TabIndex = 11;
            // 
            // m_colPositionsSymbol
            // 
            this.m_colPositionsSymbol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colPositionsSymbol.HeaderText = "Symbol";
            this.m_colPositionsSymbol.MinimumWidth = 100;
            this.m_colPositionsSymbol.Name = "m_colPositionsSymbol";
            this.m_colPositionsSymbol.ReadOnly = true;
            // 
            // m_colPositionsSymbolId
            // 
            this.m_colPositionsSymbolId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colPositionsSymbolId.HeaderText = "Security ID";
            this.m_colPositionsSymbolId.MinimumWidth = 100;
            this.m_colPositionsSymbolId.Name = "m_colPositionsSymbolId";
            this.m_colPositionsSymbolId.ReadOnly = true;
            // 
            // m_colPositionsOpenQty
            // 
            this.m_colPositionsOpenQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colPositionsOpenQty.HeaderText = "Open qty";
            this.m_colPositionsOpenQty.MinimumWidth = 100;
            this.m_colPositionsOpenQty.Name = "m_colPositionsOpenQty";
            this.m_colPositionsOpenQty.ReadOnly = true;
            // 
            // m_colPositionsClosedQty
            // 
            this.m_colPositionsClosedQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colPositionsClosedQty.HeaderText = "Closed qty";
            this.m_colPositionsClosedQty.MinimumWidth = 100;
            this.m_colPositionsClosedQty.Name = "m_colPositionsClosedQty";
            this.m_colPositionsClosedQty.ReadOnly = true;
            // 
            // m_colPositionsCurrMktVal
            // 
            this.m_colPositionsCurrMktVal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colPositionsCurrMktVal.HeaderText = "Mkt value";
            this.m_colPositionsCurrMktVal.MinimumWidth = 100;
            this.m_colPositionsCurrMktVal.Name = "m_colPositionsCurrMktVal";
            this.m_colPositionsCurrMktVal.ReadOnly = true;
            // 
            // m_colPositionsCurrPrice
            // 
            this.m_colPositionsCurrPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colPositionsCurrPrice.HeaderText = "Price";
            this.m_colPositionsCurrPrice.MinimumWidth = 100;
            this.m_colPositionsCurrPrice.Name = "m_colPositionsCurrPrice";
            this.m_colPositionsCurrPrice.ReadOnly = true;
            // 
            // m_colPositionsAvgEntryPrice
            // 
            this.m_colPositionsAvgEntryPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colPositionsAvgEntryPrice.HeaderText = "Avg Price";
            this.m_colPositionsAvgEntryPrice.MinimumWidth = 120;
            this.m_colPositionsAvgEntryPrice.Name = "m_colPositionsAvgEntryPrice";
            this.m_colPositionsAvgEntryPrice.ReadOnly = true;
            // 
            // m_colPositionsClosedPnl
            // 
            this.m_colPositionsClosedPnl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colPositionsClosedPnl.HeaderText = "Closed P&L";
            this.m_colPositionsClosedPnl.MinimumWidth = 100;
            this.m_colPositionsClosedPnl.Name = "m_colPositionsClosedPnl";
            this.m_colPositionsClosedPnl.ReadOnly = true;
            // 
            // m_colPositionsOpenPnl
            // 
            this.m_colPositionsOpenPnl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colPositionsOpenPnl.HeaderText = "Open P&L";
            this.m_colPositionsOpenPnl.MinimumWidth = 100;
            this.m_colPositionsOpenPnl.Name = "m_colPositionsOpenPnl";
            this.m_colPositionsOpenPnl.ReadOnly = true;
            // 
            // m_colPositionsTotalCost
            // 
            this.m_colPositionsTotalCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colPositionsTotalCost.HeaderText = "Cost";
            this.m_colPositionsTotalCost.MinimumWidth = 100;
            this.m_colPositionsTotalCost.Name = "m_colPositionsTotalCost";
            this.m_colPositionsTotalCost.ReadOnly = true;
            // 
            // m_colPositionsIsRealTime
            // 
            this.m_colPositionsIsRealTime.HeaderText = "Real Time";
            this.m_colPositionsIsRealTime.MinimumWidth = 80;
            this.m_colPositionsIsRealTime.Name = "m_colPositionsIsRealTime";
            this.m_colPositionsIsRealTime.ReadOnly = true;
            this.m_colPositionsIsRealTime.Width = 80;
            // 
            // m_colPositionsIsUnderReorg
            // 
            this.m_colPositionsIsUnderReorg.HeaderText = "Under Reorg";
            this.m_colPositionsIsUnderReorg.MinimumWidth = 80;
            this.m_colPositionsIsUnderReorg.Name = "m_colPositionsIsUnderReorg";
            this.m_colPositionsIsUnderReorg.ReadOnly = true;
            this.m_colPositionsIsUnderReorg.Width = 80;
            // 
            // m_tabOrders
            // 
            this.m_tabOrders.Controls.Add(this.label21);
            this.m_tabOrders.Controls.Add(this.m_grdOrderLegs);
            this.m_tabOrders.Controls.Add(this.label15);
            this.m_tabOrders.Controls.Add(this.groupBox1);
            this.m_tabOrders.Controls.Add(this.m_lblGetOrdersRateLimitRequestsResetTime);
            this.m_tabOrders.Controls.Add(this.m_btnReplaceOrder);
            this.m_tabOrders.Controls.Add(this.label23);
            this.m_tabOrders.Controls.Add(this.m_btnCancelOrder);
            this.m_tabOrders.Controls.Add(this.m_lblGetOrdersRateLimitRemainingRequestsCount);
            this.m_tabOrders.Controls.Add(this.m_btnInsertOrder);
            this.m_tabOrders.Controls.Add(this.label25);
            this.m_tabOrders.Controls.Add(this.m_btnRefreshOrdersAsync);
            this.m_tabOrders.Controls.Add(this.m_btnRefreshOrdersSync);
            this.m_tabOrders.Controls.Add(this.m_grdOrders);
            this.m_tabOrders.Location = new System.Drawing.Point(4, 22);
            this.m_tabOrders.Name = "m_tabOrders";
            this.m_tabOrders.Padding = new System.Windows.Forms.Padding(3);
            this.m_tabOrders.Size = new System.Drawing.Size(810, 406);
            this.m_tabOrders.TabIndex = 2;
            this.m_tabOrders.Text = "Orders";
            this.m_tabOrders.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(3, 296);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(62, 13);
            this.label21.TabIndex = 50;
            this.label21.Text = "Order Legs:";
            // 
            // m_grdOrderLegs
            // 
            this.m_grdOrderLegs.AllowUserToAddRows = false;
            this.m_grdOrderLegs.AllowUserToDeleteRows = false;
            this.m_grdOrderLegs.AllowUserToOrderColumns = true;
            this.m_grdOrderLegs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_grdOrderLegs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.m_grdOrderLegs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_grdOrderLegs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.m_colOrderLegsLegId,
            this.m_colOrderLegsSymbol,
            this.m_colOrderLegsSymbolId,
            this.m_colOrderLegsLegRatioQty,
            this.m_colOrderLegsSide,
            this.m_colOrderLegsAvgExecPrice,
            this.m_colOrderLegsLastExecPrice});
            this.m_grdOrderLegs.Location = new System.Drawing.Point(3, 312);
            this.m_grdOrderLegs.MultiSelect = false;
            this.m_grdOrderLegs.Name = "m_grdOrderLegs";
            this.m_grdOrderLegs.ReadOnly = true;
            this.m_grdOrderLegs.RowHeadersVisible = false;
            this.m_grdOrderLegs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.m_grdOrderLegs.Size = new System.Drawing.Size(801, 88);
            this.m_grdOrderLegs.TabIndex = 49;
            // 
            // m_colOrderLegsLegId
            // 
            this.m_colOrderLegsLegId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colOrderLegsLegId.HeaderText = "Leg ID";
            this.m_colOrderLegsLegId.MinimumWidth = 100;
            this.m_colOrderLegsLegId.Name = "m_colOrderLegsLegId";
            this.m_colOrderLegsLegId.ReadOnly = true;
            // 
            // m_colOrderLegsSymbol
            // 
            this.m_colOrderLegsSymbol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colOrderLegsSymbol.HeaderText = "Symbol";
            this.m_colOrderLegsSymbol.MinimumWidth = 100;
            this.m_colOrderLegsSymbol.Name = "m_colOrderLegsSymbol";
            this.m_colOrderLegsSymbol.ReadOnly = true;
            // 
            // m_colOrderLegsSymbolId
            // 
            this.m_colOrderLegsSymbolId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colOrderLegsSymbolId.HeaderText = "Symbol ID";
            this.m_colOrderLegsSymbolId.MinimumWidth = 100;
            this.m_colOrderLegsSymbolId.Name = "m_colOrderLegsSymbolId";
            this.m_colOrderLegsSymbolId.ReadOnly = true;
            // 
            // m_colOrderLegsLegRatioQty
            // 
            this.m_colOrderLegsLegRatioQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colOrderLegsLegRatioQty.HeaderText = "Leg Ratio Quantity";
            this.m_colOrderLegsLegRatioQty.MinimumWidth = 130;
            this.m_colOrderLegsLegRatioQty.Name = "m_colOrderLegsLegRatioQty";
            this.m_colOrderLegsLegRatioQty.ReadOnly = true;
            // 
            // m_colOrderLegsSide
            // 
            this.m_colOrderLegsSide.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colOrderLegsSide.HeaderText = "Side";
            this.m_colOrderLegsSide.MinimumWidth = 100;
            this.m_colOrderLegsSide.Name = "m_colOrderLegsSide";
            this.m_colOrderLegsSide.ReadOnly = true;
            // 
            // m_colOrderLegsAvgExecPrice
            // 
            this.m_colOrderLegsAvgExecPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colOrderLegsAvgExecPrice.HeaderText = "Average Execution Price";
            this.m_colOrderLegsAvgExecPrice.MinimumWidth = 150;
            this.m_colOrderLegsAvgExecPrice.Name = "m_colOrderLegsAvgExecPrice";
            this.m_colOrderLegsAvgExecPrice.ReadOnly = true;
            // 
            // m_colOrderLegsLastExecPrice
            // 
            this.m_colOrderLegsLastExecPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colOrderLegsLastExecPrice.HeaderText = "Last Execution Price";
            this.m_colOrderLegsLastExecPrice.MinimumWidth = 150;
            this.m_colOrderLegsLastExecPrice.Name = "m_colOrderLegsLastExecPrice";
            this.m_colOrderLegsLastExecPrice.ReadOnly = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 102);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 48;
            this.label15.Text = "Orders:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.m_cmbStateFilter);
            this.groupBox1.Controls.Add(this.m_lblGetOrdersByDateStateFilter);
            this.groupBox1.Controls.Add(this.m_txtGetOrderByIdOrderId);
            this.groupBox1.Controls.Add(this.m_lblGetOrderByIdOrderId);
            this.groupBox1.Controls.Add(this.m_rbGetOrderByID);
            this.groupBox1.Controls.Add(this.m_rbGetOrdersByDate);
            this.groupBox1.Controls.Add(this.m_dtpGetOrdersEndTime);
            this.groupBox1.Controls.Add(this.m_lblGetOrdersByDateStartTime);
            this.groupBox1.Controls.Add(this.m_lblGetOrdersByDateEndTime);
            this.groupBox1.Controls.Add(this.m_dtpGetOrdersStartTime);
            this.groupBox1.Location = new System.Drawing.Point(9, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(698, 70);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Request Parameters";
            // 
            // m_cmbStateFilter
            // 
            this.m_cmbStateFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cmbStateFilter.FormattingEnabled = true;
            this.m_cmbStateFilter.Location = new System.Drawing.Point(135, 16);
            this.m_cmbStateFilter.Name = "m_cmbStateFilter";
            this.m_cmbStateFilter.Size = new System.Drawing.Size(83, 21);
            this.m_cmbStateFilter.TabIndex = 50;
            // 
            // m_lblGetOrdersByDateStateFilter
            // 
            this.m_lblGetOrdersByDateStateFilter.AutoSize = true;
            this.m_lblGetOrdersByDateStateFilter.Location = new System.Drawing.Point(74, 21);
            this.m_lblGetOrdersByDateStateFilter.Name = "m_lblGetOrdersByDateStateFilter";
            this.m_lblGetOrdersByDateStateFilter.Size = new System.Drawing.Size(60, 13);
            this.m_lblGetOrdersByDateStateFilter.TabIndex = 49;
            this.m_lblGetOrdersByDateStateFilter.Text = "State Filter:";
            // 
            // m_txtGetOrderByIdOrderId
            // 
            this.m_txtGetOrderByIdOrderId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_txtGetOrderByIdOrderId.Location = new System.Drawing.Point(135, 43);
            this.m_txtGetOrderByIdOrderId.Name = "m_txtGetOrderByIdOrderId";
            this.m_txtGetOrderByIdOrderId.Size = new System.Drawing.Size(554, 20);
            this.m_txtGetOrderByIdOrderId.TabIndex = 48;
            // 
            // m_lblGetOrderByIdOrderId
            // 
            this.m_lblGetOrderByIdOrderId.AutoSize = true;
            this.m_lblGetOrderByIdOrderId.Location = new System.Drawing.Point(74, 46);
            this.m_lblGetOrderByIdOrderId.Name = "m_lblGetOrderByIdOrderId";
            this.m_lblGetOrderByIdOrderId.Size = new System.Drawing.Size(55, 13);
            this.m_lblGetOrderByIdOrderId.TabIndex = 47;
            this.m_lblGetOrderByIdOrderId.Text = "Order IDs:";
            // 
            // m_rbGetOrderByID
            // 
            this.m_rbGetOrderByID.AutoSize = true;
            this.m_rbGetOrderByID.Location = new System.Drawing.Point(9, 42);
            this.m_rbGetOrderByID.Name = "m_rbGetOrderByID";
            this.m_rbGetOrderByID.Size = new System.Drawing.Size(54, 17);
            this.m_rbGetOrderByID.TabIndex = 46;
            this.m_rbGetOrderByID.Text = "By ID:";
            this.m_rbGetOrderByID.UseVisualStyleBackColor = true;
            this.m_rbGetOrderByID.CheckedChanged += new System.EventHandler(this.m_rbGetOrderByID_CheckedChanged);
            // 
            // m_rbGetOrdersByDate
            // 
            this.m_rbGetOrdersByDate.AutoSize = true;
            this.m_rbGetOrdersByDate.Checked = true;
            this.m_rbGetOrdersByDate.Location = new System.Drawing.Point(10, 19);
            this.m_rbGetOrdersByDate.Name = "m_rbGetOrdersByDate";
            this.m_rbGetOrdersByDate.Size = new System.Drawing.Size(66, 17);
            this.m_rbGetOrdersByDate.TabIndex = 0;
            this.m_rbGetOrdersByDate.TabStop = true;
            this.m_rbGetOrdersByDate.Text = "By Date:";
            this.m_rbGetOrdersByDate.UseVisualStyleBackColor = true;
            this.m_rbGetOrdersByDate.CheckedChanged += new System.EventHandler(this.m_rbGetOrdersByDate_CheckedChanged);
            // 
            // m_dtpGetOrdersEndTime
            // 
            this.m_dtpGetOrdersEndTime.CustomFormat = "MM dd yyyy HH mm ss";
            this.m_dtpGetOrdersEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dtpGetOrdersEndTime.Location = new System.Drawing.Point(522, 15);
            this.m_dtpGetOrdersEndTime.Name = "m_dtpGetOrdersEndTime";
            this.m_dtpGetOrdersEndTime.Size = new System.Drawing.Size(167, 20);
            this.m_dtpGetOrdersEndTime.TabIndex = 45;
            // 
            // m_lblGetOrdersByDateStartTime
            // 
            this.m_lblGetOrdersByDateStartTime.AutoSize = true;
            this.m_lblGetOrdersByDateStartTime.Location = new System.Drawing.Point(224, 19);
            this.m_lblGetOrdersByDateStartTime.Name = "m_lblGetOrdersByDateStartTime";
            this.m_lblGetOrdersByDateStartTime.Size = new System.Drawing.Size(58, 13);
            this.m_lblGetOrdersByDateStartTime.TabIndex = 42;
            this.m_lblGetOrdersByDateStartTime.Text = "Start Time:";
            // 
            // m_lblGetOrdersByDateEndTime
            // 
            this.m_lblGetOrdersByDateEndTime.AutoSize = true;
            this.m_lblGetOrdersByDateEndTime.Location = new System.Drawing.Point(461, 19);
            this.m_lblGetOrdersByDateEndTime.Name = "m_lblGetOrdersByDateEndTime";
            this.m_lblGetOrdersByDateEndTime.Size = new System.Drawing.Size(55, 13);
            this.m_lblGetOrdersByDateEndTime.TabIndex = 44;
            this.m_lblGetOrdersByDateEndTime.Text = "End Time:";
            // 
            // m_dtpGetOrdersStartTime
            // 
            this.m_dtpGetOrdersStartTime.CustomFormat = "MM dd yyyy HH mm ss";
            this.m_dtpGetOrdersStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dtpGetOrdersStartTime.Location = new System.Drawing.Point(288, 15);
            this.m_dtpGetOrdersStartTime.Name = "m_dtpGetOrdersStartTime";
            this.m_dtpGetOrdersStartTime.Size = new System.Drawing.Size(167, 20);
            this.m_dtpGetOrdersStartTime.TabIndex = 43;
            // 
            // m_lblGetOrdersRateLimitRequestsResetTime
            // 
            this.m_lblGetOrdersRateLimitRequestsResetTime.AutoSize = true;
            this.m_lblGetOrdersRateLimitRequestsResetTime.Location = new System.Drawing.Point(341, 6);
            this.m_lblGetOrdersRateLimitRequestsResetTime.Name = "m_lblGetOrdersRateLimitRequestsResetTime";
            this.m_lblGetOrdersRateLimitRequestsResetTime.Size = new System.Drawing.Size(0, 13);
            this.m_lblGetOrdersRateLimitRequestsResetTime.TabIndex = 41;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(223, 6);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(112, 13);
            this.label23.TabIndex = 40;
            this.label23.Text = "Requests Reset Time:";
            // 
            // m_lblGetOrdersRateLimitRemainingRequestsCount
            // 
            this.m_lblGetOrdersRateLimitRemainingRequestsCount.AutoSize = true;
            this.m_lblGetOrdersRateLimitRemainingRequestsCount.Location = new System.Drawing.Point(151, 6);
            this.m_lblGetOrdersRateLimitRemainingRequestsCount.Name = "m_lblGetOrdersRateLimitRemainingRequestsCount";
            this.m_lblGetOrdersRateLimitRemainingRequestsCount.Size = new System.Drawing.Size(0, 13);
            this.m_lblGetOrdersRateLimitRemainingRequestsCount.TabIndex = 39;
            this.m_lblGetOrdersRateLimitRemainingRequestsCount.Tag = "";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 6);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(139, 13);
            this.label25.TabIndex = 38;
            this.label25.Text = "Remaining Requests Count:";
            // 
            // m_btnRefreshOrdersAsync
            // 
            this.m_btnRefreshOrdersAsync.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnRefreshOrdersAsync.Location = new System.Drawing.Point(719, 72);
            this.m_btnRefreshOrdersAsync.Name = "m_btnRefreshOrdersAsync";
            this.m_btnRefreshOrdersAsync.Size = new System.Drawing.Size(85, 23);
            this.m_btnRefreshOrdersAsync.TabIndex = 35;
            this.m_btnRefreshOrdersAsync.Text = "Refresh Async";
            this.m_btnRefreshOrdersAsync.UseVisualStyleBackColor = true;
            this.m_btnRefreshOrdersAsync.Click += new System.EventHandler(this.m_btnRefreshOrdersAsync_Click);
            // 
            // m_btnRefreshOrdersSync
            // 
            this.m_btnRefreshOrdersSync.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnRefreshOrdersSync.Location = new System.Drawing.Point(719, 43);
            this.m_btnRefreshOrdersSync.Name = "m_btnRefreshOrdersSync";
            this.m_btnRefreshOrdersSync.Size = new System.Drawing.Size(85, 23);
            this.m_btnRefreshOrdersSync.TabIndex = 34;
            this.m_btnRefreshOrdersSync.Text = "Refresh";
            this.m_btnRefreshOrdersSync.UseVisualStyleBackColor = true;
            this.m_btnRefreshOrdersSync.Click += new System.EventHandler(this.m_btnRefreshOrdersSync_Click);
            // 
            // m_grdOrders
            // 
            this.m_grdOrders.AllowUserToAddRows = false;
            this.m_grdOrders.AllowUserToDeleteRows = false;
            this.m_grdOrders.AllowUserToOrderColumns = true;
            this.m_grdOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_grdOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.m_grdOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_grdOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.m_colOrdersId,
            this.m_colOrdersSymbol,
            this.m_colOrdersSymbolId,
            this.m_colOrdersTotalQuantity,
            this.m_colOrdersOpenQuantity,
            this.m_colOrdersFilledQuantity,
            this.m_colOrdersCanceledQuantity,
            this.m_colOrdersSide,
            this.m_colOrdersOrderType,
            this.m_colOrdersLimitPrice,
            this.m_colOrdersStopPrice,
            this.m_colOrdersIsAllOrNone,
            this.m_colOrdersIsAnon,
            this.m_colOrdersIcebergQty,
            this.m_colOrdersMinQty,
            this.m_colOrdersAvgExecPrice,
            this.m_colOrdersLastExecPrice,
            this.m_colOrdersSource,
            this.m_colOrdersTimeInForce,
            this.m_colOrdersGtdDate,
            this.m_colOrdersState,
            this.m_colOrdersRejectionReason,
            this.m_colOrdersChainId,
            this.m_colOrdersCreationTime,
            this.m_colOrdersUpdateTime,
            this.m_colOrdersNotes,
            this.m_colOrdersPrimaryRoute,
            this.m_colOrdersSecondaryRoute,
            this.m_colOrdersOrderRoute,
            this.m_colOrdersVenueHoldingOrder,
            this.m_colOrdersCommissionCharged,
            this.m_colOrdersExchangeOrderId,
            this.m_colOrdersIsSigShareHolder,
            this.m_colOrdersIsInsider,
            this.m_colOrdersIsLimitOffsetInDollar,
            this.m_colOrdersUserId,
            this.m_colOrdersPlacementCommission,
            this.m_colOrdersStrategyType,
            this.m_colOrdersTriggerStopPrice,
            this.m_colOrdersOrderGroupId,
            this.m_colOrdersOrderClass});
            this.m_grdOrders.Location = new System.Drawing.Point(6, 118);
            this.m_grdOrders.MultiSelect = false;
            this.m_grdOrders.Name = "m_grdOrders";
            this.m_grdOrders.ReadOnly = true;
            this.m_grdOrders.RowHeadersVisible = false;
            this.m_grdOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.m_grdOrders.Size = new System.Drawing.Size(798, 175);
            this.m_grdOrders.TabIndex = 33;
            this.m_grdOrders.SelectionChanged += new System.EventHandler(this.m_grdOrders_SelectionChanged);
            // 
            // m_colOrdersId
            // 
            this.m_colOrdersId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colOrdersId.HeaderText = "Order ID";
            this.m_colOrdersId.MinimumWidth = 100;
            this.m_colOrdersId.Name = "m_colOrdersId";
            this.m_colOrdersId.ReadOnly = true;
            // 
            // m_colOrdersSymbol
            // 
            this.m_colOrdersSymbol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colOrdersSymbol.HeaderText = "Symbol";
            this.m_colOrdersSymbol.MinimumWidth = 100;
            this.m_colOrdersSymbol.Name = "m_colOrdersSymbol";
            this.m_colOrdersSymbol.ReadOnly = true;
            // 
            // m_colOrdersSymbolId
            // 
            this.m_colOrdersSymbolId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colOrdersSymbolId.HeaderText = "Security ID";
            this.m_colOrdersSymbolId.MinimumWidth = 100;
            this.m_colOrdersSymbolId.Name = "m_colOrdersSymbolId";
            this.m_colOrdersSymbolId.ReadOnly = true;
            // 
            // m_colOrdersTotalQuantity
            // 
            this.m_colOrdersTotalQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colOrdersTotalQuantity.HeaderText = "Qty";
            this.m_colOrdersTotalQuantity.MinimumWidth = 100;
            this.m_colOrdersTotalQuantity.Name = "m_colOrdersTotalQuantity";
            this.m_colOrdersTotalQuantity.ReadOnly = true;
            // 
            // m_colOrdersOpenQuantity
            // 
            this.m_colOrdersOpenQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colOrdersOpenQuantity.HeaderText = "Open Qty";
            this.m_colOrdersOpenQuantity.MinimumWidth = 100;
            this.m_colOrdersOpenQuantity.Name = "m_colOrdersOpenQuantity";
            this.m_colOrdersOpenQuantity.ReadOnly = true;
            // 
            // m_colOrdersFilledQuantity
            // 
            this.m_colOrdersFilledQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colOrdersFilledQuantity.HeaderText = "Fill qty";
            this.m_colOrdersFilledQuantity.MinimumWidth = 100;
            this.m_colOrdersFilledQuantity.Name = "m_colOrdersFilledQuantity";
            this.m_colOrdersFilledQuantity.ReadOnly = true;
            // 
            // m_colOrdersCanceledQuantity
            // 
            this.m_colOrdersCanceledQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colOrdersCanceledQuantity.HeaderText = "Cancel Qty";
            this.m_colOrdersCanceledQuantity.MinimumWidth = 130;
            this.m_colOrdersCanceledQuantity.Name = "m_colOrdersCanceledQuantity";
            this.m_colOrdersCanceledQuantity.ReadOnly = true;
            // 
            // m_colOrdersSide
            // 
            this.m_colOrdersSide.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colOrdersSide.HeaderText = "Action";
            this.m_colOrdersSide.MinimumWidth = 100;
            this.m_colOrdersSide.Name = "m_colOrdersSide";
            this.m_colOrdersSide.ReadOnly = true;
            // 
            // m_colOrdersOrderType
            // 
            this.m_colOrdersOrderType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colOrdersOrderType.HeaderText = "Type";
            this.m_colOrdersOrderType.MinimumWidth = 100;
            this.m_colOrdersOrderType.Name = "m_colOrdersOrderType";
            this.m_colOrdersOrderType.ReadOnly = true;
            // 
            // m_colOrdersLimitPrice
            // 
            this.m_colOrdersLimitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colOrdersLimitPrice.HeaderText = "Limit";
            this.m_colOrdersLimitPrice.MinimumWidth = 100;
            this.m_colOrdersLimitPrice.Name = "m_colOrdersLimitPrice";
            this.m_colOrdersLimitPrice.ReadOnly = true;
            // 
            // m_colOrdersStopPrice
            // 
            this.m_colOrdersStopPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colOrdersStopPrice.HeaderText = "Stop";
            this.m_colOrdersStopPrice.MinimumWidth = 100;
            this.m_colOrdersStopPrice.Name = "m_colOrdersStopPrice";
            this.m_colOrdersStopPrice.ReadOnly = true;
            // 
            // m_colOrdersIsAllOrNone
            // 
            this.m_colOrdersIsAllOrNone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colOrdersIsAllOrNone.HeaderText = "All Or None";
            this.m_colOrdersIsAllOrNone.MinimumWidth = 100;
            this.m_colOrdersIsAllOrNone.Name = "m_colOrdersIsAllOrNone";
            this.m_colOrdersIsAllOrNone.ReadOnly = true;
            // 
            // m_colOrdersIsAnon
            // 
            this.m_colOrdersIsAnon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colOrdersIsAnon.HeaderText = "Anonymous";
            this.m_colOrdersIsAnon.MinimumWidth = 100;
            this.m_colOrdersIsAnon.Name = "m_colOrdersIsAnon";
            this.m_colOrdersIsAnon.ReadOnly = true;
            // 
            // m_colOrdersIcebergQty
            // 
            this.m_colOrdersIcebergQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colOrdersIcebergQty.HeaderText = "Iceberg Size";
            this.m_colOrdersIcebergQty.MinimumWidth = 100;
            this.m_colOrdersIcebergQty.Name = "m_colOrdersIcebergQty";
            this.m_colOrdersIcebergQty.ReadOnly = true;
            // 
            // m_colOrdersMinQty
            // 
            this.m_colOrdersMinQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colOrdersMinQty.HeaderText = "Min Size";
            this.m_colOrdersMinQty.MinimumWidth = 100;
            this.m_colOrdersMinQty.Name = "m_colOrdersMinQty";
            this.m_colOrdersMinQty.ReadOnly = true;
            // 
            // m_colOrdersAvgExecPrice
            // 
            this.m_colOrdersAvgExecPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colOrdersAvgExecPrice.HeaderText = "Average Execution Price";
            this.m_colOrdersAvgExecPrice.MinimumWidth = 160;
            this.m_colOrdersAvgExecPrice.Name = "m_colOrdersAvgExecPrice";
            this.m_colOrdersAvgExecPrice.ReadOnly = true;
            // 
            // m_colOrdersLastExecPrice
            // 
            this.m_colOrdersLastExecPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colOrdersLastExecPrice.HeaderText = "Last Execution Price";
            this.m_colOrdersLastExecPrice.MinimumWidth = 160;
            this.m_colOrdersLastExecPrice.Name = "m_colOrdersLastExecPrice";
            this.m_colOrdersLastExecPrice.ReadOnly = true;
            // 
            // m_colOrdersSource
            // 
            this.m_colOrdersSource.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colOrdersSource.HeaderText = "Source";
            this.m_colOrdersSource.MinimumWidth = 100;
            this.m_colOrdersSource.Name = "m_colOrdersSource";
            this.m_colOrdersSource.ReadOnly = true;
            // 
            // m_colOrdersTimeInForce
            // 
            this.m_colOrdersTimeInForce.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colOrdersTimeInForce.HeaderText = "Dur";
            this.m_colOrdersTimeInForce.MinimumWidth = 100;
            this.m_colOrdersTimeInForce.Name = "m_colOrdersTimeInForce";
            this.m_colOrdersTimeInForce.ReadOnly = true;
            // 
            // m_colOrdersGtdDate
            // 
            this.m_colOrdersGtdDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colOrdersGtdDate.HeaderText = "Expiration";
            this.m_colOrdersGtdDate.MinimumWidth = 100;
            this.m_colOrdersGtdDate.Name = "m_colOrdersGtdDate";
            this.m_colOrdersGtdDate.ReadOnly = true;
            // 
            // m_colOrdersState
            // 
            this.m_colOrdersState.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colOrdersState.HeaderText = "State";
            this.m_colOrdersState.MinimumWidth = 100;
            this.m_colOrdersState.Name = "m_colOrdersState";
            this.m_colOrdersState.ReadOnly = true;
            // 
            // m_colOrdersRejectionReason
            // 
            this.m_colOrdersRejectionReason.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colOrdersRejectionReason.HeaderText = "Rejection Reason";
            this.m_colOrdersRejectionReason.MinimumWidth = 130;
            this.m_colOrdersRejectionReason.Name = "m_colOrdersRejectionReason";
            this.m_colOrdersRejectionReason.ReadOnly = true;
            // 
            // m_colOrdersChainId
            // 
            this.m_colOrdersChainId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colOrdersChainId.HeaderText = "Chain ID";
            this.m_colOrdersChainId.MinimumWidth = 100;
            this.m_colOrdersChainId.Name = "m_colOrdersChainId";
            this.m_colOrdersChainId.ReadOnly = true;
            // 
            // m_colOrdersCreationTime
            // 
            this.m_colOrdersCreationTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colOrdersCreationTime.HeaderText = "Time placed";
            this.m_colOrdersCreationTime.MinimumWidth = 100;
            this.m_colOrdersCreationTime.Name = "m_colOrdersCreationTime";
            this.m_colOrdersCreationTime.ReadOnly = true;
            // 
            // m_colOrdersUpdateTime
            // 
            this.m_colOrdersUpdateTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colOrdersUpdateTime.HeaderText = "Updated time";
            this.m_colOrdersUpdateTime.MinimumWidth = 100;
            this.m_colOrdersUpdateTime.Name = "m_colOrdersUpdateTime";
            this.m_colOrdersUpdateTime.ReadOnly = true;
            // 
            // m_colOrdersNotes
            // 
            this.m_colOrdersNotes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colOrdersNotes.HeaderText = "Notes";
            this.m_colOrdersNotes.MinimumWidth = 100;
            this.m_colOrdersNotes.Name = "m_colOrdersNotes";
            this.m_colOrdersNotes.ReadOnly = true;
            // 
            // m_colOrdersPrimaryRoute
            // 
            this.m_colOrdersPrimaryRoute.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colOrdersPrimaryRoute.HeaderText = "Primary Route";
            this.m_colOrdersPrimaryRoute.MinimumWidth = 100;
            this.m_colOrdersPrimaryRoute.Name = "m_colOrdersPrimaryRoute";
            this.m_colOrdersPrimaryRoute.ReadOnly = true;
            // 
            // m_colOrdersSecondaryRoute
            // 
            this.m_colOrdersSecondaryRoute.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colOrdersSecondaryRoute.HeaderText = "Secondary Route";
            this.m_colOrdersSecondaryRoute.MinimumWidth = 130;
            this.m_colOrdersSecondaryRoute.Name = "m_colOrdersSecondaryRoute";
            this.m_colOrdersSecondaryRoute.ReadOnly = true;
            // 
            // m_colOrdersOrderRoute
            // 
            this.m_colOrdersOrderRoute.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colOrdersOrderRoute.HeaderText = "Route";
            this.m_colOrdersOrderRoute.MinimumWidth = 100;
            this.m_colOrdersOrderRoute.Name = "m_colOrdersOrderRoute";
            this.m_colOrdersOrderRoute.ReadOnly = true;
            // 
            // m_colOrdersVenueHoldingOrder
            // 
            this.m_colOrdersVenueHoldingOrder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colOrdersVenueHoldingOrder.HeaderText = "Venue";
            this.m_colOrdersVenueHoldingOrder.MinimumWidth = 160;
            this.m_colOrdersVenueHoldingOrder.Name = "m_colOrdersVenueHoldingOrder";
            this.m_colOrdersVenueHoldingOrder.ReadOnly = true;
            // 
            // m_colOrdersCommissionCharged
            // 
            this.m_colOrdersCommissionCharged.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colOrdersCommissionCharged.HeaderText = "Total fees";
            this.m_colOrdersCommissionCharged.MinimumWidth = 130;
            this.m_colOrdersCommissionCharged.Name = "m_colOrdersCommissionCharged";
            this.m_colOrdersCommissionCharged.ReadOnly = true;
            // 
            // m_colOrdersExchangeOrderId
            // 
            this.m_colOrdersExchangeOrderId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colOrdersExchangeOrderId.HeaderText = "Exch ID";
            this.m_colOrdersExchangeOrderId.MinimumWidth = 130;
            this.m_colOrdersExchangeOrderId.Name = "m_colOrdersExchangeOrderId";
            this.m_colOrdersExchangeOrderId.ReadOnly = true;
            // 
            // m_colOrdersIsSigShareHolder
            // 
            this.m_colOrdersIsSigShareHolder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colOrdersIsSigShareHolder.HeaderText = "Significant Share Holder";
            this.m_colOrdersIsSigShareHolder.MinimumWidth = 150;
            this.m_colOrdersIsSigShareHolder.Name = "m_colOrdersIsSigShareHolder";
            this.m_colOrdersIsSigShareHolder.ReadOnly = true;
            this.m_colOrdersIsSigShareHolder.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.m_colOrdersIsSigShareHolder.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // m_colOrdersIsInsider
            // 
            this.m_colOrdersIsInsider.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colOrdersIsInsider.HeaderText = "Insider";
            this.m_colOrdersIsInsider.MinimumWidth = 100;
            this.m_colOrdersIsInsider.Name = "m_colOrdersIsInsider";
            this.m_colOrdersIsInsider.ReadOnly = true;
            // 
            // m_colOrdersIsLimitOffsetInDollar
            // 
            this.m_colOrdersIsLimitOffsetInDollar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colOrdersIsLimitOffsetInDollar.HeaderText = "Limit Offset In Dollar";
            this.m_colOrdersIsLimitOffsetInDollar.MinimumWidth = 130;
            this.m_colOrdersIsLimitOffsetInDollar.Name = "m_colOrdersIsLimitOffsetInDollar";
            this.m_colOrdersIsLimitOffsetInDollar.ReadOnly = true;
            // 
            // m_colOrdersUserId
            // 
            this.m_colOrdersUserId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colOrdersUserId.HeaderText = "User ID";
            this.m_colOrdersUserId.MinimumWidth = 100;
            this.m_colOrdersUserId.Name = "m_colOrdersUserId";
            this.m_colOrdersUserId.ReadOnly = true;
            // 
            // m_colOrdersPlacementCommission
            // 
            this.m_colOrdersPlacementCommission.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colOrdersPlacementCommission.HeaderText = "Placement fee";
            this.m_colOrdersPlacementCommission.MinimumWidth = 150;
            this.m_colOrdersPlacementCommission.Name = "m_colOrdersPlacementCommission";
            this.m_colOrdersPlacementCommission.ReadOnly = true;
            // 
            // m_colOrdersStrategyType
            // 
            this.m_colOrdersStrategyType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colOrdersStrategyType.HeaderText = "Strategy type";
            this.m_colOrdersStrategyType.MinimumWidth = 100;
            this.m_colOrdersStrategyType.Name = "m_colOrdersStrategyType";
            this.m_colOrdersStrategyType.ReadOnly = true;
            // 
            // m_colOrdersTriggerStopPrice
            // 
            this.m_colOrdersTriggerStopPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colOrdersTriggerStopPrice.HeaderText = "Trigger stop";
            this.m_colOrdersTriggerStopPrice.MinimumWidth = 130;
            this.m_colOrdersTriggerStopPrice.Name = "m_colOrdersTriggerStopPrice";
            this.m_colOrdersTriggerStopPrice.ReadOnly = true;
            // 
            // m_colOrdersOrderGroupId
            // 
            this.m_colOrdersOrderGroupId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colOrdersOrderGroupId.HeaderText = "Group ID";
            this.m_colOrdersOrderGroupId.MinimumWidth = 100;
            this.m_colOrdersOrderGroupId.Name = "m_colOrdersOrderGroupId";
            this.m_colOrdersOrderGroupId.ReadOnly = true;
            // 
            // m_colOrdersOrderClass
            // 
            this.m_colOrdersOrderClass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colOrdersOrderClass.HeaderText = "Class";
            this.m_colOrdersOrderClass.MinimumWidth = 100;
            this.m_colOrdersOrderClass.Name = "m_colOrdersOrderClass";
            this.m_colOrdersOrderClass.ReadOnly = true;
            // 
            // m_tabExecutions
            // 
            this.m_tabExecutions.Controls.Add(this.m_dtpGetExecutionsEndTime);
            this.m_tabExecutions.Controls.Add(this.label19);
            this.m_tabExecutions.Controls.Add(this.m_dtpGetExecutionsStartTime);
            this.m_tabExecutions.Controls.Add(this.label17);
            this.m_tabExecutions.Controls.Add(this.m_btnRefreshExecutionsAsync);
            this.m_tabExecutions.Controls.Add(this.m_btnRefreshExecutionsSync);
            this.m_tabExecutions.Controls.Add(this.m_grdExecutions);
            this.m_tabExecutions.Location = new System.Drawing.Point(4, 22);
            this.m_tabExecutions.Name = "m_tabExecutions";
            this.m_tabExecutions.Padding = new System.Windows.Forms.Padding(3);
            this.m_tabExecutions.Size = new System.Drawing.Size(810, 406);
            this.m_tabExecutions.TabIndex = 3;
            this.m_tabExecutions.Text = "Executions";
            this.m_tabExecutions.UseVisualStyleBackColor = true;
            // 
            // m_dtpGetExecutionsEndTime
            // 
            this.m_dtpGetExecutionsEndTime.CustomFormat = "MM dd yyyy HH mm ss";
            this.m_dtpGetExecutionsEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dtpGetExecutionsEndTime.Location = new System.Drawing.Point(314, 22);
            this.m_dtpGetExecutionsEndTime.Name = "m_dtpGetExecutionsEndTime";
            this.m_dtpGetExecutionsEndTime.Size = new System.Drawing.Size(167, 20);
            this.m_dtpGetExecutionsEndTime.TabIndex = 32;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(253, 28);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(55, 13);
            this.label19.TabIndex = 31;
            this.label19.Text = "End Time:";
            // 
            // m_dtpGetExecutionsStartTime
            // 
            this.m_dtpGetExecutionsStartTime.CustomFormat = "MM dd yyyy HH mm ss";
            this.m_dtpGetExecutionsStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dtpGetExecutionsStartTime.Location = new System.Drawing.Point(70, 22);
            this.m_dtpGetExecutionsStartTime.Name = "m_dtpGetExecutionsStartTime";
            this.m_dtpGetExecutionsStartTime.Size = new System.Drawing.Size(167, 20);
            this.m_dtpGetExecutionsStartTime.TabIndex = 30;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 28);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 13);
            this.label17.TabIndex = 29;
            this.label17.Text = "Start Time:";
            // 
            // m_btnRefreshExecutionsAsync
            // 
            this.m_btnRefreshExecutionsAsync.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnRefreshExecutionsAsync.Location = new System.Drawing.Point(719, 8);
            this.m_btnRefreshExecutionsAsync.Name = "m_btnRefreshExecutionsAsync";
            this.m_btnRefreshExecutionsAsync.Size = new System.Drawing.Size(85, 23);
            this.m_btnRefreshExecutionsAsync.TabIndex = 22;
            this.m_btnRefreshExecutionsAsync.Text = "Refresh Async";
            this.m_btnRefreshExecutionsAsync.UseVisualStyleBackColor = true;
            this.m_btnRefreshExecutionsAsync.Click += new System.EventHandler(this.m_btnRefreshExecutionsAsync_Click);
            // 
            // m_btnRefreshExecutionsSync
            // 
            this.m_btnRefreshExecutionsSync.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnRefreshExecutionsSync.Location = new System.Drawing.Point(628, 8);
            this.m_btnRefreshExecutionsSync.Name = "m_btnRefreshExecutionsSync";
            this.m_btnRefreshExecutionsSync.Size = new System.Drawing.Size(85, 23);
            this.m_btnRefreshExecutionsSync.TabIndex = 21;
            this.m_btnRefreshExecutionsSync.Text = "Refresh";
            this.m_btnRefreshExecutionsSync.UseVisualStyleBackColor = true;
            this.m_btnRefreshExecutionsSync.Click += new System.EventHandler(this.m_btnRefreshExecutionsSync_Click);
            // 
            // m_grdExecutions
            // 
            this.m_grdExecutions.AllowUserToAddRows = false;
            this.m_grdExecutions.AllowUserToDeleteRows = false;
            this.m_grdExecutions.AllowUserToOrderColumns = true;
            this.m_grdExecutions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_grdExecutions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.m_grdExecutions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_grdExecutions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.m_colExecutionsSymbol,
            this.m_colExecutionsSymbolId,
            this.m_colExecutionsQty,
            this.m_colExecutionsSide,
            this.m_colExecutionsPrice,
            this.m_colExecutionsId,
            this.m_colExecutionsOrderId,
            this.m_colExecutionsOrderChainId,
            this.m_colExecutionsExchangeExecId,
            this.m_colExecutionsTimestamp,
            this.m_colExecutionsNotes,
            this.m_colExecutionsVenue,
            this.m_colExecutionsTotalCost,
            this.m_colExecutionsPlacementCommission,
            this.m_colExecutionsCommission,
            this.m_colExecutionsExecFee,
            this.m_colExecutionsSecFee,
            this.m_colExecutionsLegId,
            this.m_colExecutionsCdnExecFee,
            this.m_colExecutionsParentId});
            this.m_grdExecutions.Location = new System.Drawing.Point(9, 48);
            this.m_grdExecutions.MultiSelect = false;
            this.m_grdExecutions.Name = "m_grdExecutions";
            this.m_grdExecutions.ReadOnly = true;
            this.m_grdExecutions.RowHeadersVisible = false;
            this.m_grdExecutions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.m_grdExecutions.Size = new System.Drawing.Size(795, 352);
            this.m_grdExecutions.TabIndex = 20;
            // 
            // m_colExecutionsSymbol
            // 
            this.m_colExecutionsSymbol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colExecutionsSymbol.HeaderText = "Symbol";
            this.m_colExecutionsSymbol.MinimumWidth = 100;
            this.m_colExecutionsSymbol.Name = "m_colExecutionsSymbol";
            this.m_colExecutionsSymbol.ReadOnly = true;
            // 
            // m_colExecutionsSymbolId
            // 
            this.m_colExecutionsSymbolId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colExecutionsSymbolId.HeaderText = "Security ID";
            this.m_colExecutionsSymbolId.MinimumWidth = 100;
            this.m_colExecutionsSymbolId.Name = "m_colExecutionsSymbolId";
            this.m_colExecutionsSymbolId.ReadOnly = true;
            // 
            // m_colExecutionsQty
            // 
            this.m_colExecutionsQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colExecutionsQty.HeaderText = "Qty";
            this.m_colExecutionsQty.MinimumWidth = 100;
            this.m_colExecutionsQty.Name = "m_colExecutionsQty";
            this.m_colExecutionsQty.ReadOnly = true;
            // 
            // m_colExecutionsSide
            // 
            this.m_colExecutionsSide.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colExecutionsSide.HeaderText = "Action";
            this.m_colExecutionsSide.MinimumWidth = 100;
            this.m_colExecutionsSide.Name = "m_colExecutionsSide";
            this.m_colExecutionsSide.ReadOnly = true;
            // 
            // m_colExecutionsPrice
            // 
            this.m_colExecutionsPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colExecutionsPrice.HeaderText = "Price";
            this.m_colExecutionsPrice.MinimumWidth = 100;
            this.m_colExecutionsPrice.Name = "m_colExecutionsPrice";
            this.m_colExecutionsPrice.ReadOnly = true;
            // 
            // m_colExecutionsId
            // 
            this.m_colExecutionsId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colExecutionsId.HeaderText = "Exec ID";
            this.m_colExecutionsId.MinimumWidth = 100;
            this.m_colExecutionsId.Name = "m_colExecutionsId";
            this.m_colExecutionsId.ReadOnly = true;
            // 
            // m_colExecutionsOrderId
            // 
            this.m_colExecutionsOrderId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colExecutionsOrderId.HeaderText = "Order ID";
            this.m_colExecutionsOrderId.MinimumWidth = 100;
            this.m_colExecutionsOrderId.Name = "m_colExecutionsOrderId";
            this.m_colExecutionsOrderId.ReadOnly = true;
            // 
            // m_colExecutionsOrderChainId
            // 
            this.m_colExecutionsOrderChainId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colExecutionsOrderChainId.HeaderText = "Chain ID";
            this.m_colExecutionsOrderChainId.MinimumWidth = 100;
            this.m_colExecutionsOrderChainId.Name = "m_colExecutionsOrderChainId";
            this.m_colExecutionsOrderChainId.ReadOnly = true;
            // 
            // m_colExecutionsExchangeExecId
            // 
            this.m_colExecutionsExchangeExecId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colExecutionsExchangeExecId.HeaderText = "Exec ID (exch)";
            this.m_colExecutionsExchangeExecId.MinimumWidth = 150;
            this.m_colExecutionsExchangeExecId.Name = "m_colExecutionsExchangeExecId";
            this.m_colExecutionsExchangeExecId.ReadOnly = true;
            // 
            // m_colExecutionsTimestamp
            // 
            this.m_colExecutionsTimestamp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colExecutionsTimestamp.HeaderText = "Time placed";
            this.m_colExecutionsTimestamp.MinimumWidth = 100;
            this.m_colExecutionsTimestamp.Name = "m_colExecutionsTimestamp";
            this.m_colExecutionsTimestamp.ReadOnly = true;
            // 
            // m_colExecutionsNotes
            // 
            this.m_colExecutionsNotes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colExecutionsNotes.HeaderText = "Notes";
            this.m_colExecutionsNotes.MinimumWidth = 100;
            this.m_colExecutionsNotes.Name = "m_colExecutionsNotes";
            this.m_colExecutionsNotes.ReadOnly = true;
            // 
            // m_colExecutionsVenue
            // 
            this.m_colExecutionsVenue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colExecutionsVenue.HeaderText = "Venue (sent)";
            this.m_colExecutionsVenue.MinimumWidth = 100;
            this.m_colExecutionsVenue.Name = "m_colExecutionsVenue";
            this.m_colExecutionsVenue.ReadOnly = true;
            // 
            // m_colExecutionsTotalCost
            // 
            this.m_colExecutionsTotalCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colExecutionsTotalCost.HeaderText = "Total value";
            this.m_colExecutionsTotalCost.MinimumWidth = 100;
            this.m_colExecutionsTotalCost.Name = "m_colExecutionsTotalCost";
            this.m_colExecutionsTotalCost.ReadOnly = true;
            // 
            // m_colExecutionsPlacementCommission
            // 
            this.m_colExecutionsPlacementCommission.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colExecutionsPlacementCommission.HeaderText = "Placement fee";
            this.m_colExecutionsPlacementCommission.MinimumWidth = 150;
            this.m_colExecutionsPlacementCommission.Name = "m_colExecutionsPlacementCommission";
            this.m_colExecutionsPlacementCommission.ReadOnly = true;
            // 
            // m_colExecutionsCommission
            // 
            this.m_colExecutionsCommission.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colExecutionsCommission.HeaderText = "Fee";
            this.m_colExecutionsCommission.MinimumWidth = 100;
            this.m_colExecutionsCommission.Name = "m_colExecutionsCommission";
            this.m_colExecutionsCommission.ReadOnly = true;
            // 
            // m_colExecutionsExecFee
            // 
            this.m_colExecutionsExecFee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colExecutionsExecFee.HeaderText = "Execution fee";
            this.m_colExecutionsExecFee.MinimumWidth = 100;
            this.m_colExecutionsExecFee.Name = "m_colExecutionsExecFee";
            this.m_colExecutionsExecFee.ReadOnly = true;
            // 
            // m_colExecutionsSecFee
            // 
            this.m_colExecutionsSecFee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colExecutionsSecFee.HeaderText = "SEC fee";
            this.m_colExecutionsSecFee.MinimumWidth = 100;
            this.m_colExecutionsSecFee.Name = "m_colExecutionsSecFee";
            this.m_colExecutionsSecFee.ReadOnly = true;
            // 
            // m_colExecutionsLegId
            // 
            this.m_colExecutionsLegId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colExecutionsLegId.HeaderText = "Leg ID";
            this.m_colExecutionsLegId.MinimumWidth = 100;
            this.m_colExecutionsLegId.Name = "m_colExecutionsLegId";
            this.m_colExecutionsLegId.ReadOnly = true;
            // 
            // m_colExecutionsCdnExecFee
            // 
            this.m_colExecutionsCdnExecFee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colExecutionsCdnExecFee.HeaderText = "Canadian execution fee";
            this.m_colExecutionsCdnExecFee.MinimumWidth = 150;
            this.m_colExecutionsCdnExecFee.Name = "m_colExecutionsCdnExecFee";
            this.m_colExecutionsCdnExecFee.ReadOnly = true;
            // 
            // m_colExecutionsParentId
            // 
            this.m_colExecutionsParentId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colExecutionsParentId.HeaderText = "Parent ID";
            this.m_colExecutionsParentId.MinimumWidth = 100;
            this.m_colExecutionsParentId.Name = "m_colExecutionsParentId";
            this.m_colExecutionsParentId.ReadOnly = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.m_btnRefreshAsync);
            this.panel5.Controls.Add(this.m_lblAccountDataRateLimitRemainingRequestsCount);
            this.panel5.Controls.Add(this.m_lblGetAccountsUserId);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.m_btnRefreshAccountsSync);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.m_grdAccounts);
            this.panel5.Controls.Add(this.m_lblAccountDataRateLimitRequestsResetTime);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(818, 120);
            this.panel5.TabIndex = 11;
            // 
            // m_btnRefreshAsync
            // 
            this.m_btnRefreshAsync.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnRefreshAsync.Location = new System.Drawing.Point(723, 4);
            this.m_btnRefreshAsync.Name = "m_btnRefreshAsync";
            this.m_btnRefreshAsync.Size = new System.Drawing.Size(85, 23);
            this.m_btnRefreshAsync.TabIndex = 2;
            this.m_btnRefreshAsync.Text = "Refresh Async";
            this.m_btnRefreshAsync.UseVisualStyleBackColor = true;
            this.m_btnRefreshAsync.Click += new System.EventHandler(this.m_btnRefreshAsync_Click);
            // 
            // m_lblAccountDataRateLimitRemainingRequestsCount
            // 
            this.m_lblAccountDataRateLimitRemainingRequestsCount.AutoSize = true;
            this.m_lblAccountDataRateLimitRemainingRequestsCount.Location = new System.Drawing.Point(150, 4);
            this.m_lblAccountDataRateLimitRemainingRequestsCount.Name = "m_lblAccountDataRateLimitRemainingRequestsCount";
            this.m_lblAccountDataRateLimitRemainingRequestsCount.Size = new System.Drawing.Size(0, 13);
            this.m_lblAccountDataRateLimitRemainingRequestsCount.TabIndex = 6;
            this.m_lblAccountDataRateLimitRemainingRequestsCount.Tag = "";
            // 
            // m_lblGetAccountsUserId
            // 
            this.m_lblGetAccountsUserId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_lblGetAccountsUserId.AutoSize = true;
            this.m_lblGetAccountsUserId.Location = new System.Drawing.Point(53, 26);
            this.m_lblGetAccountsUserId.Name = "m_lblGetAccountsUserId";
            this.m_lblGetAccountsUserId.Size = new System.Drawing.Size(0, 13);
            this.m_lblGetAccountsUserId.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Remaining Requests Count:";
            // 
            // m_btnRefreshAccountsSync
            // 
            this.m_btnRefreshAccountsSync.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnRefreshAccountsSync.Location = new System.Drawing.Point(632, 4);
            this.m_btnRefreshAccountsSync.Name = "m_btnRefreshAccountsSync";
            this.m_btnRefreshAccountsSync.Size = new System.Drawing.Size(85, 23);
            this.m_btnRefreshAccountsSync.TabIndex = 1;
            this.m_btnRefreshAccountsSync.Text = "Refresh";
            this.m_btnRefreshAccountsSync.UseVisualStyleBackColor = true;
            this.m_btnRefreshAccountsSync.Click += new System.EventHandler(this.m_btnRefreshAccountsSync_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Requests Reset Time:";
            // 
            // m_grdAccounts
            // 
            this.m_grdAccounts.AllowUserToAddRows = false;
            this.m_grdAccounts.AllowUserToDeleteRows = false;
            this.m_grdAccounts.AllowUserToOrderColumns = true;
            this.m_grdAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_grdAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.m_grdAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_grdAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.m_colAccountType,
            this.m_colAccountNumber,
            this.m_colAccountStatus,
            this.m_colAccountIsPrimary,
            this.m_colAccountIsBilling,
            this.m_colAccountClientAccountType});
            this.m_grdAccounts.Location = new System.Drawing.Point(3, 42);
            this.m_grdAccounts.MultiSelect = false;
            this.m_grdAccounts.Name = "m_grdAccounts";
            this.m_grdAccounts.ReadOnly = true;
            this.m_grdAccounts.RowHeadersVisible = false;
            this.m_grdAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.m_grdAccounts.Size = new System.Drawing.Size(805, 71);
            this.m_grdAccounts.TabIndex = 0;
            this.m_grdAccounts.SelectionChanged += new System.EventHandler(this.m_grdAccounts_SelectionChanged);
            // 
            // m_colAccountType
            // 
            this.m_colAccountType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.m_colAccountType.HeaderText = "Type";
            this.m_colAccountType.Name = "m_colAccountType";
            this.m_colAccountType.ReadOnly = true;
            // 
            // m_colAccountNumber
            // 
            this.m_colAccountNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colAccountNumber.HeaderText = "Number";
            this.m_colAccountNumber.Name = "m_colAccountNumber";
            this.m_colAccountNumber.ReadOnly = true;
            // 
            // m_colAccountStatus
            // 
            this.m_colAccountStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.m_colAccountStatus.HeaderText = "Status";
            this.m_colAccountStatus.Name = "m_colAccountStatus";
            this.m_colAccountStatus.ReadOnly = true;
            // 
            // m_colAccountIsPrimary
            // 
            this.m_colAccountIsPrimary.HeaderText = "Primary";
            this.m_colAccountIsPrimary.Name = "m_colAccountIsPrimary";
            this.m_colAccountIsPrimary.ReadOnly = true;
            this.m_colAccountIsPrimary.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.m_colAccountIsPrimary.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.m_colAccountIsPrimary.Width = 66;
            // 
            // m_colAccountIsBilling
            // 
            this.m_colAccountIsBilling.HeaderText = "Billing";
            this.m_colAccountIsBilling.Name = "m_colAccountIsBilling";
            this.m_colAccountIsBilling.ReadOnly = true;
            this.m_colAccountIsBilling.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.m_colAccountIsBilling.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.m_colAccountIsBilling.Width = 59;
            // 
            // m_colAccountClientAccountType
            // 
            this.m_colAccountClientAccountType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colAccountClientAccountType.HeaderText = "Client Account Type";
            this.m_colAccountClientAccountType.Name = "m_colAccountClientAccountType";
            this.m_colAccountClientAccountType.ReadOnly = true;
            // 
            // m_lblAccountDataRateLimitRequestsResetTime
            // 
            this.m_lblAccountDataRateLimitRequestsResetTime.AutoSize = true;
            this.m_lblAccountDataRateLimitRequestsResetTime.Location = new System.Drawing.Point(379, 4);
            this.m_lblAccountDataRateLimitRequestsResetTime.Name = "m_lblAccountDataRateLimitRequestsResetTime";
            this.m_lblAccountDataRateLimitRequestsResetTime.Size = new System.Drawing.Size(0, 13);
            this.m_lblAccountDataRateLimitRequestsResetTime.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "User ID:";
            // 
            // m_tabMarketData
            // 
            this.m_tabMarketData.Controls.Add(this.panel10);
            this.m_tabMarketData.Controls.Add(this.panel9);
            this.m_tabMarketData.Location = new System.Drawing.Point(4, 22);
            this.m_tabMarketData.Name = "m_tabMarketData";
            this.m_tabMarketData.Padding = new System.Windows.Forms.Padding(3);
            this.m_tabMarketData.Size = new System.Drawing.Size(824, 558);
            this.m_tabMarketData.TabIndex = 1;
            this.m_tabMarketData.Text = "Market Data";
            this.m_tabMarketData.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.m_tabsMarketData);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(3, 32);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(818, 523);
            this.panel10.TabIndex = 14;
            // 
            // m_tabsMarketData
            // 
            this.m_tabsMarketData.Controls.Add(this.m_tabSearchSymbols);
            this.m_tabsMarketData.Controls.Add(this.m_tabGetSymbols);
            this.m_tabsMarketData.Controls.Add(this.m_tabGetQuotes);
            this.m_tabsMarketData.Controls.Add(this.m_tabGetCandles);
            this.m_tabsMarketData.Controls.Add(this.m_tabGetOptions);
            this.m_tabsMarketData.Controls.Add(this.m_tabGetMarkets);
            this.m_tabsMarketData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_tabsMarketData.Location = new System.Drawing.Point(0, 0);
            this.m_tabsMarketData.Name = "m_tabsMarketData";
            this.m_tabsMarketData.SelectedIndex = 0;
            this.m_tabsMarketData.Size = new System.Drawing.Size(818, 523);
            this.m_tabsMarketData.TabIndex = 0;
            // 
            // m_tabSearchSymbols
            // 
            this.m_tabSearchSymbols.Controls.Add(this.panel8);
            this.m_tabSearchSymbols.Controls.Add(this.panel7);
            this.m_tabSearchSymbols.Location = new System.Drawing.Point(4, 22);
            this.m_tabSearchSymbols.Name = "m_tabSearchSymbols";
            this.m_tabSearchSymbols.Padding = new System.Windows.Forms.Padding(3);
            this.m_tabSearchSymbols.Size = new System.Drawing.Size(810, 497);
            this.m_tabSearchSymbols.TabIndex = 1;
            this.m_tabSearchSymbols.Text = "Symbol Search";
            this.m_tabSearchSymbols.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.m_grdSymbolSearch);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(3, 64);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(804, 430);
            this.panel8.TabIndex = 42;
            // 
            // m_grdSymbolSearch
            // 
            this.m_grdSymbolSearch.AllowUserToAddRows = false;
            this.m_grdSymbolSearch.AllowUserToDeleteRows = false;
            this.m_grdSymbolSearch.AllowUserToOrderColumns = true;
            this.m_grdSymbolSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_grdSymbolSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.m_grdSymbolSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_grdSymbolSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.m_colSymbolSearchSymbol,
            this.m_colSymbolSearchSymbolId,
            this.m_colSymbolSearchDescription,
            this.m_colSymbolSearchSecurityType,
            this.m_colSymbolSearchIsCurrency,
            this.m_colSymbolSearchListingExchange,
            this.m_colSymbolSearchIsTradable,
            this.m_colSymbolSearchIsQuotable});
            this.m_grdSymbolSearch.Location = new System.Drawing.Point(3, 6);
            this.m_grdSymbolSearch.Name = "m_grdSymbolSearch";
            this.m_grdSymbolSearch.ReadOnly = true;
            this.m_grdSymbolSearch.RowHeadersVisible = false;
            this.m_grdSymbolSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.m_grdSymbolSearch.Size = new System.Drawing.Size(798, 421);
            this.m_grdSymbolSearch.TabIndex = 26;
            this.m_grdSymbolSearch.SelectionChanged += new System.EventHandler(this.m_grdSymbolSearch_SelectionChanged);
            // 
            // m_colSymbolSearchSymbol
            // 
            this.m_colSymbolSearchSymbol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colSymbolSearchSymbol.HeaderText = "Symbol";
            this.m_colSymbolSearchSymbol.MinimumWidth = 100;
            this.m_colSymbolSearchSymbol.Name = "m_colSymbolSearchSymbol";
            this.m_colSymbolSearchSymbol.ReadOnly = true;
            // 
            // m_colSymbolSearchSymbolId
            // 
            this.m_colSymbolSearchSymbolId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colSymbolSearchSymbolId.HeaderText = "Symbol ID";
            this.m_colSymbolSearchSymbolId.MinimumWidth = 100;
            this.m_colSymbolSearchSymbolId.Name = "m_colSymbolSearchSymbolId";
            this.m_colSymbolSearchSymbolId.ReadOnly = true;
            // 
            // m_colSymbolSearchDescription
            // 
            this.m_colSymbolSearchDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colSymbolSearchDescription.HeaderText = "Description";
            this.m_colSymbolSearchDescription.MinimumWidth = 100;
            this.m_colSymbolSearchDescription.Name = "m_colSymbolSearchDescription";
            this.m_colSymbolSearchDescription.ReadOnly = true;
            // 
            // m_colSymbolSearchSecurityType
            // 
            this.m_colSymbolSearchSecurityType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colSymbolSearchSecurityType.HeaderText = "Security Type";
            this.m_colSymbolSearchSecurityType.MinimumWidth = 100;
            this.m_colSymbolSearchSecurityType.Name = "m_colSymbolSearchSecurityType";
            this.m_colSymbolSearchSecurityType.ReadOnly = true;
            // 
            // m_colSymbolSearchIsCurrency
            // 
            this.m_colSymbolSearchIsCurrency.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colSymbolSearchIsCurrency.HeaderText = "Currency";
            this.m_colSymbolSearchIsCurrency.MinimumWidth = 100;
            this.m_colSymbolSearchIsCurrency.Name = "m_colSymbolSearchIsCurrency";
            this.m_colSymbolSearchIsCurrency.ReadOnly = true;
            // 
            // m_colSymbolSearchListingExchange
            // 
            this.m_colSymbolSearchListingExchange.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colSymbolSearchListingExchange.HeaderText = "Listing Exchange";
            this.m_colSymbolSearchListingExchange.MinimumWidth = 130;
            this.m_colSymbolSearchListingExchange.Name = "m_colSymbolSearchListingExchange";
            this.m_colSymbolSearchListingExchange.ReadOnly = true;
            // 
            // m_colSymbolSearchIsTradable
            // 
            this.m_colSymbolSearchIsTradable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colSymbolSearchIsTradable.HeaderText = "Tradable";
            this.m_colSymbolSearchIsTradable.MinimumWidth = 100;
            this.m_colSymbolSearchIsTradable.Name = "m_colSymbolSearchIsTradable";
            this.m_colSymbolSearchIsTradable.ReadOnly = true;
            // 
            // m_colSymbolSearchIsQuotable
            // 
            this.m_colSymbolSearchIsQuotable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colSymbolSearchIsQuotable.HeaderText = "Quotable";
            this.m_colSymbolSearchIsQuotable.MinimumWidth = 100;
            this.m_colSymbolSearchIsQuotable.Name = "m_colSymbolSearchIsQuotable";
            this.m_colSymbolSearchIsQuotable.ReadOnly = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.m_btnRefreshSymbolSearchAsync);
            this.panel7.Controls.Add(this.m_btnRefreshSymbolSearchSync);
            this.panel7.Controls.Add(this.m_lblSymbolSearchSelectedSymbols);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.m_txtOffset);
            this.panel7.Controls.Add(this.m_lblOffset);
            this.panel7.Controls.Add(this.m_txtPrefix);
            this.panel7.Controls.Add(this.m_lblPrefix);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(804, 61);
            this.panel7.TabIndex = 41;
            // 
            // m_btnRefreshSymbolSearchAsync
            // 
            this.m_btnRefreshSymbolSearchAsync.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnRefreshSymbolSearchAsync.Location = new System.Drawing.Point(719, 8);
            this.m_btnRefreshSymbolSearchAsync.Name = "m_btnRefreshSymbolSearchAsync";
            this.m_btnRefreshSymbolSearchAsync.Size = new System.Drawing.Size(85, 23);
            this.m_btnRefreshSymbolSearchAsync.TabIndex = 28;
            this.m_btnRefreshSymbolSearchAsync.Text = "Search Async";
            this.m_btnRefreshSymbolSearchAsync.UseVisualStyleBackColor = true;
            this.m_btnRefreshSymbolSearchAsync.Click += new System.EventHandler(this.m_btnRefreshSymbolSearchAsync_Click);
            // 
            // m_btnRefreshSymbolSearchSync
            // 
            this.m_btnRefreshSymbolSearchSync.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnRefreshSymbolSearchSync.Location = new System.Drawing.Point(628, 8);
            this.m_btnRefreshSymbolSearchSync.Name = "m_btnRefreshSymbolSearchSync";
            this.m_btnRefreshSymbolSearchSync.Size = new System.Drawing.Size(85, 23);
            this.m_btnRefreshSymbolSearchSync.TabIndex = 27;
            this.m_btnRefreshSymbolSearchSync.Text = "Search";
            this.m_btnRefreshSymbolSearchSync.UseVisualStyleBackColor = true;
            this.m_btnRefreshSymbolSearchSync.Click += new System.EventHandler(this.m_btnRefreshSymbolSearchSync_Click);
            // 
            // m_lblSymbolSearchSelectedSymbols
            // 
            this.m_lblSymbolSearchSelectedSymbols.AutoSize = true;
            this.m_lblSymbolSearchSelectedSymbols.Location = new System.Drawing.Point(103, 40);
            this.m_lblSymbolSearchSelectedSymbols.Name = "m_lblSymbolSearchSelectedSymbols";
            this.m_lblSymbolSearchSelectedSymbols.Size = new System.Drawing.Size(0, 13);
            this.m_lblSymbolSearchSelectedSymbols.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Selected Symbols:";
            // 
            // m_txtOffset
            // 
            this.m_txtOffset.Location = new System.Drawing.Point(304, 8);
            this.m_txtOffset.Name = "m_txtOffset";
            this.m_txtOffset.Size = new System.Drawing.Size(211, 20);
            this.m_txtOffset.TabIndex = 38;
            this.m_txtOffset.KeyUp += new System.Windows.Forms.KeyEventHandler(this.m_txtOffset_KeyUp);
            // 
            // m_lblOffset
            // 
            this.m_lblOffset.AutoSize = true;
            this.m_lblOffset.Location = new System.Drawing.Point(265, 13);
            this.m_lblOffset.Name = "m_lblOffset";
            this.m_lblOffset.Size = new System.Drawing.Size(38, 13);
            this.m_lblOffset.TabIndex = 37;
            this.m_lblOffset.Text = "Offset:";
            // 
            // m_txtPrefix
            // 
            this.m_txtPrefix.Location = new System.Drawing.Point(45, 8);
            this.m_txtPrefix.Name = "m_txtPrefix";
            this.m_txtPrefix.Size = new System.Drawing.Size(214, 20);
            this.m_txtPrefix.TabIndex = 36;
            this.m_txtPrefix.KeyUp += new System.Windows.Forms.KeyEventHandler(this.m_txtPrefix_KeyUp);
            // 
            // m_lblPrefix
            // 
            this.m_lblPrefix.AutoSize = true;
            this.m_lblPrefix.Location = new System.Drawing.Point(3, 13);
            this.m_lblPrefix.Name = "m_lblPrefix";
            this.m_lblPrefix.Size = new System.Drawing.Size(36, 13);
            this.m_lblPrefix.TabIndex = 35;
            this.m_lblPrefix.Text = "Prefix:";
            // 
            // m_tabGetSymbols
            // 
            this.m_tabGetSymbols.Controls.Add(this.m_txtSymbolDataSymbolIds);
            this.m_tabGetSymbols.Controls.Add(this.label1);
            this.m_tabGetSymbols.Controls.Add(this.label14);
            this.m_tabGetSymbols.Controls.Add(this.m_grdSymbolsContractDeliverables);
            this.m_tabGetSymbols.Controls.Add(this.label11);
            this.m_tabGetSymbols.Controls.Add(this.m_grdSymbolsMinTicks);
            this.m_tabGetSymbols.Controls.Add(this.label7);
            this.m_tabGetSymbols.Controls.Add(this.m_btnRefreshSymbolsAsync);
            this.m_tabGetSymbols.Controls.Add(this.m_btnRefreshSymbolsSync);
            this.m_tabGetSymbols.Controls.Add(this.m_grdSymbols);
            this.m_tabGetSymbols.Location = new System.Drawing.Point(4, 22);
            this.m_tabGetSymbols.Name = "m_tabGetSymbols";
            this.m_tabGetSymbols.Padding = new System.Windows.Forms.Padding(3);
            this.m_tabGetSymbols.Size = new System.Drawing.Size(810, 497);
            this.m_tabGetSymbols.TabIndex = 4;
            this.m_tabGetSymbols.Text = "Symbol Data";
            this.m_tabGetSymbols.UseVisualStyleBackColor = true;
            // 
            // m_txtSymbolDataSymbolIds
            // 
            this.m_txtSymbolDataSymbolIds.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_txtSymbolDataSymbolIds.Location = new System.Drawing.Point(75, 8);
            this.m_txtSymbolDataSymbolIds.Name = "m_txtSymbolDataSymbolIds";
            this.m_txtSymbolDataSymbolIds.Size = new System.Drawing.Size(547, 20);
            this.m_txtSymbolDataSymbolIds.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Symbol IDs:";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(411, 251);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 13);
            this.label14.TabIndex = 48;
            this.label14.Text = "Contract Deliverables:";
            // 
            // m_grdSymbolsContractDeliverables
            // 
            this.m_grdSymbolsContractDeliverables.AllowUserToAddRows = false;
            this.m_grdSymbolsContractDeliverables.AllowUserToDeleteRows = false;
            this.m_grdSymbolsContractDeliverables.AllowUserToOrderColumns = true;
            this.m_grdSymbolsContractDeliverables.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_grdSymbolsContractDeliverables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.m_grdSymbolsContractDeliverables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_grdSymbolsContractDeliverables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.m_colSymbolDataContractDeliverablesMultiplier,
            this.m_colSymbolDataContractDeliverablesUnderlyingSymbol,
            this.m_colSymbolDataContractDeliverablesUnderlyingSymbolId});
            this.m_grdSymbolsContractDeliverables.Location = new System.Drawing.Point(414, 267);
            this.m_grdSymbolsContractDeliverables.MultiSelect = false;
            this.m_grdSymbolsContractDeliverables.Name = "m_grdSymbolsContractDeliverables";
            this.m_grdSymbolsContractDeliverables.ReadOnly = true;
            this.m_grdSymbolsContractDeliverables.RowHeadersVisible = false;
            this.m_grdSymbolsContractDeliverables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.m_grdSymbolsContractDeliverables.Size = new System.Drawing.Size(390, 224);
            this.m_grdSymbolsContractDeliverables.TabIndex = 47;
            // 
            // m_colSymbolDataContractDeliverablesMultiplier
            // 
            this.m_colSymbolDataContractDeliverablesMultiplier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colSymbolDataContractDeliverablesMultiplier.HeaderText = "Multiplier";
            this.m_colSymbolDataContractDeliverablesMultiplier.MinimumWidth = 100;
            this.m_colSymbolDataContractDeliverablesMultiplier.Name = "m_colSymbolDataContractDeliverablesMultiplier";
            this.m_colSymbolDataContractDeliverablesMultiplier.ReadOnly = true;
            // 
            // m_colSymbolDataContractDeliverablesUnderlyingSymbol
            // 
            this.m_colSymbolDataContractDeliverablesUnderlyingSymbol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colSymbolDataContractDeliverablesUnderlyingSymbol.HeaderText = "Symbol";
            this.m_colSymbolDataContractDeliverablesUnderlyingSymbol.MinimumWidth = 100;
            this.m_colSymbolDataContractDeliverablesUnderlyingSymbol.Name = "m_colSymbolDataContractDeliverablesUnderlyingSymbol";
            this.m_colSymbolDataContractDeliverablesUnderlyingSymbol.ReadOnly = true;
            // 
            // m_colSymbolDataContractDeliverablesUnderlyingSymbolId
            // 
            this.m_colSymbolDataContractDeliverablesUnderlyingSymbolId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colSymbolDataContractDeliverablesUnderlyingSymbolId.HeaderText = "Security ID";
            this.m_colSymbolDataContractDeliverablesUnderlyingSymbolId.MinimumWidth = 100;
            this.m_colSymbolDataContractDeliverablesUnderlyingSymbolId.Name = "m_colSymbolDataContractDeliverablesUnderlyingSymbolId";
            this.m_colSymbolDataContractDeliverablesUnderlyingSymbolId.ReadOnly = true;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 251);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 46;
            this.label11.Text = "Min Ticks:";
            // 
            // m_grdSymbolsMinTicks
            // 
            this.m_grdSymbolsMinTicks.AllowUserToAddRows = false;
            this.m_grdSymbolsMinTicks.AllowUserToDeleteRows = false;
            this.m_grdSymbolsMinTicks.AllowUserToOrderColumns = true;
            this.m_grdSymbolsMinTicks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_grdSymbolsMinTicks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.m_grdSymbolsMinTicks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_grdSymbolsMinTicks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.m_colSymbolDataMinTicksPivot,
            this.m_colSymbolDataMinTicksMinTick});
            this.m_grdSymbolsMinTicks.Location = new System.Drawing.Point(9, 267);
            this.m_grdSymbolsMinTicks.MultiSelect = false;
            this.m_grdSymbolsMinTicks.Name = "m_grdSymbolsMinTicks";
            this.m_grdSymbolsMinTicks.ReadOnly = true;
            this.m_grdSymbolsMinTicks.RowHeadersVisible = false;
            this.m_grdSymbolsMinTicks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.m_grdSymbolsMinTicks.Size = new System.Drawing.Size(390, 224);
            this.m_grdSymbolsMinTicks.TabIndex = 45;
            // 
            // m_colSymbolDataMinTicksPivot
            // 
            this.m_colSymbolDataMinTicksPivot.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colSymbolDataMinTicksPivot.HeaderText = "Pivot";
            this.m_colSymbolDataMinTicksPivot.MinimumWidth = 100;
            this.m_colSymbolDataMinTicksPivot.Name = "m_colSymbolDataMinTicksPivot";
            this.m_colSymbolDataMinTicksPivot.ReadOnly = true;
            // 
            // m_colSymbolDataMinTicksMinTick
            // 
            this.m_colSymbolDataMinTicksMinTick.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colSymbolDataMinTicksMinTick.HeaderText = "Min Tick";
            this.m_colSymbolDataMinTicksMinTick.MinimumWidth = 100;
            this.m_colSymbolDataMinTicksMinTick.Name = "m_colSymbolDataMinTicksMinTick";
            this.m_colSymbolDataMinTicksMinTick.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Symbol Data:";
            // 
            // m_btnRefreshSymbolsAsync
            // 
            this.m_btnRefreshSymbolsAsync.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnRefreshSymbolsAsync.Location = new System.Drawing.Point(719, 8);
            this.m_btnRefreshSymbolsAsync.Name = "m_btnRefreshSymbolsAsync";
            this.m_btnRefreshSymbolsAsync.Size = new System.Drawing.Size(85, 23);
            this.m_btnRefreshSymbolsAsync.TabIndex = 37;
            this.m_btnRefreshSymbolsAsync.Text = "Refresh Async";
            this.m_btnRefreshSymbolsAsync.UseVisualStyleBackColor = true;
            this.m_btnRefreshSymbolsAsync.Click += new System.EventHandler(this.m_btnRefreshSymbolsAsync_Click);
            // 
            // m_btnRefreshSymbolsSync
            // 
            this.m_btnRefreshSymbolsSync.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnRefreshSymbolsSync.Location = new System.Drawing.Point(628, 8);
            this.m_btnRefreshSymbolsSync.Name = "m_btnRefreshSymbolsSync";
            this.m_btnRefreshSymbolsSync.Size = new System.Drawing.Size(85, 23);
            this.m_btnRefreshSymbolsSync.TabIndex = 36;
            this.m_btnRefreshSymbolsSync.Text = "Refresh";
            this.m_btnRefreshSymbolsSync.UseVisualStyleBackColor = true;
            this.m_btnRefreshSymbolsSync.Click += new System.EventHandler(this.m_btnRefreshSymbolsSync_Click);
            // 
            // m_grdSymbols
            // 
            this.m_grdSymbols.AllowUserToAddRows = false;
            this.m_grdSymbols.AllowUserToDeleteRows = false;
            this.m_grdSymbols.AllowUserToOrderColumns = true;
            this.m_grdSymbols.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_grdSymbols.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.m_grdSymbols.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_grdSymbols.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.m_colSymbolsSymbol,
            this.m_colSymbolsSymbolId,
            this.m_colSymbolsPrevDayClosePrice,
            this.m_colSymbolsHighPrice52,
            this.m_colSymbolsLowPrice52,
            this.m_colSymbolsAverageVol3Months,
            this.m_colSymbolsAverageVol20Days,
            this.m_colSymbolsOutstandingShares,
            this.m_colSymbolsEps,
            this.m_colSymbolsPe,
            this.m_colSymbolsDividend,
            this.m_colSymbolsYield,
            this.m_colSymbolsExDate,
            this.m_colSymbolsMarketCap,
            this.m_colSymbolsTradeUnit,
            this.m_colSymbolsOptionType,
            this.m_colSymbolsOptionDurationType,
            this.m_colSymbolsOptionRoot,
            this.m_colSymbolsOptionExerciseType,
            this.m_colSymbolsListingExchange,
            this.m_colSymbolsDescription,
            this.m_colSymbolsSecurityType,
            this.m_colSymbolsOptionExpiryDate,
            this.m_colSymbolsDividendDate,
            this.m_colSymbolsOptionStrikePrice,
            this.m_colSymbolsIsTradable,
            this.m_colSymbolsIsQuotable,
            this.m_colSymbolsHasOptions,
            this.m_colSymbolsCurrency,
            this.m_colSymbolsContractDeliverablesCashInLieu});
            this.m_grdSymbols.Location = new System.Drawing.Point(9, 51);
            this.m_grdSymbols.MultiSelect = false;
            this.m_grdSymbols.Name = "m_grdSymbols";
            this.m_grdSymbols.ReadOnly = true;
            this.m_grdSymbols.RowHeadersVisible = false;
            this.m_grdSymbols.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.m_grdSymbols.Size = new System.Drawing.Size(795, 197);
            this.m_grdSymbols.TabIndex = 35;
            this.m_grdSymbols.SelectionChanged += new System.EventHandler(this.m_grdSymbols_SelectionChanged);
            // 
            // m_colSymbolsSymbol
            // 
            this.m_colSymbolsSymbol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colSymbolsSymbol.HeaderText = "Symbol";
            this.m_colSymbolsSymbol.MinimumWidth = 100;
            this.m_colSymbolsSymbol.Name = "m_colSymbolsSymbol";
            this.m_colSymbolsSymbol.ReadOnly = true;
            // 
            // m_colSymbolsSymbolId
            // 
            this.m_colSymbolsSymbolId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colSymbolsSymbolId.HeaderText = "Symbol ID";
            this.m_colSymbolsSymbolId.MinimumWidth = 100;
            this.m_colSymbolsSymbolId.Name = "m_colSymbolsSymbolId";
            this.m_colSymbolsSymbolId.ReadOnly = true;
            // 
            // m_colSymbolsPrevDayClosePrice
            // 
            this.m_colSymbolsPrevDayClosePrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colSymbolsPrevDayClosePrice.HeaderText = "Previous Day Close Price";
            this.m_colSymbolsPrevDayClosePrice.MinimumWidth = 180;
            this.m_colSymbolsPrevDayClosePrice.Name = "m_colSymbolsPrevDayClosePrice";
            this.m_colSymbolsPrevDayClosePrice.ReadOnly = true;
            // 
            // m_colSymbolsHighPrice52
            // 
            this.m_colSymbolsHighPrice52.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colSymbolsHighPrice52.HeaderText = "52-Week High Price";
            this.m_colSymbolsHighPrice52.MinimumWidth = 170;
            this.m_colSymbolsHighPrice52.Name = "m_colSymbolsHighPrice52";
            this.m_colSymbolsHighPrice52.ReadOnly = true;
            // 
            // m_colSymbolsLowPrice52
            // 
            this.m_colSymbolsLowPrice52.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colSymbolsLowPrice52.HeaderText = "52-Week Low Price";
            this.m_colSymbolsLowPrice52.MinimumWidth = 170;
            this.m_colSymbolsLowPrice52.Name = "m_colSymbolsLowPrice52";
            this.m_colSymbolsLowPrice52.ReadOnly = true;
            // 
            // m_colSymbolsAverageVol3Months
            // 
            this.m_colSymbolsAverageVol3Months.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colSymbolsAverageVol3Months.HeaderText = "3-Months Average Volume";
            this.m_colSymbolsAverageVol3Months.MinimumWidth = 200;
            this.m_colSymbolsAverageVol3Months.Name = "m_colSymbolsAverageVol3Months";
            this.m_colSymbolsAverageVol3Months.ReadOnly = true;
            // 
            // m_colSymbolsAverageVol20Days
            // 
            this.m_colSymbolsAverageVol20Days.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colSymbolsAverageVol20Days.HeaderText = "20-Day Average Volume";
            this.m_colSymbolsAverageVol20Days.MinimumWidth = 200;
            this.m_colSymbolsAverageVol20Days.Name = "m_colSymbolsAverageVol20Days";
            this.m_colSymbolsAverageVol20Days.ReadOnly = true;
            // 
            // m_colSymbolsOutstandingShares
            // 
            this.m_colSymbolsOutstandingShares.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colSymbolsOutstandingShares.HeaderText = "Outstanding Shares";
            this.m_colSymbolsOutstandingShares.MinimumWidth = 180;
            this.m_colSymbolsOutstandingShares.Name = "m_colSymbolsOutstandingShares";
            this.m_colSymbolsOutstandingShares.ReadOnly = true;
            // 
            // m_colSymbolsEps
            // 
            this.m_colSymbolsEps.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colSymbolsEps.HeaderText = "EPS";
            this.m_colSymbolsEps.MinimumWidth = 100;
            this.m_colSymbolsEps.Name = "m_colSymbolsEps";
            this.m_colSymbolsEps.ReadOnly = true;
            // 
            // m_colSymbolsPe
            // 
            this.m_colSymbolsPe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colSymbolsPe.HeaderText = "PE";
            this.m_colSymbolsPe.MinimumWidth = 100;
            this.m_colSymbolsPe.Name = "m_colSymbolsPe";
            this.m_colSymbolsPe.ReadOnly = true;
            // 
            // m_colSymbolsDividend
            // 
            this.m_colSymbolsDividend.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colSymbolsDividend.HeaderText = "Dividend";
            this.m_colSymbolsDividend.MinimumWidth = 100;
            this.m_colSymbolsDividend.Name = "m_colSymbolsDividend";
            this.m_colSymbolsDividend.ReadOnly = true;
            // 
            // m_colSymbolsYield
            // 
            this.m_colSymbolsYield.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colSymbolsYield.HeaderText = "Yield";
            this.m_colSymbolsYield.MinimumWidth = 100;
            this.m_colSymbolsYield.Name = "m_colSymbolsYield";
            this.m_colSymbolsYield.ReadOnly = true;
            // 
            // m_colSymbolsExDate
            // 
            this.m_colSymbolsExDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colSymbolsExDate.HeaderText = "Expiration Date";
            this.m_colSymbolsExDate.MinimumWidth = 150;
            this.m_colSymbolsExDate.Name = "m_colSymbolsExDate";
            this.m_colSymbolsExDate.ReadOnly = true;
            // 
            // m_colSymbolsMarketCap
            // 
            this.m_colSymbolsMarketCap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colSymbolsMarketCap.HeaderText = "Market Capitalization";
            this.m_colSymbolsMarketCap.MinimumWidth = 180;
            this.m_colSymbolsMarketCap.Name = "m_colSymbolsMarketCap";
            this.m_colSymbolsMarketCap.ReadOnly = true;
            // 
            // m_colSymbolsTradeUnit
            // 
            this.m_colSymbolsTradeUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colSymbolsTradeUnit.HeaderText = "Trade Unit";
            this.m_colSymbolsTradeUnit.MinimumWidth = 100;
            this.m_colSymbolsTradeUnit.Name = "m_colSymbolsTradeUnit";
            this.m_colSymbolsTradeUnit.ReadOnly = true;
            // 
            // m_colSymbolsOptionType
            // 
            this.m_colSymbolsOptionType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colSymbolsOptionType.HeaderText = "Option Type";
            this.m_colSymbolsOptionType.MinimumWidth = 100;
            this.m_colSymbolsOptionType.Name = "m_colSymbolsOptionType";
            this.m_colSymbolsOptionType.ReadOnly = true;
            // 
            // m_colSymbolsOptionDurationType
            // 
            this.m_colSymbolsOptionDurationType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colSymbolsOptionDurationType.HeaderText = "Option Duration Type";
            this.m_colSymbolsOptionDurationType.MinimumWidth = 200;
            this.m_colSymbolsOptionDurationType.Name = "m_colSymbolsOptionDurationType";
            this.m_colSymbolsOptionDurationType.ReadOnly = true;
            // 
            // m_colSymbolsOptionRoot
            // 
            this.m_colSymbolsOptionRoot.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colSymbolsOptionRoot.HeaderText = "Option Root";
            this.m_colSymbolsOptionRoot.MinimumWidth = 100;
            this.m_colSymbolsOptionRoot.Name = "m_colSymbolsOptionRoot";
            this.m_colSymbolsOptionRoot.ReadOnly = true;
            // 
            // m_colSymbolsOptionExerciseType
            // 
            this.m_colSymbolsOptionExerciseType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colSymbolsOptionExerciseType.HeaderText = "Option Exercise Type";
            this.m_colSymbolsOptionExerciseType.MinimumWidth = 180;
            this.m_colSymbolsOptionExerciseType.Name = "m_colSymbolsOptionExerciseType";
            this.m_colSymbolsOptionExerciseType.ReadOnly = true;
            // 
            // m_colSymbolsListingExchange
            // 
            this.m_colSymbolsListingExchange.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colSymbolsListingExchange.HeaderText = "Listing Exchange";
            this.m_colSymbolsListingExchange.MinimumWidth = 160;
            this.m_colSymbolsListingExchange.Name = "m_colSymbolsListingExchange";
            this.m_colSymbolsListingExchange.ReadOnly = true;
            // 
            // m_colSymbolsDescription
            // 
            this.m_colSymbolsDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colSymbolsDescription.HeaderText = "Description";
            this.m_colSymbolsDescription.MinimumWidth = 100;
            this.m_colSymbolsDescription.Name = "m_colSymbolsDescription";
            this.m_colSymbolsDescription.ReadOnly = true;
            // 
            // m_colSymbolsSecurityType
            // 
            this.m_colSymbolsSecurityType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colSymbolsSecurityType.HeaderText = "Security Type";
            this.m_colSymbolsSecurityType.MinimumWidth = 100;
            this.m_colSymbolsSecurityType.Name = "m_colSymbolsSecurityType";
            this.m_colSymbolsSecurityType.ReadOnly = true;
            // 
            // m_colSymbolsOptionExpiryDate
            // 
            this.m_colSymbolsOptionExpiryDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colSymbolsOptionExpiryDate.HeaderText = "Option Expiry Date";
            this.m_colSymbolsOptionExpiryDate.MinimumWidth = 180;
            this.m_colSymbolsOptionExpiryDate.Name = "m_colSymbolsOptionExpiryDate";
            this.m_colSymbolsOptionExpiryDate.ReadOnly = true;
            // 
            // m_colSymbolsDividendDate
            // 
            this.m_colSymbolsDividendDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colSymbolsDividendDate.HeaderText = "Dividend Date";
            this.m_colSymbolsDividendDate.MinimumWidth = 160;
            this.m_colSymbolsDividendDate.Name = "m_colSymbolsDividendDate";
            this.m_colSymbolsDividendDate.ReadOnly = true;
            // 
            // m_colSymbolsOptionStrikePrice
            // 
            this.m_colSymbolsOptionStrikePrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colSymbolsOptionStrikePrice.HeaderText = "Option Strike Price";
            this.m_colSymbolsOptionStrikePrice.MinimumWidth = 180;
            this.m_colSymbolsOptionStrikePrice.Name = "m_colSymbolsOptionStrikePrice";
            this.m_colSymbolsOptionStrikePrice.ReadOnly = true;
            // 
            // m_colSymbolsIsTradable
            // 
            this.m_colSymbolsIsTradable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colSymbolsIsTradable.HeaderText = "Tradable";
            this.m_colSymbolsIsTradable.MinimumWidth = 100;
            this.m_colSymbolsIsTradable.Name = "m_colSymbolsIsTradable";
            this.m_colSymbolsIsTradable.ReadOnly = true;
            // 
            // m_colSymbolsIsQuotable
            // 
            this.m_colSymbolsIsQuotable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colSymbolsIsQuotable.HeaderText = "Quotable";
            this.m_colSymbolsIsQuotable.MinimumWidth = 100;
            this.m_colSymbolsIsQuotable.Name = "m_colSymbolsIsQuotable";
            this.m_colSymbolsIsQuotable.ReadOnly = true;
            // 
            // m_colSymbolsHasOptions
            // 
            this.m_colSymbolsHasOptions.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colSymbolsHasOptions.HeaderText = "Has Options";
            this.m_colSymbolsHasOptions.MinimumWidth = 100;
            this.m_colSymbolsHasOptions.Name = "m_colSymbolsHasOptions";
            this.m_colSymbolsHasOptions.ReadOnly = true;
            // 
            // m_colSymbolsCurrency
            // 
            this.m_colSymbolsCurrency.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colSymbolsCurrency.HeaderText = "Currency";
            this.m_colSymbolsCurrency.MinimumWidth = 100;
            this.m_colSymbolsCurrency.Name = "m_colSymbolsCurrency";
            this.m_colSymbolsCurrency.ReadOnly = true;
            // 
            // m_colSymbolsContractDeliverablesCashInLieu
            // 
            this.m_colSymbolsContractDeliverablesCashInLieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colSymbolsContractDeliverablesCashInLieu.HeaderText = "Cash In Lieu";
            this.m_colSymbolsContractDeliverablesCashInLieu.MinimumWidth = 100;
            this.m_colSymbolsContractDeliverablesCashInLieu.Name = "m_colSymbolsContractDeliverablesCashInLieu";
            this.m_colSymbolsContractDeliverablesCashInLieu.ReadOnly = true;
            // 
            // m_tabGetQuotes
            // 
            this.m_tabGetQuotes.Controls.Add(this.m_txtQuotesSymbolIds);
            this.m_tabGetQuotes.Controls.Add(this.label9);
            this.m_tabGetQuotes.Controls.Add(this.m_btnRefreshQuotesAsync);
            this.m_tabGetQuotes.Controls.Add(this.m_btnRefreshQuotesSync);
            this.m_tabGetQuotes.Controls.Add(this.m_grdQuotes);
            this.m_tabGetQuotes.Location = new System.Drawing.Point(4, 22);
            this.m_tabGetQuotes.Name = "m_tabGetQuotes";
            this.m_tabGetQuotes.Padding = new System.Windows.Forms.Padding(3);
            this.m_tabGetQuotes.Size = new System.Drawing.Size(810, 497);
            this.m_tabGetQuotes.TabIndex = 0;
            this.m_tabGetQuotes.Text = "Quotes";
            this.m_tabGetQuotes.UseVisualStyleBackColor = true;
            // 
            // m_txtQuotesSymbolIds
            // 
            this.m_txtQuotesSymbolIds.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_txtQuotesSymbolIds.Location = new System.Drawing.Point(75, 8);
            this.m_txtQuotesSymbolIds.Name = "m_txtQuotesSymbolIds";
            this.m_txtQuotesSymbolIds.Size = new System.Drawing.Size(547, 20);
            this.m_txtQuotesSymbolIds.TabIndex = 52;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 51;
            this.label9.Text = "Symbol IDs:";
            // 
            // m_btnRefreshQuotesAsync
            // 
            this.m_btnRefreshQuotesAsync.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnRefreshQuotesAsync.Location = new System.Drawing.Point(719, 8);
            this.m_btnRefreshQuotesAsync.Name = "m_btnRefreshQuotesAsync";
            this.m_btnRefreshQuotesAsync.Size = new System.Drawing.Size(85, 23);
            this.m_btnRefreshQuotesAsync.TabIndex = 28;
            this.m_btnRefreshQuotesAsync.Text = "Refresh Async";
            this.m_btnRefreshQuotesAsync.UseVisualStyleBackColor = true;
            this.m_btnRefreshQuotesAsync.Click += new System.EventHandler(this.m_btnRefreshQuotesAsync_Click);
            // 
            // m_btnRefreshQuotesSync
            // 
            this.m_btnRefreshQuotesSync.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnRefreshQuotesSync.Location = new System.Drawing.Point(628, 8);
            this.m_btnRefreshQuotesSync.Name = "m_btnRefreshQuotesSync";
            this.m_btnRefreshQuotesSync.Size = new System.Drawing.Size(85, 23);
            this.m_btnRefreshQuotesSync.TabIndex = 27;
            this.m_btnRefreshQuotesSync.Text = "Refresh";
            this.m_btnRefreshQuotesSync.UseVisualStyleBackColor = true;
            this.m_btnRefreshQuotesSync.Click += new System.EventHandler(this.m_btnRefreshQuotesSync_Click);
            // 
            // m_grdQuotes
            // 
            this.m_grdQuotes.AllowUserToAddRows = false;
            this.m_grdQuotes.AllowUserToDeleteRows = false;
            this.m_grdQuotes.AllowUserToOrderColumns = true;
            this.m_grdQuotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_grdQuotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.m_grdQuotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_grdQuotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.m_colQuotesSymbol,
            this.m_colQuotesSymbolId,
            this.m_colQuotesBidPrice,
            this.m_colQuotesBidSize,
            this.m_colQuotesAskPrice,
            this.m_colQuotesAskSize,
            this.m_colQuotesLastTradePriceTrHrs,
            this.m_colQuotesLastTradePrice,
            this.m_colQuotesLastTradeSize,
            this.m_colQuotesLastTradeTick,
            this.m_colQuotesLastTradeTime,
            this.m_colQuotesVolume,
            this.m_colQuotesOpenPrice,
            this.m_colQuotesHighPrice,
            this.m_colQuotesLowPrice,
            this.m_colQuotesDelay,
            this.m_colQuotesIsHalted});
            this.m_grdQuotes.Location = new System.Drawing.Point(5, 37);
            this.m_grdQuotes.MultiSelect = false;
            this.m_grdQuotes.Name = "m_grdQuotes";
            this.m_grdQuotes.ReadOnly = true;
            this.m_grdQuotes.RowHeadersVisible = false;
            this.m_grdQuotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.m_grdQuotes.Size = new System.Drawing.Size(799, 454);
            this.m_grdQuotes.TabIndex = 26;
            // 
            // m_colQuotesSymbol
            // 
            this.m_colQuotesSymbol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colQuotesSymbol.HeaderText = "Symbol";
            this.m_colQuotesSymbol.MinimumWidth = 100;
            this.m_colQuotesSymbol.Name = "m_colQuotesSymbol";
            this.m_colQuotesSymbol.ReadOnly = true;
            // 
            // m_colQuotesSymbolId
            // 
            this.m_colQuotesSymbolId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colQuotesSymbolId.HeaderText = "Security ID";
            this.m_colQuotesSymbolId.MinimumWidth = 100;
            this.m_colQuotesSymbolId.Name = "m_colQuotesSymbolId";
            this.m_colQuotesSymbolId.ReadOnly = true;
            // 
            // m_colQuotesBidPrice
            // 
            this.m_colQuotesBidPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colQuotesBidPrice.HeaderText = "Bid";
            this.m_colQuotesBidPrice.MinimumWidth = 100;
            this.m_colQuotesBidPrice.Name = "m_colQuotesBidPrice";
            this.m_colQuotesBidPrice.ReadOnly = true;
            // 
            // m_colQuotesBidSize
            // 
            this.m_colQuotesBidSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colQuotesBidSize.HeaderText = "Bid sz";
            this.m_colQuotesBidSize.MinimumWidth = 100;
            this.m_colQuotesBidSize.Name = "m_colQuotesBidSize";
            this.m_colQuotesBidSize.ReadOnly = true;
            // 
            // m_colQuotesAskPrice
            // 
            this.m_colQuotesAskPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colQuotesAskPrice.HeaderText = "Ask";
            this.m_colQuotesAskPrice.MinimumWidth = 100;
            this.m_colQuotesAskPrice.Name = "m_colQuotesAskPrice";
            this.m_colQuotesAskPrice.ReadOnly = true;
            // 
            // m_colQuotesAskSize
            // 
            this.m_colQuotesAskSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colQuotesAskSize.HeaderText = "Ask sz";
            this.m_colQuotesAskSize.MinimumWidth = 100;
            this.m_colQuotesAskSize.Name = "m_colQuotesAskSize";
            this.m_colQuotesAskSize.ReadOnly = true;
            // 
            // m_colQuotesLastTradePriceTrHrs
            // 
            this.m_colQuotesLastTradePriceTrHrs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colQuotesLastTradePriceTrHrs.HeaderText = "Last trade trading hours";
            this.m_colQuotesLastTradePriceTrHrs.MinimumWidth = 200;
            this.m_colQuotesLastTradePriceTrHrs.Name = "m_colQuotesLastTradePriceTrHrs";
            this.m_colQuotesLastTradePriceTrHrs.ReadOnly = true;
            // 
            // m_colQuotesLastTradePrice
            // 
            this.m_colQuotesLastTradePrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colQuotesLastTradePrice.HeaderText = "Last trade";
            this.m_colQuotesLastTradePrice.MinimumWidth = 130;
            this.m_colQuotesLastTradePrice.Name = "m_colQuotesLastTradePrice";
            this.m_colQuotesLastTradePrice.ReadOnly = true;
            // 
            // m_colQuotesLastTradeSize
            // 
            this.m_colQuotesLastTradeSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colQuotesLastTradeSize.HeaderText = "Last trade sz";
            this.m_colQuotesLastTradeSize.MinimumWidth = 130;
            this.m_colQuotesLastTradeSize.Name = "m_colQuotesLastTradeSize";
            this.m_colQuotesLastTradeSize.ReadOnly = true;
            // 
            // m_colQuotesLastTradeTick
            // 
            this.m_colQuotesLastTradeTick.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colQuotesLastTradeTick.HeaderText = "Tick";
            this.m_colQuotesLastTradeTick.MinimumWidth = 130;
            this.m_colQuotesLastTradeTick.Name = "m_colQuotesLastTradeTick";
            this.m_colQuotesLastTradeTick.ReadOnly = true;
            // 
            // m_colQuotesLastTradeTime
            // 
            this.m_colQuotesLastTradeTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colQuotesLastTradeTime.HeaderText = "Last trade time";
            this.m_colQuotesLastTradeTime.MinimumWidth = 130;
            this.m_colQuotesLastTradeTime.Name = "m_colQuotesLastTradeTime";
            this.m_colQuotesLastTradeTime.ReadOnly = true;
            // 
            // m_colQuotesVolume
            // 
            this.m_colQuotesVolume.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colQuotesVolume.HeaderText = "Vol";
            this.m_colQuotesVolume.MinimumWidth = 100;
            this.m_colQuotesVolume.Name = "m_colQuotesVolume";
            this.m_colQuotesVolume.ReadOnly = true;
            // 
            // m_colQuotesOpenPrice
            // 
            this.m_colQuotesOpenPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colQuotesOpenPrice.HeaderText = "Open";
            this.m_colQuotesOpenPrice.MinimumWidth = 100;
            this.m_colQuotesOpenPrice.Name = "m_colQuotesOpenPrice";
            this.m_colQuotesOpenPrice.ReadOnly = true;
            // 
            // m_colQuotesHighPrice
            // 
            this.m_colQuotesHighPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colQuotesHighPrice.HeaderText = "High";
            this.m_colQuotesHighPrice.MinimumWidth = 100;
            this.m_colQuotesHighPrice.Name = "m_colQuotesHighPrice";
            this.m_colQuotesHighPrice.ReadOnly = true;
            // 
            // m_colQuotesLowPrice
            // 
            this.m_colQuotesLowPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colQuotesLowPrice.HeaderText = "Low";
            this.m_colQuotesLowPrice.MinimumWidth = 100;
            this.m_colQuotesLowPrice.Name = "m_colQuotesLowPrice";
            this.m_colQuotesLowPrice.ReadOnly = true;
            // 
            // m_colQuotesDelay
            // 
            this.m_colQuotesDelay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colQuotesDelay.HeaderText = "Delay";
            this.m_colQuotesDelay.MinimumWidth = 100;
            this.m_colQuotesDelay.Name = "m_colQuotesDelay";
            this.m_colQuotesDelay.ReadOnly = true;
            // 
            // m_colQuotesIsHalted
            // 
            this.m_colQuotesIsHalted.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colQuotesIsHalted.HeaderText = "Halted";
            this.m_colQuotesIsHalted.MinimumWidth = 100;
            this.m_colQuotesIsHalted.Name = "m_colQuotesIsHalted";
            this.m_colQuotesIsHalted.ReadOnly = true;
            // 
            // m_tabGetCandles
            // 
            this.m_tabGetCandles.Controls.Add(this.m_dtpGetCandlesEndTime);
            this.m_tabGetCandles.Controls.Add(this.m_lblEndTime);
            this.m_tabGetCandles.Controls.Add(this.m_dtpGetCandlesStartTime);
            this.m_tabGetCandles.Controls.Add(this.m_lblStartTime);
            this.m_tabGetCandles.Controls.Add(this.m_cmbInterval);
            this.m_tabGetCandles.Controls.Add(this.m_lblInterval);
            this.m_tabGetCandles.Controls.Add(this.m_btnRefreshCandlesAsync);
            this.m_tabGetCandles.Controls.Add(this.m_btnRefreshCandlesSync);
            this.m_tabGetCandles.Controls.Add(this.m_grdCandles);
            this.m_tabGetCandles.Location = new System.Drawing.Point(4, 22);
            this.m_tabGetCandles.Name = "m_tabGetCandles";
            this.m_tabGetCandles.Padding = new System.Windows.Forms.Padding(3);
            this.m_tabGetCandles.Size = new System.Drawing.Size(810, 497);
            this.m_tabGetCandles.TabIndex = 2;
            this.m_tabGetCandles.Text = "Chart Data";
            this.m_tabGetCandles.UseVisualStyleBackColor = true;
            // 
            // m_dtpGetCandlesEndTime
            // 
            this.m_dtpGetCandlesEndTime.CustomFormat = "MM dd yyyy HH mm ss";
            this.m_dtpGetCandlesEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dtpGetCandlesEndTime.Location = new System.Drawing.Point(450, 10);
            this.m_dtpGetCandlesEndTime.Name = "m_dtpGetCandlesEndTime";
            this.m_dtpGetCandlesEndTime.Size = new System.Drawing.Size(167, 20);
            this.m_dtpGetCandlesEndTime.TabIndex = 25;
            this.m_dtpGetCandlesEndTime.Value = new System.DateTime(2015, 1, 31, 0, 0, 0, 0);
            // 
            // m_lblEndTime
            // 
            this.m_lblEndTime.AutoSize = true;
            this.m_lblEndTime.Location = new System.Drawing.Point(389, 13);
            this.m_lblEndTime.Name = "m_lblEndTime";
            this.m_lblEndTime.Size = new System.Drawing.Size(55, 13);
            this.m_lblEndTime.TabIndex = 24;
            this.m_lblEndTime.Text = "End Time:";
            // 
            // m_dtpGetCandlesStartTime
            // 
            this.m_dtpGetCandlesStartTime.CustomFormat = "MM dd yyyy HH mm ss";
            this.m_dtpGetCandlesStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dtpGetCandlesStartTime.Location = new System.Drawing.Point(216, 10);
            this.m_dtpGetCandlesStartTime.Name = "m_dtpGetCandlesStartTime";
            this.m_dtpGetCandlesStartTime.Size = new System.Drawing.Size(167, 20);
            this.m_dtpGetCandlesStartTime.TabIndex = 23;
            this.m_dtpGetCandlesStartTime.Value = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            // 
            // m_lblStartTime
            // 
            this.m_lblStartTime.AutoSize = true;
            this.m_lblStartTime.Location = new System.Drawing.Point(161, 13);
            this.m_lblStartTime.Name = "m_lblStartTime";
            this.m_lblStartTime.Size = new System.Drawing.Size(58, 13);
            this.m_lblStartTime.TabIndex = 22;
            this.m_lblStartTime.Text = "Start Time:";
            // 
            // m_cmbInterval
            // 
            this.m_cmbInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cmbInterval.FormattingEnabled = true;
            this.m_cmbInterval.Location = new System.Drawing.Point(54, 10);
            this.m_cmbInterval.Name = "m_cmbInterval";
            this.m_cmbInterval.Size = new System.Drawing.Size(101, 21);
            this.m_cmbInterval.TabIndex = 21;
            // 
            // m_lblInterval
            // 
            this.m_lblInterval.AutoSize = true;
            this.m_lblInterval.Location = new System.Drawing.Point(3, 13);
            this.m_lblInterval.Name = "m_lblInterval";
            this.m_lblInterval.Size = new System.Drawing.Size(45, 13);
            this.m_lblInterval.TabIndex = 20;
            this.m_lblInterval.Text = "Interval:";
            // 
            // m_btnRefreshCandlesAsync
            // 
            this.m_btnRefreshCandlesAsync.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnRefreshCandlesAsync.Location = new System.Drawing.Point(719, 8);
            this.m_btnRefreshCandlesAsync.Name = "m_btnRefreshCandlesAsync";
            this.m_btnRefreshCandlesAsync.Size = new System.Drawing.Size(85, 23);
            this.m_btnRefreshCandlesAsync.TabIndex = 13;
            this.m_btnRefreshCandlesAsync.Text = "Refresh Async";
            this.m_btnRefreshCandlesAsync.UseVisualStyleBackColor = true;
            this.m_btnRefreshCandlesAsync.Click += new System.EventHandler(this.m_btnRefreshCandlesAsync_Click);
            // 
            // m_btnRefreshCandlesSync
            // 
            this.m_btnRefreshCandlesSync.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnRefreshCandlesSync.Location = new System.Drawing.Point(628, 8);
            this.m_btnRefreshCandlesSync.Name = "m_btnRefreshCandlesSync";
            this.m_btnRefreshCandlesSync.Size = new System.Drawing.Size(85, 23);
            this.m_btnRefreshCandlesSync.TabIndex = 12;
            this.m_btnRefreshCandlesSync.Text = "Refresh";
            this.m_btnRefreshCandlesSync.UseVisualStyleBackColor = true;
            this.m_btnRefreshCandlesSync.Click += new System.EventHandler(this.m_btnRefreshCandlesSync_Click);
            // 
            // m_grdCandles
            // 
            this.m_grdCandles.AllowUserToAddRows = false;
            this.m_grdCandles.AllowUserToDeleteRows = false;
            this.m_grdCandles.AllowUserToOrderColumns = true;
            this.m_grdCandles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_grdCandles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.m_grdCandles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_grdCandles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.m_colCandlesStart,
            this.m_colCandlesEnd,
            this.m_colCandlesLow,
            this.m_colCandlesHigh,
            this.m_colCandlesOpen,
            this.m_colCandlesClose,
            this.m_colCandlesVolume});
            this.m_grdCandles.Location = new System.Drawing.Point(6, 37);
            this.m_grdCandles.MultiSelect = false;
            this.m_grdCandles.Name = "m_grdCandles";
            this.m_grdCandles.ReadOnly = true;
            this.m_grdCandles.RowHeadersVisible = false;
            this.m_grdCandles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.m_grdCandles.Size = new System.Drawing.Size(798, 454);
            this.m_grdCandles.TabIndex = 11;
            // 
            // m_colCandlesStart
            // 
            this.m_colCandlesStart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colCandlesStart.HeaderText = "Start";
            this.m_colCandlesStart.MinimumWidth = 100;
            this.m_colCandlesStart.Name = "m_colCandlesStart";
            this.m_colCandlesStart.ReadOnly = true;
            // 
            // m_colCandlesEnd
            // 
            this.m_colCandlesEnd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colCandlesEnd.HeaderText = "End";
            this.m_colCandlesEnd.MinimumWidth = 100;
            this.m_colCandlesEnd.Name = "m_colCandlesEnd";
            this.m_colCandlesEnd.ReadOnly = true;
            // 
            // m_colCandlesLow
            // 
            this.m_colCandlesLow.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colCandlesLow.HeaderText = "Low";
            this.m_colCandlesLow.MinimumWidth = 100;
            this.m_colCandlesLow.Name = "m_colCandlesLow";
            this.m_colCandlesLow.ReadOnly = true;
            // 
            // m_colCandlesHigh
            // 
            this.m_colCandlesHigh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colCandlesHigh.HeaderText = "High";
            this.m_colCandlesHigh.MinimumWidth = 100;
            this.m_colCandlesHigh.Name = "m_colCandlesHigh";
            this.m_colCandlesHigh.ReadOnly = true;
            // 
            // m_colCandlesOpen
            // 
            this.m_colCandlesOpen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colCandlesOpen.HeaderText = "Open";
            this.m_colCandlesOpen.MinimumWidth = 100;
            this.m_colCandlesOpen.Name = "m_colCandlesOpen";
            this.m_colCandlesOpen.ReadOnly = true;
            // 
            // m_colCandlesClose
            // 
            this.m_colCandlesClose.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colCandlesClose.HeaderText = "Close";
            this.m_colCandlesClose.MinimumWidth = 100;
            this.m_colCandlesClose.Name = "m_colCandlesClose";
            this.m_colCandlesClose.ReadOnly = true;
            // 
            // m_colCandlesVolume
            // 
            this.m_colCandlesVolume.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colCandlesVolume.HeaderText = "Volume";
            this.m_colCandlesVolume.MinimumWidth = 100;
            this.m_colCandlesVolume.Name = "m_colCandlesVolume";
            this.m_colCandlesVolume.ReadOnly = true;
            // 
            // m_tabGetOptions
            // 
            this.m_tabGetOptions.Controls.Add(this.m_txtOptionChainSymbolIds);
            this.m_tabGetOptions.Controls.Add(this.label10);
            this.m_tabGetOptions.Controls.Add(this.m_btnRefreshOptionsAsync);
            this.m_tabGetOptions.Controls.Add(this.m_btnRefreshOptionsSync);
            this.m_tabGetOptions.Controls.Add(this.m_grdOptions);
            this.m_tabGetOptions.Location = new System.Drawing.Point(4, 22);
            this.m_tabGetOptions.Name = "m_tabGetOptions";
            this.m_tabGetOptions.Padding = new System.Windows.Forms.Padding(3);
            this.m_tabGetOptions.Size = new System.Drawing.Size(810, 497);
            this.m_tabGetOptions.TabIndex = 3;
            this.m_tabGetOptions.Text = "Option Chain";
            this.m_tabGetOptions.UseVisualStyleBackColor = true;
            // 
            // m_txtOptionChainSymbolIds
            // 
            this.m_txtOptionChainSymbolIds.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_txtOptionChainSymbolIds.Location = new System.Drawing.Point(75, 8);
            this.m_txtOptionChainSymbolIds.Name = "m_txtOptionChainSymbolIds";
            this.m_txtOptionChainSymbolIds.Size = new System.Drawing.Size(547, 20);
            this.m_txtOptionChainSymbolIds.TabIndex = 52;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 51;
            this.label10.Text = "Symbol IDs:";
            // 
            // m_btnRefreshOptionsAsync
            // 
            this.m_btnRefreshOptionsAsync.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnRefreshOptionsAsync.Location = new System.Drawing.Point(719, 8);
            this.m_btnRefreshOptionsAsync.Name = "m_btnRefreshOptionsAsync";
            this.m_btnRefreshOptionsAsync.Size = new System.Drawing.Size(85, 23);
            this.m_btnRefreshOptionsAsync.TabIndex = 28;
            this.m_btnRefreshOptionsAsync.Text = "Refresh Async";
            this.m_btnRefreshOptionsAsync.UseVisualStyleBackColor = true;
            this.m_btnRefreshOptionsAsync.Click += new System.EventHandler(this.m_btnRefreshOptionsAsync_Click);
            // 
            // m_btnRefreshOptionsSync
            // 
            this.m_btnRefreshOptionsSync.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnRefreshOptionsSync.Location = new System.Drawing.Point(628, 8);
            this.m_btnRefreshOptionsSync.Name = "m_btnRefreshOptionsSync";
            this.m_btnRefreshOptionsSync.Size = new System.Drawing.Size(85, 23);
            this.m_btnRefreshOptionsSync.TabIndex = 27;
            this.m_btnRefreshOptionsSync.Text = "Refresh";
            this.m_btnRefreshOptionsSync.UseVisualStyleBackColor = true;
            this.m_btnRefreshOptionsSync.Click += new System.EventHandler(this.m_btnRefreshOptionsSync_Click);
            // 
            // m_grdOptions
            // 
            this.m_grdOptions.AllowUserToAddRows = false;
            this.m_grdOptions.AllowUserToDeleteRows = false;
            this.m_grdOptions.AllowUserToOrderColumns = true;
            this.m_grdOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_grdOptions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.m_grdOptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_grdOptions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.m_colOptionsExpiryDate,
            this.m_colOptionsOptionRoot,
            this.m_colOptionsMultiplier,
            this.m_colOptionsStrikePrice,
            this.m_colOptionsCallSymbolId,
            this.m_colOptionsPutSymbolId});
            this.m_grdOptions.Location = new System.Drawing.Point(5, 37);
            this.m_grdOptions.MultiSelect = false;
            this.m_grdOptions.Name = "m_grdOptions";
            this.m_grdOptions.ReadOnly = true;
            this.m_grdOptions.RowHeadersVisible = false;
            this.m_grdOptions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.m_grdOptions.Size = new System.Drawing.Size(799, 454);
            this.m_grdOptions.TabIndex = 26;
            // 
            // m_colOptionsExpiryDate
            // 
            this.m_colOptionsExpiryDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle9.Format = "d";
            dataGridViewCellStyle9.NullValue = null;
            this.m_colOptionsExpiryDate.DefaultCellStyle = dataGridViewCellStyle9;
            this.m_colOptionsExpiryDate.HeaderText = "Expiry Date";
            this.m_colOptionsExpiryDate.MinimumWidth = 100;
            this.m_colOptionsExpiryDate.Name = "m_colOptionsExpiryDate";
            this.m_colOptionsExpiryDate.ReadOnly = true;
            // 
            // m_colOptionsOptionRoot
            // 
            this.m_colOptionsOptionRoot.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colOptionsOptionRoot.HeaderText = "Option Root";
            this.m_colOptionsOptionRoot.MinimumWidth = 100;
            this.m_colOptionsOptionRoot.Name = "m_colOptionsOptionRoot";
            this.m_colOptionsOptionRoot.ReadOnly = true;
            // 
            // m_colOptionsMultiplier
            // 
            this.m_colOptionsMultiplier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colOptionsMultiplier.HeaderText = "Multiplier";
            this.m_colOptionsMultiplier.MinimumWidth = 100;
            this.m_colOptionsMultiplier.Name = "m_colOptionsMultiplier";
            this.m_colOptionsMultiplier.ReadOnly = true;
            // 
            // m_colOptionsStrikePrice
            // 
            this.m_colOptionsStrikePrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colOptionsStrikePrice.HeaderText = "Strike Price";
            this.m_colOptionsStrikePrice.MinimumWidth = 100;
            this.m_colOptionsStrikePrice.Name = "m_colOptionsStrikePrice";
            this.m_colOptionsStrikePrice.ReadOnly = true;
            // 
            // m_colOptionsCallSymbolId
            // 
            this.m_colOptionsCallSymbolId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colOptionsCallSymbolId.HeaderText = "Call Symbol ID";
            this.m_colOptionsCallSymbolId.MinimumWidth = 100;
            this.m_colOptionsCallSymbolId.Name = "m_colOptionsCallSymbolId";
            this.m_colOptionsCallSymbolId.ReadOnly = true;
            // 
            // m_colOptionsPutSymbolId
            // 
            this.m_colOptionsPutSymbolId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colOptionsPutSymbolId.HeaderText = "Put Symbol ID";
            this.m_colOptionsPutSymbolId.MinimumWidth = 100;
            this.m_colOptionsPutSymbolId.Name = "m_colOptionsPutSymbolId";
            this.m_colOptionsPutSymbolId.ReadOnly = true;
            // 
            // m_tabGetMarkets
            // 
            this.m_tabGetMarkets.Controls.Add(this.m_lstLevel2Feeds);
            this.m_tabGetMarkets.Controls.Add(this.m_lstLevel1Feeds);
            this.m_tabGetMarkets.Controls.Add(this.m_lstSecondaryOrderRoutes);
            this.m_tabGetMarkets.Controls.Add(this.m_lstPrimaryOrderRoutes);
            this.m_tabGetMarkets.Controls.Add(this.m_lstTradingVenues);
            this.m_tabGetMarkets.Controls.Add(this.label48);
            this.m_tabGetMarkets.Controls.Add(this.label47);
            this.m_tabGetMarkets.Controls.Add(this.label46);
            this.m_tabGetMarkets.Controls.Add(this.label45);
            this.m_tabGetMarkets.Controls.Add(this.label39);
            this.m_tabGetMarkets.Controls.Add(this.label28);
            this.m_tabGetMarkets.Controls.Add(this.m_btnRefreshMarketsAsync);
            this.m_tabGetMarkets.Controls.Add(this.m_btnRefreshMarketsSync);
            this.m_tabGetMarkets.Controls.Add(this.m_grdMarkets);
            this.m_tabGetMarkets.Location = new System.Drawing.Point(4, 22);
            this.m_tabGetMarkets.Name = "m_tabGetMarkets";
            this.m_tabGetMarkets.Padding = new System.Windows.Forms.Padding(3);
            this.m_tabGetMarkets.Size = new System.Drawing.Size(810, 497);
            this.m_tabGetMarkets.TabIndex = 5;
            this.m_tabGetMarkets.Text = "Markets";
            this.m_tabGetMarkets.UseVisualStyleBackColor = true;
            // 
            // m_lstLevel2Feeds
            // 
            this.m_lstLevel2Feeds.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_lstLevel2Feeds.FormattingEnabled = true;
            this.m_lstLevel2Feeds.Location = new System.Drawing.Point(416, 396);
            this.m_lstLevel2Feeds.Name = "m_lstLevel2Feeds";
            this.m_lstLevel2Feeds.Size = new System.Drawing.Size(388, 95);
            this.m_lstLevel2Feeds.TabIndex = 68;
            // 
            // m_lstLevel1Feeds
            // 
            this.m_lstLevel1Feeds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_lstLevel1Feeds.FormattingEnabled = true;
            this.m_lstLevel1Feeds.Location = new System.Drawing.Point(9, 396);
            this.m_lstLevel1Feeds.Name = "m_lstLevel1Feeds";
            this.m_lstLevel1Feeds.Size = new System.Drawing.Size(388, 95);
            this.m_lstLevel1Feeds.TabIndex = 67;
            // 
            // m_lstSecondaryOrderRoutes
            // 
            this.m_lstSecondaryOrderRoutes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_lstSecondaryOrderRoutes.FormattingEnabled = true;
            this.m_lstSecondaryOrderRoutes.Location = new System.Drawing.Point(551, 277);
            this.m_lstSecondaryOrderRoutes.Name = "m_lstSecondaryOrderRoutes";
            this.m_lstSecondaryOrderRoutes.Size = new System.Drawing.Size(253, 95);
            this.m_lstSecondaryOrderRoutes.TabIndex = 66;
            // 
            // m_lstPrimaryOrderRoutes
            // 
            this.m_lstPrimaryOrderRoutes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_lstPrimaryOrderRoutes.FormattingEnabled = true;
            this.m_lstPrimaryOrderRoutes.Location = new System.Drawing.Point(280, 277);
            this.m_lstPrimaryOrderRoutes.Name = "m_lstPrimaryOrderRoutes";
            this.m_lstPrimaryOrderRoutes.Size = new System.Drawing.Size(253, 95);
            this.m_lstPrimaryOrderRoutes.TabIndex = 65;
            // 
            // m_lstTradingVenues
            // 
            this.m_lstTradingVenues.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_lstTradingVenues.FormattingEnabled = true;
            this.m_lstTradingVenues.Location = new System.Drawing.Point(9, 277);
            this.m_lstTradingVenues.Name = "m_lstTradingVenues";
            this.m_lstTradingVenues.Size = new System.Drawing.Size(253, 95);
            this.m_lstTradingVenues.TabIndex = 64;
            // 
            // label48
            // 
            this.label48.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(413, 379);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(77, 13);
            this.label48.TabIndex = 63;
            this.label48.Text = "Level 2 Feeds:";
            // 
            // label47
            // 
            this.label47.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(6, 379);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(77, 13);
            this.label47.TabIndex = 62;
            this.label47.Text = "Level 1 Feeds:";
            // 
            // label46
            // 
            this.label46.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(548, 261);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(127, 13);
            this.label46.TabIndex = 61;
            this.label46.Text = "Secondary Order Routes:";
            // 
            // label45
            // 
            this.label45.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(277, 261);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(110, 13);
            this.label45.TabIndex = 60;
            this.label45.Text = "Primary Order Routes:";
            // 
            // label39
            // 
            this.label39.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(6, 261);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(85, 13);
            this.label39.TabIndex = 59;
            this.label39.Text = "Trading Venues:";
            // 
            // label28
            // 
            this.label28.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 21);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(48, 13);
            this.label28.TabIndex = 53;
            this.label28.Text = "Markets:";
            // 
            // m_btnRefreshMarketsAsync
            // 
            this.m_btnRefreshMarketsAsync.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnRefreshMarketsAsync.Location = new System.Drawing.Point(719, 8);
            this.m_btnRefreshMarketsAsync.Name = "m_btnRefreshMarketsAsync";
            this.m_btnRefreshMarketsAsync.Size = new System.Drawing.Size(85, 23);
            this.m_btnRefreshMarketsAsync.TabIndex = 46;
            this.m_btnRefreshMarketsAsync.Text = "Refresh Async";
            this.m_btnRefreshMarketsAsync.UseVisualStyleBackColor = true;
            this.m_btnRefreshMarketsAsync.Click += new System.EventHandler(this.m_btnRefreshMarketsAsync_Click);
            // 
            // m_btnRefreshMarketsSync
            // 
            this.m_btnRefreshMarketsSync.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnRefreshMarketsSync.Location = new System.Drawing.Point(628, 8);
            this.m_btnRefreshMarketsSync.Name = "m_btnRefreshMarketsSync";
            this.m_btnRefreshMarketsSync.Size = new System.Drawing.Size(85, 23);
            this.m_btnRefreshMarketsSync.TabIndex = 45;
            this.m_btnRefreshMarketsSync.Text = "Refresh";
            this.m_btnRefreshMarketsSync.UseVisualStyleBackColor = true;
            this.m_btnRefreshMarketsSync.Click += new System.EventHandler(this.m_btnRefreshMarketsSync_Click);
            // 
            // m_grdMarkets
            // 
            this.m_grdMarkets.AllowUserToAddRows = false;
            this.m_grdMarkets.AllowUserToDeleteRows = false;
            this.m_grdMarkets.AllowUserToOrderColumns = true;
            this.m_grdMarkets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_grdMarkets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.m_grdMarkets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_grdMarkets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.m_colMarketsName,
            this.m_colMarketsDefaultTradingVenue,
            this.m_colMarketsExtendedStartTime,
            this.m_colMarketsStartTime,
            this.m_colMarketsEndTime,
            this.m_colMarketsExtendedEndTime,
            this.m_colMarketsSnapQuotesLimit});
            this.m_grdMarkets.Location = new System.Drawing.Point(6, 37);
            this.m_grdMarkets.MultiSelect = false;
            this.m_grdMarkets.Name = "m_grdMarkets";
            this.m_grdMarkets.ReadOnly = true;
            this.m_grdMarkets.RowHeadersVisible = false;
            this.m_grdMarkets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.m_grdMarkets.Size = new System.Drawing.Size(798, 221);
            this.m_grdMarkets.TabIndex = 44;
            this.m_grdMarkets.SelectionChanged += new System.EventHandler(this.m_grdMarkets_SelectionChanged);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label6);
            this.panel9.Controls.Add(this.m_lblMarketDataRateLimitRemainingRequestsCount);
            this.panel9.Controls.Add(this.m_lblMarketDataRateLimitRequestsResetTime);
            this.panel9.Controls.Add(this.label8);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(3, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(818, 29);
            this.panel9.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Remaining Requests Count:";
            // 
            // m_lblMarketDataRateLimitRemainingRequestsCount
            // 
            this.m_lblMarketDataRateLimitRemainingRequestsCount.AutoSize = true;
            this.m_lblMarketDataRateLimitRemainingRequestsCount.Location = new System.Drawing.Point(151, 7);
            this.m_lblMarketDataRateLimitRemainingRequestsCount.Name = "m_lblMarketDataRateLimitRemainingRequestsCount";
            this.m_lblMarketDataRateLimitRemainingRequestsCount.Size = new System.Drawing.Size(0, 13);
            this.m_lblMarketDataRateLimitRemainingRequestsCount.TabIndex = 10;
            this.m_lblMarketDataRateLimitRemainingRequestsCount.Tag = "";
            // 
            // m_lblMarketDataRateLimitRequestsResetTime
            // 
            this.m_lblMarketDataRateLimitRequestsResetTime.AutoSize = true;
            this.m_lblMarketDataRateLimitRequestsResetTime.Location = new System.Drawing.Point(380, 7);
            this.m_lblMarketDataRateLimitRequestsResetTime.Name = "m_lblMarketDataRateLimitRequestsResetTime";
            this.m_lblMarketDataRateLimitRequestsResetTime.Size = new System.Drawing.Size(0, 13);
            this.m_lblMarketDataRateLimitRequestsResetTime.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(262, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Requests Reset Time:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 648);
            this.panel1.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.m_tabs);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 64);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(832, 584);
            this.panel4.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.m_grpAuthenticate);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(832, 64);
            this.panel3.TabIndex = 8;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 648);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(832, 3);
            this.splitter1.TabIndex = 9;
            this.splitter1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_lblActivityLog);
            this.panel2.Controls.Add(this.m_rtbActivityLog);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 651);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(832, 152);
            this.panel2.TabIndex = 8;
            // 
            // m_colMarketsName
            // 
            this.m_colMarketsName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colMarketsName.HeaderText = "Name";
            this.m_colMarketsName.MinimumWidth = 100;
            this.m_colMarketsName.Name = "m_colMarketsName";
            this.m_colMarketsName.ReadOnly = true;
            // 
            // m_colMarketsDefaultTradingVenue
            // 
            this.m_colMarketsDefaultTradingVenue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colMarketsDefaultTradingVenue.HeaderText = "Default Trading Venue";
            this.m_colMarketsDefaultTradingVenue.MinimumWidth = 170;
            this.m_colMarketsDefaultTradingVenue.Name = "m_colMarketsDefaultTradingVenue";
            this.m_colMarketsDefaultTradingVenue.ReadOnly = true;
            // 
            // m_colMarketsExtendedStartTime
            // 
            this.m_colMarketsExtendedStartTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle10.Format = "hh\\:mm\\:ss";
            dataGridViewCellStyle10.NullValue = null;
            this.m_colMarketsExtendedStartTime.DefaultCellStyle = dataGridViewCellStyle10;
            this.m_colMarketsExtendedStartTime.HeaderText = "Extended Start Time";
            this.m_colMarketsExtendedStartTime.MinimumWidth = 170;
            this.m_colMarketsExtendedStartTime.Name = "m_colMarketsExtendedStartTime";
            this.m_colMarketsExtendedStartTime.ReadOnly = true;
            // 
            // m_colMarketsStartTime
            // 
            this.m_colMarketsStartTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle11.Format = "hh\\:mm\\:ss";
            dataGridViewCellStyle11.NullValue = null;
            this.m_colMarketsStartTime.DefaultCellStyle = dataGridViewCellStyle11;
            this.m_colMarketsStartTime.HeaderText = "Start Time";
            this.m_colMarketsStartTime.MinimumWidth = 100;
            this.m_colMarketsStartTime.Name = "m_colMarketsStartTime";
            this.m_colMarketsStartTime.ReadOnly = true;
            // 
            // m_colMarketsEndTime
            // 
            this.m_colMarketsEndTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle12.Format = "hh\\:mm\\:ss";
            dataGridViewCellStyle12.NullValue = null;
            this.m_colMarketsEndTime.DefaultCellStyle = dataGridViewCellStyle12;
            this.m_colMarketsEndTime.HeaderText = "End Time";
            this.m_colMarketsEndTime.MinimumWidth = 100;
            this.m_colMarketsEndTime.Name = "m_colMarketsEndTime";
            this.m_colMarketsEndTime.ReadOnly = true;
            // 
            // m_colMarketsExtendedEndTime
            // 
            this.m_colMarketsExtendedEndTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle13.Format = "hh\\:mm\\:ss";
            dataGridViewCellStyle13.NullValue = null;
            this.m_colMarketsExtendedEndTime.DefaultCellStyle = dataGridViewCellStyle13;
            this.m_colMarketsExtendedEndTime.HeaderText = "Extended End Time";
            this.m_colMarketsExtendedEndTime.MinimumWidth = 170;
            this.m_colMarketsExtendedEndTime.Name = "m_colMarketsExtendedEndTime";
            this.m_colMarketsExtendedEndTime.ReadOnly = true;
            // 
            // m_colMarketsSnapQuotesLimit
            // 
            this.m_colMarketsSnapQuotesLimit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_colMarketsSnapQuotesLimit.HeaderText = "Snap Quotes Limit";
            this.m_colMarketsSnapQuotesLimit.MinimumWidth = 170;
            this.m_colMarketsSnapQuotesLimit.Name = "m_colMarketsSnapQuotesLimit";
            this.m_colMarketsSnapQuotesLimit.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 803);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(848, 790);
            this.Name = "MainForm";
            this.Text = "Questrade .NET API Test Client";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.m_grpAuthenticate.ResumeLayout(false);
            this.m_grpAuthenticate.PerformLayout();
            this.m_tabs.ResumeLayout(false);
            this.m_tabAccountData.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.m_tabsAccounts.ResumeLayout(false);
            this.m_tabBalances.ResumeLayout(false);
            this.m_tabAccountBalances.ResumeLayout(false);
            this.m_tabCurrentBalances.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grdCurrentBalances)).EndInit();
            this.m_tabSodBalances.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grdSodBalances)).EndInit();
            this.m_tabPositions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grdPositions)).EndInit();
            this.m_tabOrders.ResumeLayout(false);
            this.m_tabOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grdOrderLegs)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grdOrders)).EndInit();
            this.m_tabExecutions.ResumeLayout(false);
            this.m_tabExecutions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grdExecutions)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grdAccounts)).EndInit();
            this.m_tabMarketData.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.m_tabsMarketData.ResumeLayout(false);
            this.m_tabSearchSymbols.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grdSymbolSearch)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.m_tabGetSymbols.ResumeLayout(false);
            this.m_tabGetSymbols.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grdSymbolsContractDeliverables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grdSymbolsMinTicks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grdSymbols)).EndInit();
            this.m_tabGetQuotes.ResumeLayout(false);
            this.m_tabGetQuotes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grdQuotes)).EndInit();
            this.m_tabGetCandles.ResumeLayout(false);
            this.m_tabGetCandles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grdCandles)).EndInit();
            this.m_tabGetOptions.ResumeLayout(false);
            this.m_tabGetOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grdOptions)).EndInit();
            this.m_tabGetMarkets.ResumeLayout(false);
            this.m_tabGetMarkets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grdMarkets)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox m_rtbActivityLog;
        private System.Windows.Forms.GroupBox m_grpAuthenticate;
        private System.Windows.Forms.Label m_lblAuthStatus;
        private System.Windows.Forms.Button m_btnAuth;
        private System.Windows.Forms.Button m_btnInsertOrder;
        private System.Windows.Forms.Button m_btnCancelOrder;
        private System.Windows.Forms.Button m_btnReplaceOrder;
        private System.Windows.Forms.Button m_btnGetTime;
        private System.Windows.Forms.Label m_lblActivityLog;
        private System.Windows.Forms.TextBox m_txtRefreshToken;
        private System.Windows.Forms.Label m_lblRefreshToken;
        private System.Windows.Forms.CheckBox m_chkIsDemo;
        private System.Windows.Forms.TabControl m_tabs;
        private System.Windows.Forms.TabPage m_tabAccountData;
        private System.Windows.Forms.TabControl m_tabsAccounts;
        private System.Windows.Forms.TabPage m_tabPositions;
        private System.Windows.Forms.TabPage m_tabOrders;
        private System.Windows.Forms.TabPage m_tabExecutions;
        private System.Windows.Forms.TabPage m_tabBalances;
        private System.Windows.Forms.TabPage m_tabMarketData;
        private System.Windows.Forms.Button m_btnRefreshAsync;
        private System.Windows.Forms.Button m_btnRefreshAccountsSync;
        private System.Windows.Forms.DataGridView m_grdAccounts;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colAccountType;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colAccountNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colAccountStatus;
        private System.Windows.Forms.DataGridViewCheckBoxColumn m_colAccountIsPrimary;
        private System.Windows.Forms.DataGridViewCheckBoxColumn m_colAccountIsBilling;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colAccountClientAccountType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label m_lblAccountDataRateLimitRemainingRequestsCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label m_lblAccountDataRateLimitRequestsResetTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label m_lblGetAccountsUserId;
        private System.Windows.Forms.Button m_btnRefreshPositionsAsync;
        private System.Windows.Forms.Button m_btnRefreshPositionsSync;
        private System.Windows.Forms.DataGridView m_grdPositions;
        private System.Windows.Forms.Button m_btnRefreshBalancesAsync;
        private System.Windows.Forms.Button m_btnRefreshBalancesSync;
        private System.Windows.Forms.Button m_btnRefreshExecutionsAsync;
        private System.Windows.Forms.Button m_btnRefreshExecutionsSync;
        private System.Windows.Forms.DataGridView m_grdExecutions;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker m_dtpGetExecutionsStartTime;
        private System.Windows.Forms.DateTimePicker m_dtpGetExecutionsEndTime;
        private System.Windows.Forms.DateTimePicker m_dtpGetOrdersEndTime;
        private System.Windows.Forms.Label m_lblGetOrdersByDateEndTime;
        private System.Windows.Forms.DateTimePicker m_dtpGetOrdersStartTime;
        private System.Windows.Forms.Label m_lblGetOrdersByDateStartTime;
        private System.Windows.Forms.Label m_lblGetOrdersRateLimitRequestsResetTime;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label m_lblGetOrdersRateLimitRemainingRequestsCount;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button m_btnRefreshOrdersAsync;
        private System.Windows.Forms.Button m_btnRefreshOrdersSync;
        private System.Windows.Forms.DataGridView m_grdOrders;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton m_rbGetOrderByID;
        private System.Windows.Forms.RadioButton m_rbGetOrdersByDate;
        private System.Windows.Forms.TextBox m_txtGetOrderByIdOrderId;
        private System.Windows.Forms.Label m_lblGetOrderByIdOrderId;
        private System.Windows.Forms.ComboBox m_cmbStateFilter;
        private System.Windows.Forms.Label m_lblGetOrdersByDateStateFilter;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridView m_grdOrderLegs;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colOrderLegsLegId;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colOrderLegsSymbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colOrderLegsSymbolId;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colOrderLegsLegRatioQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colOrderLegsSide;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colOrderLegsAvgExecPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colOrderLegsLastExecPrice;
        private System.Windows.Forms.TabControl m_tabsMarketData;
        private System.Windows.Forms.TabPage m_tabGetQuotes;
        private System.Windows.Forms.TabPage m_tabSearchSymbols;
        private System.Windows.Forms.TabPage m_tabGetCandles;
        private System.Windows.Forms.TabPage m_tabGetOptions;
        private System.Windows.Forms.TabPage m_tabGetSymbols;
        private System.Windows.Forms.TabPage m_tabGetMarkets;
        private System.Windows.Forms.Button m_btnRefreshCandlesAsync;
        private System.Windows.Forms.Button m_btnRefreshCandlesSync;
        private System.Windows.Forms.DataGridView m_grdCandles;
        private System.Windows.Forms.ComboBox m_cmbInterval;
        private System.Windows.Forms.Label m_lblInterval;
        private System.Windows.Forms.DateTimePicker m_dtpGetCandlesStartTime;
        private System.Windows.Forms.Label m_lblStartTime;
        private System.Windows.Forms.DateTimePicker m_dtpGetCandlesEndTime;
        private System.Windows.Forms.Label m_lblEndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colCandlesStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colCandlesEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colCandlesLow;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colCandlesHigh;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colCandlesOpen;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colCandlesClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colCandlesVolume;
        private System.Windows.Forms.Button m_btnRefreshSymbolSearchAsync;
        private System.Windows.Forms.Button m_btnRefreshSymbolSearchSync;
        private System.Windows.Forms.DataGridView m_grdSymbolSearch;
        private System.Windows.Forms.TextBox m_txtPrefix;
        private System.Windows.Forms.Label m_lblPrefix;
        private System.Windows.Forms.TextBox m_txtOffset;
        private System.Windows.Forms.Label m_lblOffset;
        private System.Windows.Forms.Button m_btnRefreshQuotesAsync;
        private System.Windows.Forms.Button m_btnRefreshQuotesSync;
        private System.Windows.Forms.DataGridView m_grdQuotes;
        private System.Windows.Forms.Button m_btnRefreshSymbolsAsync;
        private System.Windows.Forms.Button m_btnRefreshSymbolsSync;
        private System.Windows.Forms.DataGridView m_grdSymbols;
        private System.Windows.Forms.Button m_btnRefreshOptionsAsync;
        private System.Windows.Forms.Button m_btnRefreshOptionsSync;
        private System.Windows.Forms.DataGridView m_grdOptions;
        private System.Windows.Forms.Button m_btnRefreshMarketsAsync;
        private System.Windows.Forms.Button m_btnRefreshMarketsSync;
        private System.Windows.Forms.DataGridView m_grdMarkets;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colSymbolSearchSymbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colSymbolSearchSymbolId;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colSymbolSearchDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colSymbolSearchSecurityType;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colSymbolSearchIsCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colSymbolSearchListingExchange;
        private System.Windows.Forms.DataGridViewCheckBoxColumn m_colSymbolSearchIsTradable;
        private System.Windows.Forms.DataGridViewCheckBoxColumn m_colSymbolSearchIsQuotable;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colQuotesSymbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colQuotesSymbolId;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colQuotesBidPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colQuotesBidSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colQuotesAskPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colQuotesAskSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colQuotesLastTradePriceTrHrs;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colQuotesLastTradePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colQuotesLastTradeSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colQuotesLastTradeTick;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colQuotesLastTradeTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colQuotesVolume;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colQuotesOpenPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colQuotesHighPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colQuotesLowPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colQuotesDelay;
        private System.Windows.Forms.DataGridViewCheckBoxColumn m_colQuotesIsHalted;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colPositionsSymbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colPositionsSymbolId;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colPositionsOpenQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colPositionsClosedQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colPositionsCurrMktVal;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colPositionsCurrPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colPositionsAvgEntryPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colPositionsClosedPnl;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colPositionsOpenPnl;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colPositionsTotalCost;
        private System.Windows.Forms.DataGridViewCheckBoxColumn m_colPositionsIsRealTime;
        private System.Windows.Forms.DataGridViewCheckBoxColumn m_colPositionsIsUnderReorg;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colOrdersId;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colOrdersSymbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colOrdersSymbolId;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colOrdersTotalQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colOrdersOpenQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colOrdersFilledQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colOrdersCanceledQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colOrdersSide;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colOrdersOrderType;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colOrdersLimitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colOrdersStopPrice;
        private System.Windows.Forms.DataGridViewCheckBoxColumn m_colOrdersIsAllOrNone;
        private System.Windows.Forms.DataGridViewCheckBoxColumn m_colOrdersIsAnon;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colOrdersIcebergQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colOrdersMinQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colOrdersAvgExecPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colOrdersLastExecPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colOrdersSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colOrdersTimeInForce;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colOrdersGtdDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colOrdersState;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colOrdersRejectionReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colOrdersChainId;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colOrdersCreationTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colOrdersUpdateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colOrdersNotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colOrdersPrimaryRoute;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colOrdersSecondaryRoute;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colOrdersOrderRoute;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colOrdersVenueHoldingOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colOrdersCommissionCharged;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colOrdersExchangeOrderId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn m_colOrdersIsSigShareHolder;
        private System.Windows.Forms.DataGridViewCheckBoxColumn m_colOrdersIsInsider;
        private System.Windows.Forms.DataGridViewCheckBoxColumn m_colOrdersIsLimitOffsetInDollar;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colOrdersUserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colOrdersPlacementCommission;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colOrdersStrategyType;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colOrdersTriggerStopPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colOrdersOrderGroupId;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colOrdersOrderClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colExecutionsSymbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colExecutionsSymbolId;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colExecutionsQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colExecutionsSide;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colExecutionsPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colExecutionsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colExecutionsOrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colExecutionsOrderChainId;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colExecutionsExchangeExecId;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colExecutionsTimestamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colExecutionsNotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colExecutionsVenue;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colExecutionsTotalCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colExecutionsPlacementCommission;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colExecutionsCommission;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colExecutionsExecFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colExecutionsSecFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colExecutionsLegId;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colExecutionsCdnExecFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colExecutionsParentId;
        private System.Windows.Forms.TabControl m_tabAccountBalances;
        private System.Windows.Forms.TabPage m_tabCurrentBalances;
        private System.Windows.Forms.DataGridView m_grdCurrentBalances;
        private System.Windows.Forms.TabPage m_tabSodBalances;
        private System.Windows.Forms.DataGridView m_grdSodBalances;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colCurrentBalancesCurrentBalances;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colCurrentBalancesCad;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colCurrentBalancesUsd;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colCurrentBalancesCadCombined;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colCurrentBalancesUsdCombined;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colSodBalancesSodBalances;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colSodBalancesCad;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colSodBalancesUsd;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colSodBalancesCadCombined;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colSodBalancesUsdCombined;
        private System.Windows.Forms.Label m_lblSymbolSearchSelectedSymbols;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colSymbolsSymbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colSymbolsSymbolId;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colSymbolsPrevDayClosePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colSymbolsHighPrice52;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colSymbolsLowPrice52;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colSymbolsAverageVol3Months;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colSymbolsAverageVol20Days;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colSymbolsOutstandingShares;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colSymbolsEps;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colSymbolsPe;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colSymbolsDividend;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colSymbolsYield;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colSymbolsExDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colSymbolsMarketCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colSymbolsTradeUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colSymbolsOptionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colSymbolsOptionDurationType;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colSymbolsOptionRoot;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colSymbolsOptionExerciseType;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colSymbolsListingExchange;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colSymbolsDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colSymbolsSecurityType;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colSymbolsOptionExpiryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colSymbolsDividendDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colSymbolsOptionStrikePrice;
        private System.Windows.Forms.DataGridViewCheckBoxColumn m_colSymbolsIsTradable;
        private System.Windows.Forms.DataGridViewCheckBoxColumn m_colSymbolsIsQuotable;
        private System.Windows.Forms.DataGridViewCheckBoxColumn m_colSymbolsHasOptions;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colSymbolsCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colSymbolsContractDeliverablesCashInLieu;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView m_grdSymbolsContractDeliverables;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView m_grdSymbolsMinTicks;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colSymbolDataMinTicksPivot;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colSymbolDataMinTicksMinTick;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colSymbolDataContractDeliverablesMultiplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colSymbolDataContractDeliverablesUnderlyingSymbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colSymbolDataContractDeliverablesUnderlyingSymbolId;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.ListBox m_lstLevel2Feeds;
        private System.Windows.Forms.ListBox m_lstLevel1Feeds;
        private System.Windows.Forms.ListBox m_lstSecondaryOrderRoutes;
        private System.Windows.Forms.ListBox m_lstPrimaryOrderRoutes;
        private System.Windows.Forms.ListBox m_lstTradingVenues;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label m_lblMarketDataRateLimitRemainingRequestsCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label m_lblMarketDataRateLimitRequestsResetTime;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox m_txtSymbolDataSymbolIds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m_txtQuotesSymbolIds;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colOptionsExpiryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colOptionsOptionRoot;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colOptionsMultiplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colOptionsStrikePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colOptionsCallSymbolId;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colOptionsPutSymbolId;
        private System.Windows.Forms.TextBox m_txtOptionChainSymbolIds;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colMarketsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colMarketsDefaultTradingVenue;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colMarketsExtendedStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colMarketsStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colMarketsEndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colMarketsExtendedEndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colMarketsSnapQuotesLimit;
    }
}

