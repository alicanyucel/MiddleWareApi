# Middleware
uygulamada her istekde yaz�ld��� s�rayla �al���r yap�lan �iste�i yani context nesnemizi alarak gerekli kontrol yada i�lemi yapt�ktan sonra s�radaki middleware e aktran yap�lard�r
genel kontrol i�in kullan�l�rlar.
�lk useri olu�turma
database migrtion otomatikle�tirme
exception handler
Kullanmak i�in Imiddleware interfacesini bir classa implemente edebiliriz best practice
# Filters
metot �.al��madan once authentication authorization i�lemlerinde kullan�labilir
metot sonunda cachleme yapmada
log kayd�nda
filter �e�idine g�re metodun belirli bir par�as�nda araya girip i�lemi yapar
## Filter Listesi
### IActionFilter
iki tane metoda sahip exceting ve Executed
bu metotlar eklendi�i metodun bas�nda veya sonunda �al���r context nesnemizi body okuyabilecek �ekilde bize evrir ve normalde body k�sm� kilitli gelir.