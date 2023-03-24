using System.Data;
using DAL;
using MODEL;
namespace SQL
{
    public class ProductItTypeSql: BasSql
    {
        public ProductItTypeSql()
        {
        }

        public List<ProductItType> getAllProductItTypeSql()
        {
            string stringSql = "EXEC getAllProductItType";
            DataTable table = new DataTable();
            connectToSql.RunCommand(stringSql, table.Load);
            return convertToList(table);
        }
        public List<ProductItType> getAllProductItTypeCountSql()
        {
            string stringSql = "EXEC getAllProductItTypeCount";
            DataTable table = new DataTable();
            connectToSql.RunCommand(stringSql, table.Load);
            return convertToList(table);
        }
        public List<ProductItType> convertToList(DataTable table)
        {
            List<ProductItType> list = new List<ProductItType>();
            foreach (DataRow Row in table.Rows)
            {
                ProductItType p = new ProductItType();
                p.ProductType = (string)Row["ProductTypeName"];
                p.ProductTypeCount = (int)Row["CountProductTypeName"];
                list.Add(p);
            }
            return list;
        }
    }
}
