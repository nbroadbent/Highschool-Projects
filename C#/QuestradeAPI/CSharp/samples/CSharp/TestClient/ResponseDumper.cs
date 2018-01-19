using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Questrade.BusinessObjects.Entities;

namespace QuestradeAPI.Net.TestClient
{
    public static class ResponseDumper
    {
        #region Public Static Methods

        public static string ToString(GetServerTimeResponse getTimeResp)
        {
            StringBuilder str = new StringBuilder();

            if (!getTimeResp.IsValid)
            {
                str.Append(String.Format("Error: {0}", getTimeResp.ErrorCode));
                str.Append(Environment.NewLine);
                str.Append(String.Format("Error Message: {0}", getTimeResp.ErrorMessage));
            }
            else
            {
                str.Append(String.Format("Rate Limit Remaining Requests Count: {0}", getTimeResp.RateLimitRemainingRequestsCount));
                str.Append(Environment.NewLine);

                str.Append(String.Format("Rate Limit Requests Reset Time: {0}", getTimeResp.RateLimitRequestsResetTime));
                str.Append(Environment.NewLine);

                str.Append(String.Format("Time: {0}", getTimeResp.Time));
                str.Append(Environment.NewLine);
            }

            return str.ToString();
        }

        public static string ToString(InsertOrderImpactResponse orderImpactResp)
        {
            StringBuilder str = new StringBuilder();

            if (!orderImpactResp.IsValid)
            {
                str.Append(String.Format("Error: {0}", orderImpactResp.ErrorCode));
                str.Append(Environment.NewLine);
                str.Append(String.Format("Error Message: {0}", orderImpactResp.ErrorMessage));
            }
            else
            {
                str.Append(String.Format("Rate Limit Remaining Requests Count: {0}", orderImpactResp.RateLimitRemainingRequestsCount));
                str.Append(Environment.NewLine);

                str.Append(String.Format("Rate Limit Requests Reset Time: {0}", orderImpactResp.RateLimitRequestsResetTime));
                str.Append(Environment.NewLine);

                str.Append(String.Format("\tEstimatedCommissions: {0}", orderImpactResp.EstimatedCommissions));
                str.Append(Environment.NewLine);

                str.Append(String.Format("\tBuyingPowerEffect: {0}", orderImpactResp.BuyingPowerEffect));
                str.Append(Environment.NewLine);

                str.Append(String.Format("\tBuyingPowerResult: {0}", orderImpactResp.BuyingPowerResult));
                str.Append(Environment.NewLine);

                str.Append(String.Format("\tMaintExcessEffect: {0}", orderImpactResp.MaintExcessEffect));
                str.Append(Environment.NewLine);

                str.Append(String.Format("\tMaintExcessResult: {0}", orderImpactResp.MaintExcessResult));
                str.Append(Environment.NewLine);

                str.Append(String.Format("\tSide: {0}", orderImpactResp.Side));
                str.Append(Environment.NewLine);

                str.Append(String.Format("\tTradeValueCalculation: {0}", orderImpactResp.TradeValueCalculation));
                str.Append(Environment.NewLine);

                str.Append(String.Format("\tPrice: {0}", orderImpactResp.Price));
                str.Append(Environment.NewLine);
            }

            return str.ToString();
        }

        public static string ToString(ReplaceOrderImpactResponse replaceImpactResp)
        {
            StringBuilder str = new StringBuilder();

            if (!replaceImpactResp.IsValid)
            {
                str.Append(String.Format("Error: {0}", replaceImpactResp.ErrorCode));
                str.Append(Environment.NewLine);
                str.Append(String.Format("Error Message: {0}", replaceImpactResp.ErrorMessage));
            }
            else
            {
                str.Append(String.Format("Rate Limit Remaining Requests Count: {0}", replaceImpactResp.RateLimitRemainingRequestsCount));
                str.Append(Environment.NewLine);

                str.Append(String.Format("Rate Limit Requests Reset Time: {0}", replaceImpactResp.RateLimitRequestsResetTime));
                str.Append(Environment.NewLine);

                str.Append(String.Format("\tEstimatedCommissions: {0}", replaceImpactResp.EstimatedCommissions));
                str.Append(Environment.NewLine);

                str.Append(String.Format("\tBuyingPowerEffect: {0}", replaceImpactResp.BuyingPowerEffect));
                str.Append(Environment.NewLine);

                str.Append(String.Format("\tBuyingPowerResult: {0}", replaceImpactResp.BuyingPowerResult));
                str.Append(Environment.NewLine);

                str.Append(String.Format("\tMaintExcessEffect: {0}", replaceImpactResp.MaintExcessEffect));
                str.Append(Environment.NewLine);

                str.Append(String.Format("\tMaintExcessResult: {0}", replaceImpactResp.MaintExcessResult));
                str.Append(Environment.NewLine);

                str.Append(String.Format("\tTradeValueCalculation: {0}", replaceImpactResp.TradeValueCalculation));
                str.Append(Environment.NewLine);

                str.Append(String.Format("\tPrice: {0}", replaceImpactResp.Price));
                str.Append(Environment.NewLine);
            }

            return str.ToString();
        }

        #endregion
    }
}
