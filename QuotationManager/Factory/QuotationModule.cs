using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuotationManager.Factory
{
    public class Quotation
    {
        public int QuotationID { get; set; }

        public string Description { get; set; }

        public DateTime CreationDate { get; set; }

        public static int GetLastQuoteNo()
        {
            object nQuoteObj = 0;
            int nQuote = 0;
            string sql = "";
            object value = "";
            try
            {
                DatabaseModule dbMod = new DatabaseModule();
                SQLiteParameter[] sqlParams = new SQLiteParameter[1];
                int paramCC = 0;

                sql = @"SELECT MAX(QuotationID) from Quotation";
                paramCC += 1;
                nQuoteObj = dbMod.ExecuteScalar(sql, sqlParams);

                Int32.TryParse(nQuoteObj.ToString(), out nQuote);


            }
            catch (Exception ex)
            {

                throw ex;
            }

            return nQuote;
        }

        public List<Quotation> GetQuoteList()
        {
            string sql = "";
            DatabaseModule dbMod = new DatabaseModule();
            List<Quotation> list = new List<Quotation>();
            SQLiteParameter[] sqlParams = new SQLiteParameter[0];
            int intVal = -1;
            DateTime dateVal = new DateTime();
            try
            {
                sql = "Select QuotationID,Description,CreationDate from Quotation ORDER BY Description";
                DataSet ds = dbMod.FillDataSet(sql, sqlParams);
                if (ds != null && ds.Tables.Count > 0)
                {
                    Quotation quote = new Quotation();
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        quote = new Quotation();
                        intVal = -1;
                        if (dr.Table.Columns.Contains("QuotationID"))
                        {
                            Int32.TryParse(dr["QuotationID"].ToString(), out intVal);
                            quote.QuotationID = intVal;
                        }
                        if (dr.Table.Columns.Contains("Description"))
                        {
                            quote.Description = dr["Description"].ToString();
                        }

                        dateVal = new DateTime();
                        if (dr.Table.Columns.Contains("CreationDate"))
                        {
                            DateTime.TryParse(dr["CreationDate"].ToString(), out dateVal);
                            quote.CreationDate = dateVal;
                        }

                        if (intVal != -1)
                        {
                            list.Add(quote);
                        }
                    }
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return list;

        }

        public int Save(bool isNew)
        {
            int nExecute = 0;
            string sql = "";
            object value = "";
            try
            {
                DatabaseModule dbMod = new DatabaseModule();
                SQLiteParameter[] sqlParams = new SQLiteParameter[10];
                int paramCC = 0;

                if (isNew)
                {
                    sql = @"INSERT INTO [Quotation] ([Description],[CreationDate]) VALUES (@Description,@CreationDate)";
                }
                else
                {
                    sql = @"UPDATE [Quotation] SET [Description] = @Description, [CreationDate] = @CreationDate
                           QuotationID = @QuotationID";

                    value = QuotationID;
                    sqlParams[paramCC] = new SQLiteParameter("@QuotationID", value);
                    paramCC += 1;
                }
                sqlParams[paramCC] = new SQLiteParameter("@Description", Description);
                paramCC += 1;
                sqlParams[paramCC] = new SQLiteParameter("@CreationDate", DateTime.Now);

                nExecute = dbMod.ExecuteNonQuery(sql, sqlParams);

            }
            catch (Exception ex)
            {

                throw ex;
            }

            return nExecute;

        }

    }


    public class QuotationDetail
    {
        public int QuotationDetailID { get; set; }

        public int QuotationID { get; set; }

        public int LevelIndex { get; set; }

        public string Description { get; set; }

        public bool IsItem { get; set; }

        public string Unit { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public decimal Total { get; set; }

        public decimal MarkupPercentage { get; set; }

        public decimal MarkupValue { get; set; }

        public decimal GrossPrice { get; set; }

        public decimal ArtePercentage { get; set; }

        public decimal ArteValue { get; set; }

        public decimal TotalValue { get; set; }

        public int QuoteOrder { get; set; }

        public static int  getLastQuoteDetailCount()
        {
            object nCountObj = 0;
            int nCount = 0;
            string sql = "";
            object value = "";
            try
            {
                DatabaseModule dbMod = new DatabaseModule();
                SQLiteParameter[] sqlParams = new SQLiteParameter[1];
                int paramCC = 0;

                sql = @"SELECT MAX(QuotationDetailID) from QuotationDetail";

                //sqlParams[paramCC] = new SQLiteParameter("@Description", Description);
                paramCC += 1;
                nCountObj = dbMod.ExecuteScalar(sql, sqlParams);

                Int32.TryParse(nCountObj.ToString(), out nCount);

            }
            catch (Exception ex)
            {

                throw ex;
            }

            return nCount;

        }

        public static List<QuotationDetail> GetQuoteList(int QuotationID)
        {
            string sql = "";
            DatabaseModule dbMod = new DatabaseModule();
            List<QuotationDetail> list = new List<QuotationDetail>();
            SQLiteParameter[] sqlParams = new SQLiteParameter[1];
            int intVal = -1;
            bool boolVal = false;
            decimal decVal = 0;
            int paramCC = 0;

            try
            {
                sql = @"Select 
                         QuotationDetailID,QuotationID,LevelIndex,Description,IsItem,Unit,Quantity,Price             
                         Total, MarkupPercentage, MarkupValue,GrossPrice,ArtePercentage,ArteValue,TotalValue,QuoteOrder 
                    from QuotationDetail Where QuotationID = @QuotationID Order by QuoteOrder";
                sqlParams[paramCC] = new SQLiteParameter("@QuotationID", QuotationID);
                paramCC += 1;

                DataSet ds = dbMod.FillDataSet(sql, sqlParams);
                if (ds != null && ds.Tables.Count > 0)
                {
                    QuotationDetail quote = new QuotationDetail();
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        quote = new QuotationDetail();
                        intVal = -1;
                        if (dr.Table.Columns.Contains("QuotationDetailID"))
                        {
                            Int32.TryParse(dr["QuotationDetailID"].ToString(), out intVal);
                            quote.QuotationDetailID = intVal;
                        }
                        if (dr.Table.Columns.Contains("QuotationID"))
                        {
                            Int32.TryParse(dr["QuotationID"].ToString(), out intVal);
                            quote.QuotationID = intVal;
                        }
                        if (dr.Table.Columns.Contains("LevelIndex"))
                        {
                            Int32.TryParse(dr["LevelIndex"].ToString(), out intVal);
                            quote.LevelIndex = intVal;
                        }
                        if (dr.Table.Columns.Contains("Description"))
                        {
                            quote.Description = dr["Description"].ToString();
                        }
                        if (dr.Table.Columns.Contains("IsItem"))
                        {
                            Boolean.TryParse(dr["IsItem"].ToString(), out boolVal);
                            quote.IsItem = boolVal;
                        }
                        if (dr.Table.Columns.Contains("Unit"))
                        {
                            quote.Unit = dr["Unit"].ToString();
                        }
                        if (dr.Table.Columns.Contains("Quantity"))
                        {
                            Int32.TryParse(dr["Quantity"].ToString(), out intVal);
                            quote.Quantity = intVal;
                        }
                        if (dr.Table.Columns.Contains("Price"))
                        {
                            Decimal.TryParse(dr["Price"].ToString(), out decVal);
                            quote.Price = decVal;
                        }
                        if (dr.Table.Columns.Contains("Total"))
                        {
                            Decimal.TryParse(dr["Total"].ToString(), out decVal);
                            quote.Total = decVal;
                        }
                        if (dr.Table.Columns.Contains("MarkupPercentage"))
                        {
                            Decimal.TryParse(dr["MarkupPercentage"].ToString(), out decVal);
                            quote.MarkupPercentage = decVal;
                        }
                        if (dr.Table.Columns.Contains("MarkupValue"))
                        {
                            Decimal.TryParse(dr["MarkupValue"].ToString(), out decVal);
                            quote.MarkupValue = decVal;
                        }
                        if (dr.Table.Columns.Contains("GrossPrice"))
                        {
                            Decimal.TryParse(dr["GrossPrice"].ToString(), out decVal);
                            quote.GrossPrice = decVal;
                        }
                        if (dr.Table.Columns.Contains("ArtePercentage"))
                        {
                            Decimal.TryParse(dr["ArtePercentage"].ToString(), out decVal);
                            quote.ArtePercentage = decVal;
                        }
                        if (dr.Table.Columns.Contains("ArteValue"))
                        {
                            Decimal.TryParse(dr["ArteValue"].ToString(), out decVal);
                            quote.ArteValue = decVal;
                        }
                        if (dr.Table.Columns.Contains("TotalValue"))
                        {
                            Decimal.TryParse(dr["TotalValue"].ToString(), out decVal);
                            quote.TotalValue = decVal;
                        }
                        if (dr.Table.Columns.Contains("QuoteOrder"))
                        {
                            Int32.TryParse(dr["QuoteOrder"].ToString(), out intVal);
                            quote.QuoteOrder = intVal;
                        }

                        if (intVal != -1)
                        {
                            list.Add(quote);
                        }

                    }



             
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return list;

        }

        public static int Delete(int quotationID, bool useDBMod, DatabaseModule dataMod)
        {
            int nExecute = 0;
            string sql = "";
            object value = "";
            try
            {
                DatabaseModule dbMod = new DatabaseModule();
                if (useDBMod)
                {
                    dbMod = dataMod;
                }
                SQLiteParameter[] sqlParams = new SQLiteParameter[10];
                int paramCC = 0;

                sql = @"Delete from QuotationDetail WHERE QuotationID = @QuotationID";

                value = quotationID;
                sqlParams[paramCC] = new SQLiteParameter("@QuotationID", value);

                nExecute = dbMod.ExecuteNonQuery(sql, sqlParams);

            }
            catch (Exception ex)
            {

                throw ex;
            }

            return nExecute;
        }


        public int Save(bool isNew,bool useDBMod, DatabaseModule dataMod)
        {
            int nExecute = 0;
            string sql = "";
            object value = "";
            try
            {
                DatabaseModule dbMod = new DatabaseModule();
                if (useDBMod)
                {
                    dbMod = dataMod;
                }
                SQLiteParameter[] sqlParams = new SQLiteParameter[20];
                int paramCC = 0;

                if (isNew)
                {
                    sql = @"INSERT INTO QuotationDetail
                            (QuotationDetailID,QuotationID,LevelIndex,Description     
                            ,IsItem,Unit,Quantity,Price,Total           
                            ,MarkupPercentage,MarkupValue,GrossPrice,ArtePercentage  
                            ,ArteValue,TotalValue,QuoteOrder)  
                            VALUES
                            (@QuotationDetailID,@QuotationID,@LevelIndex,@Description     
	                         ,@IsItem,@Unit,@Quantity,@Price,@Total           
	                         ,@MarkupPercentage,@MarkupValue,@GrossPrice,@ArtePercentage  
	                         ,@ArteValue,@TotalValue,@QuoteOrder)";
                }

                sqlParams[paramCC] = new SQLiteParameter("@QuotationDetailID", QuotationDetailID);
                paramCC += 1;
                sqlParams[paramCC] = new SQLiteParameter("@QuotationID", QuotationID);
                paramCC += 1;
                sqlParams[paramCC] = new SQLiteParameter("@LevelIndex", LevelIndex);
                paramCC += 1;
                sqlParams[paramCC] = new SQLiteParameter("@Description", Description);
                paramCC += 1;
                sqlParams[paramCC] = new SQLiteParameter("@IsItem", IsItem?1:0);
                paramCC += 1;
                sqlParams[paramCC] = new SQLiteParameter("@Unit", Unit);
                paramCC += 1;
                sqlParams[paramCC] = new SQLiteParameter("@Quantity", Quantity);
                paramCC += 1;
                sqlParams[paramCC] = new SQLiteParameter("@Price", Price);
                paramCC += 1;
                sqlParams[paramCC] = new SQLiteParameter("@Total", Total);
                paramCC += 1;
                sqlParams[paramCC] = new SQLiteParameter("@MarkupPercentage", MarkupPercentage);
                paramCC += 1;
                sqlParams[paramCC] = new SQLiteParameter("@MarkupValue", MarkupValue);
                paramCC += 1;
                sqlParams[paramCC] = new SQLiteParameter("@GrossPrice", GrossPrice);
                paramCC += 1;
                sqlParams[paramCC] = new SQLiteParameter("@ArtePercentage", ArtePercentage);
                paramCC += 1;
                sqlParams[paramCC] = new SQLiteParameter("@ArteValue", ArteValue);
                paramCC += 1;
                sqlParams[paramCC] = new SQLiteParameter("@TotalValue", TotalValue);
                paramCC += 1;
                sqlParams[paramCC] = new SQLiteParameter("@QuoteOrder", QuoteOrder);

                nExecute = dbMod.ExecuteNonQuery(sql, sqlParams);

            }
            catch (Exception ex)
            {

                throw ex;
            }

            return nExecute;

        }
    }
}
