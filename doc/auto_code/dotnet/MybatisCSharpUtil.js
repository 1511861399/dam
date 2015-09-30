<script runat="template">
 


//获取oracle在mybatis中的javatype
public string GetOracleCSharpType(ColumnSchema column)
{
    string type=GetOracleMemberType(column).ToUpper();
    switch(type)
    {
        case "BIT":
            return "bool";
        case "TINYINT":
            return "byte";
        case "SMALLINT":
            return "short";
        case "DOUBLE":
            return "double";
        case "INT":
            return "int";
        case "BIGINT":
            return "long";
        case "REAL":
            return "float";
        case "FLOAT":
            return "double";
        case "MONEY":
            return "decimal";
        case "DATETIME":
            return "DateTime";
        case "VARCHAR":
            return "string";
        case "CHAR":
            return "string";
        case "NCHAR":
            return "string";
        case "NVARCHAR":
            return "string";
        case "NTEXT":
            return "string";
        case "IMAGE":
            return "byte[]";
        case "BINARY":
            return "byte[]";
        case "TIMESTAMP":
            return "DateTime";
        case "DATE":
            return "DateTime";
         case "TEXT":
            return "string";
        default:
            return column.DataType.ToString();
    }
}

//获取oracle在mybatis中的javatype
public string GetOracleCSharpType2(string type1)
{
    string type=type1.ToUpper();
    switch(type)
    {
        case "BIT":
            return "bool";
        case "TINYINT":
            return "byte";
        case "SMALLINT":
            return "short";
        case "DOUBLE":
            return "double";
        case "INT":
            return "int";
        case "BIGINT":
            return "long";
        case "REAL":
            return "float";
        case "FLOAT":
            return "double";
        case "MONEY":
            return "decimal";
        case "DATETIME":
            return "DateTime";
        case "VARCHAR":
            return "string";
        case "CHAR":
            return "string";
        case "NCHAR":
            return "string";
        case "NVARCHAR":
            return "string";
        case "NTEXT":
            return "string";
        case "IMAGE":
            return "byte[]";
        case "BINARY":
            return "byte[]";
        case "TIMESTAMP":
            return "DateTime";
        case "DATE":
            return "DateTime";
         case "TEXT":
            return "string";
        default:
            return type1;
    }
}

//将oracle的NativeType进行转换
public string GetOracleMemberType(ColumnSchema column)
{   
    string type=column.NativeType;
    switch (type) 
	{ 
	     case "NUMBER":
             int precision=column.Precision;
             int scale=column.Scale;
             if(scale>0)
             {
                return "DOUBLE";
             }
             else if(precision<=32)
             {
               return "INT";
             }
             else
             {
                return "INT64";
             }
         case "VARCHAR":
             return "VARCHAR";
         case "TIMESTAMP":
             return "TIMESTAMP";
         case "DATE":
             return "DATETIME";
         default:
            return GetSpecifialType(column); 
	} 
}

//获取各个类型进行过滤的模板
public string GetSpecificationString(ColumnSchema column)
{
    string type=GetOracleMemberType(column);
    switch(type)
    {
        case "DOUBLE":
            return column.Name+"!=null and "+column.Name+" &gt; 0";
        case "INT32":
            return column.Name+"!=null and "+column.Name+" &gt; 0";
        case "INT64":
            return column.Name+"!=null and "+column.Name+" &gt; 0";
        case "VARCHAR2":
            return column.Name+"!=null and "+column.Name+" != ''";
        case "TIMESTAMP":
            return column.Name+"!=null";
        case "DATE":
            return column.Name+"!=null";
        default:
            return column.Name+"!=null";
    }
}

