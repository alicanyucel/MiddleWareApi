# Middleware
uygulamada her istekde yazýldýðý sýrayla çalýþýr yapýlan þisteði yani context nesnemizi alarak gerekli kontrol yada iþlemi yaptýktan sonra sýradaki middleware e aktran yapýlardýr
genel kontrol için kullanýlýrlar.
ýlk useri oluþturma
database migrtion otomatikleþtirme
exception handler
Kullanmak için Imiddleware interfacesini bir classa implemente edebiliriz best practice
# Filters
metot ç.alýþmadan once authentication authorization iþlemlerinde kullanýlabilir
metot sonunda cachleme yapmada
log kaydýnda
filter çeþidine göre metodun belirli bir parçasýnda araya girip iþlemi yapar
## Filter Listesi
### IActionFilter
iki tane metoda sahip exceting ve Executed
bu metotlar eklendiði metodun basýnda veya sonunda çalýþýr context nesnemizi body okuyabilecek þekilde bize evrir ve normalde body kýsmý kilitli gelir.