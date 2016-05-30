using System;
using System.Web;

public class StringWrapper {

    public string Value { get; set; }
        
    public HtmlString ValueAsHtml {
        get { return new HtmlString(Value ?? ""); }
    }

    public bool IsEmpty {
        get { return Value == ""; }
    }

    public bool IsNullOrEmpty {
        get { return String.IsNullOrEmpty(Value); }
    }

    public bool IsNullOrWhiteSpace {
        get { return String.IsNullOrWhiteSpace(Value); }
    }

    public bool IsNotNullOrWhiteSpace {
        get { return !String.IsNullOrWhiteSpace(Value); }
    }

    public bool HasValue {
        get { return !String.IsNullOrWhiteSpace(Value); }
    }

    public int Length {
        get { return Value == null ? 0 : Value.Length; }
    }

    public StringWrapper() {
        // Default constructor
    }

    public StringWrapper(string value) {
        Value = value;
    }

    public override string ToString() {
        return Value;
    }


    public HtmlString ToHtmlString() {
        return new HtmlString(Value ?? "");
    }

}