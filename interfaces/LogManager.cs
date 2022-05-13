
public class LogManager : ILogger
{
    // ILogger sinifinin referansı yaratildi // interfaceler new ile yaratilamaz, nesnesi olusturulamaz cunku tek baslarina anlamli degildirler. Referans alabilirler. Interface den türeyen siniflarin nesneleri interface referansi olarak verilebilir. LogManager kurucusuna disaridan ...Logger siniflarinin nesneleri verilebilir
    public ILogger _logger;
    public LogManager(ILogger logger) // parametresi interface tipinde bir nesne olsun
    {
        _logger = logger;
    }

    public void WriteLog()
    {
        _logger.WriteLog();
    }
}

// bu sinif hangi log sinifinin cagrilacagini bilmiyor yalnizca bir yonetim islemi yapiyor. Gelen ILogger dan tureyen nesnenin WriteLog unu calistiriyor