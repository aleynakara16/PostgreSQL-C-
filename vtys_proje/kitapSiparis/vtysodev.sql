CREATE TABLE bolge (
	bolge_id integer PRIMARY KEY,
	kitap_ad VARCHAR  UNIQUE NOT NULL
);
insert into bolge values(1,'marmara bölgesi'),
(2,'marmara bölgesi'),
(3,'ege bölgesi'),
(4,'iç anadolu bölgesi'),
(5,'akdeniz bölgesi'),
(6,'doğu bölgesi')

----------

CREATE TABLE il (
	il_id integer PRIMARY KEY,
	il_ad VARCHAR  UNIQUE NOT NULL,
	bolge integer,
	FOREIGN KEY (bolge) REFERENCES bolge (bolge_id),

);
insert into il values
(1,'ankara',4),
(2,'istanbul',1),
(3,'izmir',3),
(4,'antalya',5),
(5,'kocaeli',1),
(6,'sakarya',1)

--------

CREATE TABLE ilce (
	ilce_id integer PRIMARY KEY,
	ilce_ad VARCHAR  UNIQUE NOT NULL,
	il integer,
	FOREIGN KEY (il) REFERENCES il (il_id),

);
insert into ilce values
(1,'beylikdüzü',2),
(2,'çankaya',1),
(3,'pendik',2),
(4,'serdivan',7)

--------

CREATE TABLE tbl_iletisim (
	iletisim_no integer PRIMARY KEY,
	kisi integer NOT NULL,
	mail VARCHAR  UNIQUE NOT NULL,
	ilce integer,
    telefon text,
	FOREIGN KEY (ilce) REFERENCES ilce (ilce_id),
	FOREIGN KEY (kisi) REFERENCES kisi (kisi_id)
);
insert into tbl_iletisim values
(1,1,'beyzanur@hotmail.com','05347889465',2),
(2,1,'beyza@hotmail.com','05347889464',2),
(3,2,'hatice@hotmail.com','05369452111',2),
(4,3,'simay@hotmail.com','0537776218',2)

CREATE TABLE kargo (
	firma_id integer PRIMARY KEY,
	firma_ad VARCHAR  UNIQUE NOT NULL,
);
insert into kargo values
(0,'...'),
(1,'ptt'),
(2,'aras kargo'),
(3,'yurtiçi kargo'),
(4,'sürat kargo')

--------

CREATE TABLE kategori (
	katagori_id integer PRIMARY KEY,
	katagori_adi VARCHAR  UNIQUE NOT NULL,
);
insert into kategori values
(0,'...'),
(1,'fantastik'),
(2,'gerilim'),
(3,'polisiye'),
(4,'klasik'),
(5,'dram'),
(6,'gizem')

--------

CREATE TABLE kitaplar (
	kitap_id integer PRIMARY KEY,
	kitap_ad VARCHAR  UNIQUE NOT NULL,
	yazar integer  ,
	alis_fiyat double precision ,
	stok integer,
	magaza integer ,
	tedarikci integer,
	katagori integer ,
	dil integer ,
	satis_fiyat double precision 
);
insert into kitaplar values(1,'origin',1,51.7,69,2,6,6,2,77.9),
(2,'madam bovary',5,34,88,5,4,5,1,44),
(3,'kuyucaklı yusuf',2,34,87,5,4,5,1,44),
(4,'gazap üzümleri',2,47.9,41,3,4,5,1,55.9),
(5,'içimizdeki şeytan',2,61,9,1,2,5,1,70)

----------

CREATE TABLE siparis (
	siparis_id integer PRIMARY KEY,
	musteri integer ,
	kitap integer UNIQUE NOT NULL  ,
	adet integer,
	tutar double precision ,
	kargo integer,
	FOREIGN KEY (musteri) REFERENCES musteri (musteri_id),
	FOREIGN KEY (kitap) REFERENCES kitaplar (kitap_id),
	FOREIGN KEY (kargo) REFERENCES kargo (firma_id)

);

insert into siparis values
(5,1,2,4,191.6,3),
(2,4,5,11,770,1)

 ----------

CREATE TABLE tedarikci (
	tedarikci_id integer PRIMARY KEY,
	tedarikci_adi VARCHAR
);

insert into tedarikci values
(0,'...'),
(1,'sirket1'),
(2,'sirket2'),
(3,'sirket3'),
(4,'sirket4'),
(5,'sirket5'),
(6,'sirket6'),
(7,'sirket7')

