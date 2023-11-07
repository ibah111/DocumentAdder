using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentAdder.Utils;

public class NegateBinding
{
    string propertyName;
    object dataSource;
    string dataMember;
    bool formattingEnabled;
    DataSourceUpdateMode dataSourceUpdateMode;
    object nullValue;
    string formatString;
    IFormatProvider formatInfo;
    public NegateBinding(string propertyName, object dataSource, string dataMember) : this(propertyName, dataSource, dataMember, false, 0, null, string.Empty, null)
    {
    }

    public NegateBinding(string propertyName, object dataSource, string dataMember, bool formattingEnabled) : this(propertyName, dataSource, dataMember, formattingEnabled, 0, null, string.Empty, null)
    {
    }

    public NegateBinding(string propertyName, object dataSource, string dataMember, bool formattingEnabled, DataSourceUpdateMode dataSourceUpdateMode) : this(propertyName, dataSource, dataMember, formattingEnabled, dataSourceUpdateMode, null, string.Empty, null)
    {
    }

    public NegateBinding(string propertyName, object dataSource, string dataMember, bool formattingEnabled, DataSourceUpdateMode dataSourceUpdateMode, object nullValue) : this(propertyName, dataSource, dataMember, formattingEnabled, dataSourceUpdateMode, nullValue, string.Empty, null)
    {
    }

    public NegateBinding(string propertyName, object dataSource, string dataMember, bool formattingEnabled, DataSourceUpdateMode dataSourceUpdateMode, object nullValue, string formatString) : this(propertyName, dataSource, dataMember, formattingEnabled, dataSourceUpdateMode, nullValue, formatString, null)
    {
    }

    public NegateBinding(string propertyName, object dataSource, string dataMember, bool formattingEnabled, DataSourceUpdateMode dataSourceUpdateMode, object nullValue, string formatString, IFormatProvider formatInfo)
    {
        this.propertyName = propertyName;
        this.dataSource = dataSource;
        this.dataMember = dataMember;
        this.formattingEnabled = formattingEnabled;
        this.dataSourceUpdateMode = dataSourceUpdateMode;
        this.nullValue = nullValue;
        this.formatString = formatString;
        this.formatInfo = formatInfo;
    }

    public static implicit operator Binding(NegateBinding eb)
    {
        var binding = new Binding(eb.propertyName, eb.dataSource, eb.dataMember, eb.formattingEnabled, eb.dataSourceUpdateMode, eb.dataSource, eb.formatString, eb.formatInfo);
        binding.Parse += new ConvertEventHandler(negate);
        binding.Format += new ConvertEventHandler(negate);
        return binding;
    }

    static void negate(object sender, ConvertEventArgs e)
    {
        e.Value = !((bool)e.Value);
    }
}
