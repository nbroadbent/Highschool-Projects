using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Questrade.BusinessObjects.Entities;
using QuestradeAPI;

namespace QuestradeAPI.Net.TestClient
{
    public partial class InsertOrderDetailsDlg : Form
    {
        #region Fields

        private MainForm m_parent;
        private bool m_hasGtdDate = false;

        #endregion

        #region C'tor

        public InsertOrderDetailsDlg(MainForm parent)
        {
            m_parent = parent;
            InitializeComponent();

            MainForm.InitEnumCombobox(m_cmbOrderType, OrderType.Undefined);
            MainForm.InitEnumCombobox(m_cmbTimeInForce, OrderTimeInForce.Undefined);
            MainForm.InitEnumCombobox(m_cmbSide, OrderAction.Undefined);
        }

        #endregion

        #region Event Handlers

        private void m_btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void m_dtpGtdDate_ValueChanged(object sender, EventArgs e)
        {
            m_hasGtdDate = true;
        }

        private void m_btnPreview_Click(object sender, EventArgs e)
        {
            InsertOrderRequest insertOrderRequest = new InsertOrderRequest();
            insertOrderRequest.m_accountNumber = m_parent.SelectedAccountNumber;
            insertOrderRequest.m_symbolId = SymbolID;
            insertOrderRequest.m_quantity = Quantity;
            insertOrderRequest.m_icebergQuantity = IcebergQuantity;
            insertOrderRequest.m_minQuantity = MinQuantity;
            insertOrderRequest.m_limitPrice = LimitPrice;
            insertOrderRequest.m_stopPrice = StopPrice;
            insertOrderRequest.m_isAllOrNone = IsAllOrNone;
            insertOrderRequest.m_isAnonymous = IsAnonymous;
            insertOrderRequest.m_orderType = OrderType;
            insertOrderRequest.m_timeInForce = TimeInForce;
            insertOrderRequest.m_gtdDate = GtdDate;
            insertOrderRequest.m_action = Action;
            insertOrderRequest.m_primaryRoute = PrimaryRoute;
            insertOrderRequest.m_secondaryRoute = SecondaryRoute;
            insertOrderRequest.m_isLimitOffsetInDollar = IsLimitOffsetInDollar;

            if (IsAsync)
            {
                m_parent.OnInsertOrderImpactRequest(true);
                InsertOrderImpactResponse.BeginInsertOrderImpact(m_parent.AuthImpl, new AsyncCallback(m_parent.InsertOrderImpactCallbackMethod), m_parent.NextAsyncRequestID, insertOrderRequest);
            }
            else
            {
                m_parent.OnInsertOrderImpactRequest(false);
                InsertOrderImpactResponse resp = InsertOrderImpactResponse.InsertOrderImpact(m_parent.AuthImpl, insertOrderRequest);
                m_parent.DisplayInsertOrderImpactResponse(resp);
            }
        }

        #endregion

        #region Properties

        public bool IsAsync
        {
            get
            {
                return m_chkAsync.Checked;
            }
        }

        public ulong SymbolID
        {
            get
            {
                return getULong(m_txtSymbolId);
            }
        }

        public double Quantity
        {
            get
            {
                return getDouble(m_txtSize);
            }
        }

        public double IcebergQuantity
        {
            get
            {
                return getDouble(m_txtIcebergSize);
            }
        }

        public double MinQuantity
        {
            get
            {
                return getDouble(m_txtMinSize);
            }
        }

        public double LimitPrice
        {
            get
            {
                return getDouble(m_txtLimitPrice);
            }
        }

        public double StopPrice
        {
            get
            {
                return getDouble(m_txtStopPrice);
            }
        }

        public bool IsAllOrNone
        {
            get
            {
                return m_chkIsAllOrNone.Checked;
            }
        }

        public bool IsAnonymous
        {
            get
            {
                return m_chkIsAnonymous.Checked;
            }
        }

        public OrderType OrderType
        {
            get
            {
                return MainForm.GetEnum<OrderType>(m_cmbOrderType);
            }
        }

        public OrderTimeInForce TimeInForce
        {
            get
            {
                return MainForm.GetEnum<OrderTimeInForce>(m_cmbTimeInForce);
            }
        }

        public OrderAction Action
        {
            get
            {
                return MainForm.GetEnum<OrderAction>(m_cmbSide);
            }
        }

        public string PrimaryRoute
        {
            get
            {
                return m_txtPrimaryRoute.Text;
            }
        }

        public string SecondaryRoute
        {
            get
            {
                return m_txtSecondaryRoute.Text;
            }
        }

        public bool IsLimitOffsetInDollar
        {
            get
            {
                return m_chkIsLimitOffsetInDollar.Checked;
            }
        }

        public DateTime GtdDate
        {
            get
            {
                return (m_hasGtdDate ? m_dtpGtdDate.Value.Date : DataTypeTraits<DateTime>.InvalidValue);
            }
        }

        #endregion

        #region Private Static Methods

        private static ulong getULong(TextBox tb)
        {
            try
            {
                return Convert.ToUInt64(tb.Text);
            }
            catch
            {
                return 0;
            }
        }

        private static double getDouble(TextBox tb)
        {
            try
            {
                return Convert.ToDouble(tb.Text);
            }
            catch
            {
                return QuestradeAPI.Constants.InvalidDbl;
            }
        }

        #endregion
    }
}