----------
CREATE TABLE yazar (
	yazar_id integer PRIMARY KEY,
	yazar_ad_soyad VARCHAR
);
insert into yazar values
(0,'...'),
(1,'dan brown'),
(2,'sabahattin ali'),
(3,'john steinbeck'),
(4,'dostoyevski'),
(5,'gustave flaubert'),
(6,'ernest hemingway'),
(7,'zulfü livaneli')

-----

CREATE TABLE dil (
	dil_id integer PRIMARY KEY,
	dil_adi VARCHAR
);
insert into dil values
(0,'...'),
(1,'turkce'),
(2,'ingilizce'),
(3,'ispanyolca'),
(4,'arapça'),
(5,'fransızca'),
(6,'almanca')

------

CREATE TABLE magaza (
	magaza_id integer PRIMARY KEY,
	magza_ad VARCHAR,
	magaza_tel varchar(11),
	magaza_adres text
);
insert into magaza values
(0,'...','...','...'),
(1,'sefaköy şubesi','5345678910','sefaköy'),
(2,'beylikdüzü şubesi','5345678910','beylikdüzü'),
(3,'sakarya şubesi','5345678910','serdivan'),
(4,'ankara şubesi','5345678910','çankaya'),
(5,'izmir şubesi','1234567891','kordon'),
(6,'sivas şubesi','5335195223','yıldızeli')


------------------------------------------------

create view view_kisi
AS
  SELECT "kullanıcı".id,
    "kullanıcı".ad,
    "kullanıcı".soyad,
    "kullanıcı".sifre,
    "kullanıcı".kisi_tur,
    tbl_iletisim.telefon,
    tbl_iletisim.mail,
    ilce.ilce_ad,
    il.il_ad,
    bolge.bolge_ad
   FROM "kullanıcı"
     LEFT JOIN tbl_iletisim ON "kullanıcı".id = tbl_iletisim.kisi
     LEFT JOIN ilce ON tbl_iletisim.ilce = ilce.ilce_id
     LEFT JOIN il ON ilce.il = il.il_id
     LEFT JOIN bolge ON il.bolge = bolge.bolge_id;

----------------------------------------------------

create view view_kitap
AS
SELECT kitaplar.kitap_id,
    kitaplar.kitap_ad AS kitap,
    yazar.yazar_ad_soyad AS yazar,
    kitaplar.alis_fiyat AS "alış_fiyatı",
    kitaplar.satis_fiyat AS "satış_fiyatı",
    kitaplar.stok,
    kitaplar.kdv,
    magaza.magaza_ad AS "mağaza",
    tedarikci.tedarikci_adi AS "tedarikçi",
    kategori.katagori_adi AS kategori,
    dil.dil_adi AS dil
   FROM kitaplar
     LEFT JOIN yazar ON kitaplar.yazar = yazar.yazar_id
     LEFT JOIN magaza ON kitaplar.magaza = magaza.magaza_id
     LEFT JOIN tedarikci ON kitaplar.tedarikci = tedarikci.tedarikci_id
     LEFT JOIN kategori ON kitaplar.katagori = kategori.katagori_id
     LEFT JOIN dil ON kitaplar.dil = dil.dil_id;
------------------------------------------------------
create view view_siparis
AS
SELECT siparis.siparis_id,
    tbl_musteri.id,
    tbl_musteri.ad,
    tbl_musteri.soyad,
    kitaplar.kitap_ad,
    kitaplar.satis_fiyat,
    siparis.adet,
    siparis.tutar
   FROM siparis
     JOIN tbl_musteri ON siparis.musteri = tbl_musteri.id
     JOIN kitaplar ON siparis.kitap = kitaplar.kitap_id;
---------------------------------------------------------
create view view_urunler
AS
 SELECT kitaplar.kitap_id,
    kitaplar.kitap_ad AS "kitabın_adi",
    yazar.yazar_ad_soyad AS "Yazarı",
    kategori.katagori_adi AS "Kategorisi",
    dil.dil_adi AS dili,
    kitaplar.stok AS "stok_Miktarı",
    kitaplar.satis_fiyat AS "satış_fiyatı"
   FROM kitaplar
     JOIN yazar ON kitaplar.yazar = yazar.yazar_id
     JOIN kategori ON kitaplar.katagori = kategori.katagori_id
     JOIN dil ON kitaplar.dil = dil.dil_id;

--------------------------------------------------------

