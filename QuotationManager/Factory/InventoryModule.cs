using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuotationManager.Factory
{
    public class Inventory
    {
        public int InventoryID { get; set; }
        public string Description { get; set; }



        public List<Inventory> GetInventoryList()
        {
            string sql = "";
            DatabaseModule dbMod = new DatabaseModule();
            List<Inventory> list = new List<Inventory>();
            SQLiteParameter[] sqlParams = new SQLiteParameter[0];
            int intVal = -1;
            try
            {
                sql = "Select InventoryID,Description from Inventory ORDER BY Description";
                DataSet ds = dbMod.FillDataSet(sql, sqlParams);
                if (ds != null && ds.Tables.Count > 0)
                {
                    Inventory inv = new Inventory();
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        inv = new Inventory();
                        intVal = -1;
                        if (dr.Table.Columns.Contains("InventoryID"))
                        {
                            Int32.TryParse(dr["InventoryID"].ToString(), out intVal);
                            inv.InventoryID = intVal;
                        }
                        if (dr.Table.Columns.Contains("Description"))
                        {
                            inv.Description = dr["Description"].ToString();
                        }
                        if (intVal != -1)
                        {
                            list.Add(inv);
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
                    sql = @"INSERT INTO [Inventory] ([Description]) VALUES (@Description)";
                }
                else
                {
                    sql = @"UPDATE [Inventory] SET [Description] = @Description
                           InventoryID = @InventoryID";

                    value = InventoryID;
                    sqlParams[paramCC] = new SQLiteParameter("@InventoryID", value);
                    paramCC += 1;
                }
                sqlParams[paramCC] = new SQLiteParameter("@Description", Description);
                paramCC += 1;
                nExecute = dbMod.ExecuteNonQuery(sql, sqlParams);

            }
            catch (Exception ex)
            {

                throw ex;
            }

            return nExecute;

        }
    }

    public class InventoryItem
    {
        public int InventoryItemID { get; set; }
        public int InventoryID { get; set; }
        public int ParentInventoryItemID { get; set; }
        public int LevelIndex { get; set; }
        public string Description { get; set; }

        public bool IsItem { get; set; }
        public string Unit { get; set; }
        public decimal Price { get; set; }
        public decimal MarkupPercentage { get; set; }
        public decimal ArtePercentage { get; set; }


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
                    sql = @"INSERT INTO [InventoryItems] ([InventoryID],[ParentInventoryItemID],[LevelIndex],[Description],[IsItem],[Unit],[Price],[MarkupPercentage],[ArtePercentage]) 
                            VALUES (@InventoryID,@ParentInventoryItemID,@LevelIndex,@Description,@IsItem,@Unit,@Price,@MarkupPercentage,@ArtePercentage)";
                }
                else
                {
                    sql = @"Update  [InventoryItems] Set [InventoryID] = @InventoryID,[ParentInventoryItemID] = @ParentInventoryItemID,[LevelIndex] = @LevelIndex,[Description] = @Description,[IsItem] = @IsItem,[Unit] = @Unit,[Price] = @Price,[MarkupPercentage] = @MarkupPercentage,[ArtePercentage]= @ArtePercentage 
                           where InventoryItemID = @InventoryItemID";

                    value = InventoryItemID;
                    sqlParams[paramCC] = new SQLiteParameter("@InventoryItemID", value);
                    paramCC += 1;
                }


                value = InventoryID;
                sqlParams[paramCC] = new SQLiteParameter("@InventoryID", value);
                paramCC += 1;


                value = ParentInventoryItemID;
                sqlParams[paramCC] = new SQLiteParameter("@ParentInventoryItemID", value);
                paramCC += 1;

                value = LevelIndex;
                sqlParams[paramCC] = new SQLiteParameter("@LevelIndex", value);
                paramCC += 1;


                value = Description;
                sqlParams[paramCC] = new SQLiteParameter("@Description", value);
                paramCC += 1;

                value = IsItem;
                sqlParams[paramCC] = new SQLiteParameter("@IsItem", value);
                paramCC += 1;

                value = Unit;
                sqlParams[paramCC] = new SQLiteParameter("@Unit", value);
                paramCC += 1;

                value = Price;
                sqlParams[paramCC] = new SQLiteParameter("@Price", value);
                paramCC += 1;

                value = MarkupPercentage;
                sqlParams[paramCC] = new SQLiteParameter("@MarkupPercentage", value);
                paramCC += 1;

                value = ArtePercentage;
                sqlParams[paramCC] = new SQLiteParameter("@ArtePercentage", value);
                paramCC += 1;


                nExecute = dbMod.ExecuteNonQuery(sql, sqlParams);

            }
            catch (Exception ex)
            {

                throw ex;
            }

            return nExecute;
        }

        public  int Delete()
        {
            int nExecute = 0;
            string sql = "";
            object value = "";
            try
            {
                DatabaseModule dbMod = new DatabaseModule();
                SQLiteParameter[] sqlParams = new SQLiteParameter[10];
                int paramCC = 0;

                sql = @"Delete from InventoryItems WHERE InventoryItemID = @InventoryItemID";

                value = InventoryItemID;
                sqlParams[paramCC] = new SQLiteParameter("@InventoryItemID", value);

                nExecute = dbMod.ExecuteNonQuery(sql, sqlParams);

            }
            catch (Exception ex)
            {

                throw ex;
            }

            return nExecute;
        }

        public int getLastInventoryItemCount()
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

                sql = @"SELECT MAX(InventoryItemID) from InventoryItems";

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

        public static List<InventoryItem> GetInventoryItems(int inventoryID)
        {
            string sql = "";
            DatabaseModule dbMod = new DatabaseModule();
            InventoryItem inv = new InventoryItem();
            List<InventoryItem> invItems = new List<InventoryItem>();
            SQLiteParameter[] sqlParams = new SQLiteParameter[1];
            int intVal = -1;
            decimal decVal = -1;
            bool boolVal = false;
            try
            {
                sql = "Select InventoryItemID,InventoryID,ParentInventoryItemID,LevelIndex,Description,IsItem,Unit,Price,MarkupPercentage,ArtePercentage from InventoryItems WHERE InventoryID = @InventoryID "; //
                sqlParams[0] = new SQLiteParameter("@InventoryID", inventoryID);

                DataSet ds = dbMod.FillDataSet(sql, sqlParams);
                if (ds != null && ds.Tables.Count > 0)
                {

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        inv = new InventoryItem();
                        intVal = -1;

                        Int32.TryParse(dr["InventoryItemID"].ToString(), out intVal);
                        inv.InventoryItemID = intVal;
                        Int32.TryParse(dr["InventoryID"].ToString(), out intVal);
                        inv.InventoryID = intVal;
                        Int32.TryParse(dr["ParentInventoryItemID"].ToString(), out intVal);
                        inv.ParentInventoryItemID = intVal;
                        inv.Description = dr["Description"].ToString();
                        Boolean.TryParse(dr["IsItem"].ToString(), out boolVal);
                        inv.IsItem = boolVal;
                        inv.Unit = dr["Unit"].ToString();
                        Decimal.TryParse(dr["Price"].ToString(), out decVal);
                        inv.Price = decVal;
                        Decimal.TryParse(dr["MarkupPercentage"].ToString(), out decVal);
                        inv.MarkupPercentage = decVal;
                        Decimal.TryParse(dr["ArtePercentage"].ToString(), out decVal);
                        inv.ArtePercentage = decVal;
                        Int32.TryParse(dr["LevelIndex"].ToString(), out intVal);
                        inv.LevelIndex = intVal;
                        if (intVal != -1)
                        {
                            invItems.Add(inv);

                        }
                    }
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return invItems;

        }
    }
}