//获取各个类型查询语句
public string GetOracleQueryString(ColumnSchema column)
{
    
    string type=GetOracleMemberType(column);
    switch(type)
    {
        case "DOUBLE": 
            return BuildCommonQuery(column);
        case "INT32":
            return BuildCommonQuery(column);
        case "INT64":
           return BuildCommonQuery(column);
        case "VARCHAR2":
            return BuildStringQuery(column); 
        case "TIMESTAMP":
            return BuildDateQuery(column); 
        case "DATE": 
            return BuildDateQuery(column);
        default:
            return BuildCommonQuery(column);
    } 
}
public string BuildCommonQuery(ColumnSchema column)
{
    StringBuilder builder=new StringBuilder();  
    builder.Append("<if test=\"").Append(GetSpecificationString(column)).Append("\">");
    builder.Append("\r").Append("\t\t\t\t").Append("AND ");
    builder.Append(column.Name).Append(" = ").Append("#{").Append(column.Name).Append(",dbType=").Append(column.DataType).Append("}\r\t\t\t</if>");
    return builder.ToString();
}

public string BuildDateQuery(ColumnSchema column)
{
    StringBuilder builder=new StringBuilder();  
    builder.Append("<if test=\"BEGIN_").Append(column.Name).Append("!=null\">");
    builder.Append("\r").Append("\t\t\t\t").Append("AND ");
    builder.Append(column.Name).Append(" &gt;= ").Append("#{BEGIN_").Append(column.Name).Append(",dbType=").Append(column.DataType).Append("}\r\t\t\t</if>");
    builder.Append("\r\t\t\t");
    builder.Append("<if test=\"END_").Append(column.Name).Append("!=null\">");
    builder.Append("\r").Append("\t\t\t\t").Append("AND ");
    builder.Append(column.Name).Append(" &lt;= ").Append("#{END_").Append(column.Name).Append(",dbType=").Append(column.DataType).Append("}\r\t\t\t</if>");
    return builder.ToString();
}

public string BuildStringQuery(ColumnSchema column)
{
    StringBuilder builder=new StringBuilder();  
    builder.Append("<if test=\"").Append(GetSpecificationString(column)).Append("\">");
    builder.Append("\r").Append("\t\t\t\t").Append("AND ");
    builder.Append("INSTR(").Append(column.Name).Append(",").Append("#{").Append(column.Name).Append(",dbType=").Append(column.DataType).Append("}) &gt; 0\r\t\t\t</if>");
    return builder.ToString();
}





public string BuildTran(ColumnSchema column)
{
    string type=GetOracleMemberType(column);
    switch(type)
    { 
        case "TIMESTAMP":
            return BuildDateTran(column); 
        case "DATE": 
            return BuildDateTran(column);
        default:
            return GetOracleCSharpType(column) + " "+ column.Name+";"; 
    } 
    
}

public string BuildDateTran(ColumnSchema column)
{
    StringBuilder builder=new StringBuilder();   
    builder.Append(GetOracleCSharpType(column)).Append(" ").Append("BEGIN_").Append(column.Name).Append(" = DateTime.Now.AddDays(-7);");
    builder.Append("\r\t\t\t/**").Append("\r\t\t\t*").Append("\r\t\t\t*/");
    builder.Append("\r\t\t\t");
    builder.Append("public ").Append(GetOracleCSharpType(column)).Append(" END_").Append(column.Name).Append(" = DateTime.Now;");
    return builder.ToString();
}


public string GetInsertValue(ColumnSchema column)
{
    string type=GetOracleMemberType(column);
    switch(type)
    {
        case "DOUBLE": 
            return "2.0";
        case "INT32":
            return "2";
        case "INT64":
           return "2";
        case "VARCHAR2":
            return "\"this is a insert test\"";
        case "TIMESTAMP":
            return "DateTime.Now";
        case "DATE": 
            return "DateTime.Now";
        default:
            return null;
    } 
}

public string GetUpdateValue(ColumnSchema column)
{
    string type=GetOracleMemberType(column);
    switch(type)
    {
        case "DOUBLE": 
            return "3.0";
        case "INT32":
            return "3";
        case "INT64":
           return "2";
        case "VARCHAR2":
            return "\"this is a update test\"";
        case "TIMESTAMP":
            return "DateTime.Now";
        case "DATE": 
            return "DateTime.Now";
        default:
            return null;
    } 
} 

public string GetSpecifialType(ColumnSchema column)
{
    DbType type=column.DataType;
    if(type==DbType.Date||type==DbType.DateTime)
    {
        if(column.Scale>0)
        {
            return "TIMESTAMP";
        }
    } 
    return "UNKNOW";
}


</script>