CREATE OR REPLACE FUNCTION KUCUKHARFECEVIR()
RETURNS TRIGGER
AS
$$
BEGIN
    NEW."kitap_ad" = LOWER(NEW."kitap_ad"); -- büyük harfe dönüştürdükten sonra ekle
    NEW."kitap_ad" = TRIM(NEW."kitap_ad"); -- Önceki ve sonraki boşlukları temizle
    IF NEW."kitap_id" IS NULL THEN
            RAISE EXCEPTION 'kitap ID alanı boş olamaz';  
 END IF;
RETURN NEW;
END;
$$ 
LANGUAGE plpgsql

CREATE TRIGGER kucukHarfKontrol
AFTER INSERT 
ON kitaplar
FOR EACH ROW
EXECUTE PROCEDURE KUCUKHARFECEVIR();
----------------------------------------------------------

CREATE OR REPLACE FUNCTION stokdus()
RETURNS TRIGGER
AS
$$
BEGIN
   update kitaplar set stok=stok-NEW.adet where kitap_id=NEW.kitap;
   return NEW;
END
$$ 
LANGUAGE plpgsql

CREATE TRIGGER tg_stokdus
AFTER INSERT 
ON siparis
FOR EACH ROW
EXECUTE PROCEDURE stokdus();

-------------------------------------------------------
create or replace function kdvlifiyat(alısfiyat double precision,kdv double precision)
returns double precision
language plpgsql
as
$$
begin
alısfiyat:=alısfiyat+(alısfiyat*kdv);
return alısfiyat;
end;

$$
-----------------------------------------------------
create or replace function kitap_sayisi()
returns double precision
language plpgsql
as
$$
DECLARE
toplam INTEGER;
BEGIN 
SELECT COUNT(*) INTO toplam FROM "kitaplar";
RETURN toplam;
END;
$$
---------------------------------------------------------
create or replace function randombetween(low integer,high integer)
returns double precision
language plpgsql
as
$$
begin
return floor(random()*(high-low+1)+low);
end;
$$
--------------------------------------------------------
create or replace function tutarhesapla(kitapid integer)
returns double precision
language plpgsql
as
$$
Declare  
 tutar float;  
 satışfiyatı float;
 alışmiktarı integer;
Begin  
 select alışmiktarı=adet from siparis where kitap=kitapID;
 select satışfiyatı=satis_fiyat from kitaplar where kitap_id=kitapID;
 tutar=alışmiktarı*satışfiyatı;
 return tutar;
End; 
$$
-------------------------------------------------------
CREATE OR REPLACE FUNCTION silinenkitaplar()
RETURNS TRIGGER
AS
$$
BEGIN
INSERT INTO silinenkitaplar (kitapid,kitapad,yazar)
VALUES(OLD.kitap_id,OLD.kitap_ad,OLD.yazar);
RETURN NEW;
END;
$$ 
LANGUAGE plpgsql

CREATE TRIGGER TG_silinenleriekle
AFTER delete 
ON kitaplar
FOR EACH ROW
EXECUTE PROCEDURE silinenkitaplar();
---------------------------------------------
create table kullanıcı(
id SERIAL PRIMARY KEY NOT NULL,
ad VARCHAR NOT NULL,
soyad VARCHAR NOT NULL,
sifre SERIAL NOT NULL,
kisi_tur VARCHAR NOT NULL
);
create table tbl_personel(
LIKE kullanıcı INCLUDING INDEXES,
magaza_id serial
	
) INHERITS(kullanıcı);

create table tbl_musteri(
LIKE kullanıcı INCLUDING INDEXES,
	
) INHERITS(kullanıcı);

------------------------------------------
CREATE OR REPLACE FUNCTION kitap_degisiklik()
RETURNS TRIGGER
AS
$$
BEGIN
IF NEW.kdv <> OLD.kdv THEN
 INSERT INTO kitap_degisiklikleri(kitapid, kitap_ad,eski_kdv,yeni_kdv)
 VALUES(OLD.kitap_id, OLD.kitap_ad,OLD.kdv, NEW.kdv);
 END IF;
 RETURN NEW;
 END;
 $$ 
 LANGUAGE plpgsql

CREATE TRIGGER tg_kitapdegisiklik
AFTER UPDATE 
ON kitaplar
FOR EACH ROW
EXECUTE PROCEDURE kitap_degisiklik();

----------------------------------------
CREATE TABLE silinenkitaplar (
	kitapid integer PRIMARY KEY,
	kitapad VARCHAR  UNIQUE,
	yazar integer
);
---------------------------------------
CREATE TABLE kitap_degisiklikleri(
	kitapid integer PRIMARY KEY,
	kitap_ad VARCHAR  UNIQUE,
	eski_kdv double precision,
	yeni_kdv double precision,
);
----------------------------------------


