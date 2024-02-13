#nullable enable
using CommunityToolkit.Mvvm.ComponentModel;

namespace DocumentAdder.Models;

public partial class FileData : ObservableObject
{
    public FileData(byte[] data, string? name = null, int? typ = null)
    {
        this.Data = data;
        this.Name = name;
        this.Typ = typ;
    }
    [ObservableProperty]
    private byte[] data;
    [ObservableProperty]
    private string? name;
    [ObservableProperty]
    private int? typ;
    [ObservableProperty]
    private bool _needBarcode;
}
