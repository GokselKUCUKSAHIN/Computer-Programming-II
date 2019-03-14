SELECT * FROM Siparisler
SELECT UrunKodu, SipAdet FROM Siparisler
SELECT UrunKodu, SipAdet FROM Siparisler WHERE MusNo =1 AND UrunKodu='U002'
SELECT UrunAdi, Urunler.UrunKodu, SipAdet FROM Siparisler

INNER JOIN Urunler
ON Urunler.UrunKodu = Siparisler.UrunKodu


SELECT UrunAdi,Urunler.UrunKodu , SipAdet FROM Siparisler,Urunler
WHERE Urunler.UrunKodu=Siparisler.UrunKodu

SELECT UrunKodu, SUM(SipAdet) FROM Siparisler GROUP BY UrunKodu

/*
sum: gruplanan sutundaki verilerin toplamı
avg: gruplanan sutundaki verilerin ortalaması
min: gruplanan sutundaki verilerin minimumu
max: gruplanan sutundaki verilerin maximimu
count: gruplanan sutundaki verilerin sayısı
*/


SELECT MusNo, COUNT(MusNo) FROM Siparisler GROUP BY MusNo

SELECT MusNo, AVG(MusNo) AS Ortalama FROM Siparisler group by MusNo

SELECT MusNo, SUM(SipAdet*Fiyati) AS Toplam FROM Siparisler
INNER JOIN Urunler
ON Urunler.UrunKodu = Siparisler.UrunKodu
GROUP BY MusNo
HAVING SUM(SipAdet*Fiyati)>200
ORDER BY Toplam DESC

INSERT INTO Musteriler VALUES ('Gamze', 'Genc','789456123','Kırsehir')
INSERT INTO Musteriler(Adi,Soyadi) VALUES ('Ali Batu', 'Akay')


UPDATE Musteriler SET Telefon = '123456789213' WHERE Adi='Gamze' AND Soyadi='Genc' 

UPDATE Urunler SET Stok = Stok-5 WHERE UrunKodu='U001'




