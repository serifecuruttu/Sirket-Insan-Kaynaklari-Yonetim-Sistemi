ALTER TABLE Kullanicilar
ADD
    OnaylayanKullaniciID INT NULL,
    KaydedenKullaniciID INT NULL,
    DegerlendirenKullaniciID INT NULL,
    OlusturanKullaniciID INT NULL

CREATE TABLE Izinler(
 IzinID INT IDENTITY(1,1) PRIMARY KEY, 
 CalisanID INT NOT NULL, 
 IzinTuru NVARCHAR(40) NOT NULL,
 BaslangicTarihi DATE NOT NULL, 
 BitisTarihi DATE NOT NULL, 
 Aciklama NVARCHAR(300) NULL,
 Durum NVARCHAR(20) NOT NULL DEFAULT N'Beklemede', 
 TalepTarihi DATE NOT NULL DEFAULT CONVERT(date,GETDATE()),
 OnaylayanKullaniciID INT NULL,
 FOREIGN KEY(CalisanID) REFERENCES Calisanlar(CalisanID),
 FOREIGN KEY(OnaylayanKullaniciID) REFERENCES Kullanicilar(KullaniciID), CHECK(BitisTarihi>=BaslangicTarihi),
 CHECK(Durum IN(N'Beklemede',N'Onaylandı',N'Reddedildi')));

CREATE TABLE Maaslar(
 MaasID INT IDENTITY(1,1) PRIMARY KEY, 
 CalisanID INT NOT NULL, 
 MaasTutari DECIMAL(12,2) NOT NULL,
 BaslangicTarihi DATE NOT NULL, 
 BitisTarihi DATE NULL, 
 Aciklama NVARCHAR(300) NULL, 
 KaydedenKullaniciID INT NULL, 
 FOREIGN KEY(CalisanID) REFERENCES Calisanlar(CalisanID), 
 FOREIGN KEY(KaydedenKullaniciID) REFERENCES Kullanicilar(KullaniciID),
 CHECK(MaasTutari>=0), CHECK(BitisTarihi IS NULL OR BitisTarihi>=BaslangicTarihi));

CREATE TABLE PerformansDegerlendirmeleri(
 PerformansID INT IDENTITY(1,1) PRIMARY KEY, 
 CalisanID INT NOT NULL, 
 DegerlendirenKullaniciID INT NULL,
 DegerlendirmeTarihi DATE NOT NULL, 
 IsKalitesi TINYINT NOT NULL, 
 TakimCalismasi TINYINT NOT NULL,
 Iletisim TINYINT NOT NULL, 
 HedefGerceklesme TINYINT NOT NULL, 
 GenelPuan DECIMAL(3,1) NOT NULL, 
 Yorum NVARCHAR(500) NULL,
 FOREIGN KEY(CalisanID) REFERENCES Calisanlar(CalisanID), 
 FOREIGN KEY(DegerlendirenKullaniciID) REFERENCES Kullanicilar(KullaniciID),
 CHECK(IsKalitesi BETWEEN 1 AND 5 AND TakimCalismasi BETWEEN 1 AND 5 AND Iletisim BETWEEN 1 AND 5 AND HedefGerceklesme BETWEEN 0 AND 100 AND GenelPuan BETWEEN 1 AND 5));

CREATE TABLE Egitimler(
 EgitimID INT IDENTITY(1,1) PRIMARY KEY, 
 EgitimAdi NVARCHAR(150) NOT NULL, 
 Saglayici NVARCHAR(120) NULL,
 SureSaat SMALLINT NOT NULL, 
 EgitimTarihi DATE NULL, 
 Aciklama NVARCHAR(300) NULL, 
 Durum BIT NOT NULL DEFAULT 1, CHECK(SureSaat>0));

CREATE TABLE CalisanEgitimleri(
 CalisanEgitimID INT IDENTITY(1,1) PRIMARY KEY, 
 CalisanID INT NOT NULL, 
 EgitimID INT NOT NULL,
 AtanmaTarihi DATE NOT NULL DEFAULT CONVERT(date,GETDATE()), 
 TamamlanmaTarihi DATE NULL,
 KatilimDurumu NVARCHAR(20) NOT NULL DEFAULT N'Planlandı', 
 BasariPuani TINYINT NULL, 
 SertifikaVarMi BIT NOT NULL DEFAULT 0,
 FOREIGN KEY(CalisanID) REFERENCES Calisanlar(CalisanID), FOREIGN KEY(EgitimID) REFERENCES Egitimler(EgitimID),
 UNIQUE(CalisanID,EgitimID), CHECK(KatilimDurumu IN(N'Planlandı',N'Devam Ediyor',N'Tamamlandı',N'İptal')),
 CHECK(BasariPuani IS NULL OR BasariPuani BETWEEN 0 AND 100));

CREATE TABLE DevamKayitlari(
 DevamID INT IDENTITY(1,1) PRIMARY KEY, 
 CalisanID INT NOT NULL, 
 Tarih DATE NOT NULL, 
 GirisSaati TIME NULL,
 CikisSaati TIME NULL, 
 Durum NVARCHAR(20) NOT NULL, 
 Aciklama NVARCHAR(300) NULL,
 FOREIGN KEY(CalisanID) REFERENCES Calisanlar(CalisanID), UNIQUE(CalisanID,Tarih),
 CHECK(Durum IN(N'Geldi',N'Geç Geldi',N'Gelmedi',N'İzinli',N'Uzaktan')));

CREATE TABLE IsIlanlari(
 IsIlaniID INT IDENTITY(1,1) PRIMARY KEY, 
 PozisyonID INT NOT NULL, 
 IlanBasligi NVARCHAR(150) NOT NULL,
 IlanAciklamasi NVARCHAR(1000) NOT NULL, 
 YayinTarihi DATE NOT NULL, 
 SonBasvuruTarihi DATE NOT NULL,
 CalismaSekli NVARCHAR(30) NOT NULL, 
 Konum NVARCHAR(100) NULL, 
 Durum NVARCHAR(20) NOT NULL DEFAULT N'Yayında',
 OlusturanKullaniciID INT NULL, 
 FOREIGN KEY(PozisyonID) REFERENCES Pozisyonlar(PozisyonID),
 FOREIGN KEY(OlusturanKullaniciID) REFERENCES Kullanicilar(KullaniciID), CHECK(SonBasvuruTarihi>=YayinTarihi),
 CHECK(Durum IN(N'Taslak',N'Yayında',N'Kapalı')));

CREATE TABLE IsBasvurulari(
 IsBasvuruID INT IDENTITY(1,1) PRIMARY KEY, 
 IsIlaniID INT NOT NULL, 
 Ad NVARCHAR(60) NOT NULL, 
 Soyad NVARCHAR(60) NOT NULL,
 Eposta NVARCHAR(150) NOT NULL, 
 Telefon NVARCHAR(30) NULL, 
 BasvuruTarihi DATE NOT NULL DEFAULT CONVERT(date,GETDATE()),
 Kaynak NVARCHAR(80) NULL, 
 Durum NVARCHAR(30) NOT NULL DEFAULT N'Yeni', DegerlendirmeNotu NVARCHAR(500) NULL,
 FOREIGN KEY(IsIlaniID) REFERENCES IsIlanlari(IsIlaniID),
 CHECK(Durum IN(N'Yeni',N'Ön Değerlendirme',N'Mülakat',N'Teklif',N'Olumlu',N'Olumsuz',N'Geri Çekildi')));

 ALTER TABLE Kullanicilar
ADD IlkGirisMi BIT NOT NULL
    CONSTRAINT DF_Kullanicilar_IlkGirisMi DEFAULT 1;



