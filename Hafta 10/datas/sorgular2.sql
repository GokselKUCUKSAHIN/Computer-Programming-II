select * from Ogrenciler 

select OgrNo,Adi,Soyadi from Ogrenciler 

select * from Notlar

select * from Notlar where OgrNo=5005

select Vize,Final from Notlar where OgrNo=5000 and DersKodu='BZ101'

select OgrNo,DersKodu,Vize,Final,(Vize*0.4+Final*0.6) as Ortalama from Notlar

select OgrNo,Vize, Final,(Vize*0.4+Final*0.6) as Ortalama  from Notlar where DersKodu='BZ401'

select OgrNo,DersKodu,Vize,Final,(Vize*0.4+Final*0.6) as Ortalama from Notlar
where (Vize*0.4+Final*0.6)>50
order by Ortalama desc

/*asc:ascending:artan
desc:descending:azalan*/

select OgrNo,max(Final) as MaxFinal from Notlar group by OgrNo

select OgrNo,avg(Vize) as OrtVize from Notlar group by OgrNo

select OgrNo,count(Vize) as DersSayisi from Notlar group by OgrNo

select DersKodu,count(DersKodu) as OgrSayisi from notlar group by DersKodu

select OgrNo, DersKodu, (Vize*0.4+Final*0.6) as Ortalama from Notlar

select DersKodu, avg((Vize*0.4+Final*0.6)) as DersOrt from Notlar group by DersKodu

/*
sum: toplam
avg:ortalama
min:minimum
max:maximum
count:veri sayisi*/

select DersKodu, avg((Vize*0.4+Final*0.6)) as DersOrt from Notlar 
group by DersKodu
having avg((Vize*0.4+Final*0.6)) <50

select Notlar.OgrNo,Adi,Soyadi,DersKodu,Vize,Final from Notlar
inner join Ogrenciler
on Ogrenciler.OgrNo=Notlar.OgrNo

select Notlar.OgrNo,Adi,Soyadi,DersKodu,Vize,Final from Notlar,Ogrenciler
where Ogrenciler.OgrNo=Notlar.OgrNo 

select Notlar.OgrNo,Adi,Soyadi,Dersler.DersKodu,DersAdi,Vize,Final from Notlar
inner join Ogrenciler
on Ogrenciler.OgrNo=Notlar.OgrNo
inner join Dersler
on Dersler.DersKodu=Notlar.DersKodu
where Adi='Ali' and Soyadi='Veli'
order by Dersler.DersKodu

insert into Notlar values (5005,'BZ102',90,60)

insert into Notlar(OgrNo) values (5005)

insert into Notlar(OgrNo,DersKodu,Vize) values (5005,'BZ102')

insert into Ogrenciler(OgrNo,Adi,Soyadi) values (5008,'Gokhan','Azizoglu')

update Ogrenciler set Telefon='+9056845' 
where Adi='Ali' and Soyadi='Veli'

update Notlar set Vize=60

update Notlar set Vize=Vize+5

update Notlar set Vize=40,Final=89 where OgrNo=5005 and DersKodu='BZ102'

delete from Ogrenciler

delete from Notlar where OgrNo=5005 and DersKodu='BZ102'

delete from Notlar where OgrNo=5000
delete from Ogrenciler where OgrNo=5000