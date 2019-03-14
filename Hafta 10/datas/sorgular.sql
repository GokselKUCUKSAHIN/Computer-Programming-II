select * from Notlar 
select OgrNo,Vize,Final from Notlar 
select OgrNo,Vize,Final from Notlar where Vize>50
select OgrNo,Vize,Final from Notlar where Vize>50 and DersKodu='BZ101'
select OgrNo,Vize,Final,(Vize*0.4+Final*0.6) as Ortalama  from Notlar 
where (Vize*0.4+Final*0.6)>50 order by Ortalama asc
/*asc:ascending, artan
desc:descending,azalan*/
select OgrNo, count(Final) from Notlar group by OgrNo
/*
sum:alt gruplarin belirtilen kolon uzerinde toplami
max:alt gruplarin belirtilen kolon uzerinden maximumu
min:alt gruplarin belirtilen kolon uzerinden minimumu
avg:max:alt gruplarin belirtilen kolondaki datalarinin ortalaması
count:alt gruplarin icindeki satır sayısı
*/

select DersKodu,avg(Final) as Ort from Notlar group by DersKodu having avg(Final) >60

select Notlar.OgrNo,Adi,Soyadi,Notlar.DersKodu, DersAdi,Vize,Final from Notlar
inner join Ogrenciler
on Ogrenciler.OgrNo=Notlar.OgrNo
inner join Dersler
on Dersler.DersKodu=Notlar.DersKodu

select Notlar.OgrNo,Adi,Soyadi,Notlar.DersKodu, DersAdi,Vize,Final
from Notlar,Dersler,Ogrenciler
where Ogrenciler.OgrNo=Notlar.OgrNo and Dersler.DersKodu=Notlar.DersKodu

select Notlar.OgrNo,Adi,Soyadi,Notlar.DersKodu, DersAdi,Vize,Final,(Vize*0.4+Final*0.6)
from Notlar
inner join Ogrenciler
on Ogrenciler.OgrNo=Notlar.OgrNo
inner join Dersler
on Dersler.DersKodu=Notlar.DersKodu

select DersAdi,avg(Vize*0.4+Final*0.6)
from Notlar
inner join Dersler
on Dersler.DersKodu=Notlar.DersKodu
group by DersAdi
having avg(Vize*0.4+Final*0.6)>50

insert into Notlar values (5000,'BZ401',50,60);

insert into Notlar values (6000,'BZ401',50,60);
/*Foreign key ihlali*/


insert into Notlar values (5000,'BZ408',50,60);/*Foreign key ihlali*/

insert into Notlar(OgrNo) values (5000); /*Ders Kodu bos gecilemez*/

insert into Notlar(OgrNo,DersKodu) values (5000,'BZ401'); /*Ders Kodu bos gecilemez*/
/*primary key ihlali*/

insert into Notlar(OgrNo,DersKodu) values (5000,'BZ301'); /*Ders Kodu bos gecilemez*/

insert into Ogrenciler (OgrNo,Adi,Soyadi,Telefon,Adres)
values (5010,'Fatma','Çiçek','25454','Konya')
/*identity alana veri girilemez*/

insert into Ogrenciler (Adi,Soyadi,Telefon,Adres)
values ('Fatma','Çiçek','25454') /*There are more columns*/

insert into Ogrenciler (Adi,Soyadi,Telefon)
values ('Fatma','Çiçek','25454','Konya') /*There are fewer columns*/

insert into Notlar values ('5000','BZ102') /* supplied values does not match table definition.*/

update Notlar set Vize=60

update Notlar set Vize=100,Final=100 where OgrNo=5005 and DersKodu='BZ101' 

update Notlar set Vize=Vize+5

delete from Dersler where DersKodu='BZ101'

delete from Ogrenciler where OgrNo=5005

delete from Ogrenciler where OgrNo=5001
delete from Notlar where OgrNo=5001

delete from Ogrenciler where OgrNo=5001









