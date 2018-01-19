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
    public partial class ReplaceOrderDetailsDlg : Form
    {
        #region Fields

        private MainForm m_parent;
        private bool m_hasGtdDate = false;

        #endregion

        #region C'tor

        public ReplaceOrderDetailsDlg(MainForm parent)
        {
            m_parent = parent;
            InitializeComponent();

            MainForm.InitEnumCombobox(m_cmbOrderType, OrderType.Undefined);
            MainForm.InitEnumCombobox(m_cmbTimeInForce, OrderTimeInForce.Undefined);
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
            ReplaceOrderRequest replaceOrderRequest = new ReplaceOrderRequest();
            replaceOrderRequest.m_accountNumber = m_parent.SelectedAccountNumber;
            replaceOrderRequest.m_orderId = OrderID;
            replaceOrderRequest.m_quantity = Quantity;
            replaceOrderRequest.m_icebergQuantity = IcebergQuantity;
            replaceOrderRequest.m_minQuantity = MinQuantity;
            replaceOrderRequest.m_limitPrice = LimitPrice;
            replaceOrderRequest.m_stopPrice = StopPrice;
            replaceOrderRequest.m_orderType = OrderType;
            replaceOrderRequest.m_timeInForce = TimeInForce;
            replaceOrderRequest.m_gtdDate = GtdDate;
            replaceOrderRequest.m_isLimitOffsetInDollar = IsLimitOffsetInDollar;
            replaceOrderRequest.m_isAllOrNone = IsAllOrNone;
            replaceOrderRequest.m_isAnonymous = IsAnonymous;
            
            if (IsAsync)
            {
                m_parent.OnReplaceOrderImpactRequest(true);
                ReplaceOrderImpactResponse.BeginReplaceOrderImpact(m_parent.AuthImpl, new AsyncCallback(m_parent.ReplaceOrderImpactCallbackMethod), m_parent.NextAsyncRequestID, replaceOrderRequest);
            }
            else
            {
                m_parent.OnReplaceOrderImpactRequest(false);
                ReplaceOrderImpactResponse resp = ReplaceOrderImpactResponse.ReplaceOrderImpact(m_parent.AuthImpl, replaceOrderRequest);
                m_parent.DisplayReplaceOrderImpactResponse(resp);
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

        public ulong OrderID
        {
            get
            {
                return getULong(m_txtOrderId);
            }
            set
            {
                m_txtOrderId.Text = value.ToString();
            }
        }

        public double Quantity
        {
            get
            {
                return getDouble(m_txtSize);
            }
            set
            {
                m_txtSize.Text = (value == QuestradeAPI.Constants.InvalidDbl ? String.Empty : value.ToString());
            }
        }

        public double IcebergQuantity
        {
            get
            {
                return getDouble(m_txtIcebergSize);
            }
            set
            {
                m_txtIcebergSize.Text = (value == QuestradeAPI.Constants.InvalidDbl ? String.Empty : value.ToString());
            }
        }

        public double MinQuantity
        {
            get
            {
                return getDouble(m_txtMinSize);
            }
            set
            {
                m_txtMinSize.Text = (value == QuestradeAPI.Constants.InvalidDbl ? String.Empty : value.ToString());
            }
        }

        public double LimitPrice
        {
            get
            {
                return getDouble(m_txtLimitPrice);
            }
            set
            {
                m_txtLimitPrice.Text = (value == QuestradeAPI.Constants.InvalidDbl ? String.Empty : value.ToString());
            }
        }

        public double StopPrice
        {
            get
            {
                return getDouble(m_txtStopPrice);
            }
            set
            {
                m_txtStopPrice.Text = (value == QuestradeAPI.Constants.InvalidDbl ? String.Empty : value.ToString());
            }
        }

        public bool IsAllOrNone
        {
            get
            {
                return m_chkIsAllOrNone.Checked;
            }
            set
            {
                m_chkIsAllOrNone.Checked = value;
            }
        }

        public bool IsAnonymous
        {
            get
            {
                return m_chkIsAnonymous.Checked;
            }
            set
            {
                m_chkIsAnonymous.Checked = value;
            }
        }

        public OrderType OrderType
        {
            get
            {
                return MainForm.GetEnum<OrderType>(m_cmbOrderType);
            }
            set
            {
                m_cmbOrderType.SelectedIndex = (int)value;
            }
        }

        public OrderTimeInForce TimeInForce
        {
            get
            {
                return MainForm.GetEnum<OrderTimeInForce>(m_cmbTimeInForce);
            }
            set
            {
                m_cmbTimeInForce.SelectedIndex = (int)value;
            }
        }

        public bool IsLimitOffsetInDollar
        {
            get
            {
                return m_chkIsLimitOffsetInDollar.Checked;
            }
            set
            {
                m_chkIsLimitOffsetInDollar.Checked = value;
            }
        }

        public DateTime GtdDate
        {
            get
            {
                return (m_hasGtdDate ? m_dtpGtdDate.Value.Date : DataTypeTraits<DateTime>.InvalidValue);
            }
            set
            {
                if (value == DataTypeTraits<DateTime>.InvalidValue)
                {
                    m_hasGtdDate = false;
                }
                else
                {
                    m_dtpGtdDate.Value = value;
                }
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
