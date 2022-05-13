// See https://aka.ms/new-console-template for more information



// Bir ana sınıf ve bir interface yaratilacak. Ondan tureyen log yazma isini farklı bcimlerde yapan birden fazla sinifa implemente edilecek


// classlarin nesneleri olusturulur. default constructor arkada calisacak

FileLogger fileLogger = new FileLogger();
fileLogger.WriteLog();

DatabaseLogger databaseLogger = new DatabaseLogger();
databaseLogger.WriteLog();

SmsLogger smsLogger = new();
smsLogger.WriteLog();

/// log yazma islemini hangi log sinifini yaratilacagini hangi log sinifinin metotunun cagrilacagini belirleyen bir log manager yazilmak istenmekte yalnizca o implemente edilmek istenmekte
// FileManager yazildiktan sonra cagirma islemi

LogManager logManager = new LogManager(new FileLogger());
logManager.WriteLog();
// instance si yaratilmis olan ILoggerdan tureyen sinifin WriteLog metotunu cagirmis olduk arka planda LogManager bundan soyutlanmis oldu
