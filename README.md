# TradeLog-Portfolio

# Használat
 1.  -Első futtatás előtt, opcionális az alkalmazáshoz egy mysql elérés ,amely konfigurálása az app.config-ban elérhető(ConnectionString).
 1.1 -MySQL hiánya esetén az alkalmazás lokálisan XML-be végzi el az adattárolást.
 2.1 - Fiók regisztráláshoz az alkalmazás indítás utáni felületen egy opció válik segítségünkre (for now users).
 2.2 - Bejelentkezéshez a main windows valósítja meg a logint.
 3.1 - Bejelentkezés után az adatok jegyezhetők.

#Mysql - Szerver oldal.
A fő könnyvtárban megtalálható a "create_mysql_query.sql" amely előállítja a szükséges adatbázik struktúrát, majd a desktop alkalmazásban configurálható a connection string.

#ConnectionString
-server=localhost;userid=admin;database=tradelog;password=admin;

#Belső configurálás után kiosztható az alkalmazás.

#v1.61 log
	-
#Package NUGET MYSQL.DATA V8.0.21.
