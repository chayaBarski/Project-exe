using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;
using MODEL;
using SQL;
using System.Data;
namespace ENTITES
{
    public class ProductItTypeEntites : BaseEntites
    { 
        public ProductItTypeEntites()
        {

        }
        public List<ProductItType> getAllProductItType()
        {
            ProductItTypeSql p = new ProductItTypeSql();
            return p.getAllProductItTypeSql();
        }
        public List<ProductItType> getAllProductItTypeCount()
        {
            ProductItTypeSql p = new ProductItTypeSql();
            return p.getAllProductItTypeCountSql();
        }

    }
}
