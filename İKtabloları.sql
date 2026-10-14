USE insanKaynaklariYsDB;
GO

CREATE TABLE Departmanlar
(
    DepartmanID     INT IDENTITY(1,1) PRIMARY KEY,
    DepartmanAdi    NVARCHAR(100) NOT NULL,
    Aciklama        NVARCHAR(500) NULL,
    Durum           BIT           NOT NULL DEFAULT 1,
    OlusturmaTarihi DATETIME2     NOT NULL DEFAULT SYSDATETIME(),

    CONSTRAINT UQ_Departmanlar_DepartmanAdi
        UNIQUE (DepartmanAdi)
);

CREATE TABLE Pozisyonlar
(
    PozisyonID    INT IDENTITY(1,1) PRIMARY KEY,
    DepartmanID   INT NOT NULL,
    PozisyonAdi   NVARCHAR(100) NOT NULL,
    Aciklama      NVARCHAR(500) NULL,
    MinimumMaas   DECIMAL(12,2) NULL,
    MaksimumMaas  DECIMAL(12,2) NULL,
    Durum         BIT NOT NULL DEFAULT 1,
    OlusturmaTarihi DATETIME2 NOT NULL DEFAULT SYSDATETIME(),

    CONSTRAINT FK_Pozisyonlar_Departmanlar
        FOREIGN KEY (DepartmanID)
        REFERENCES Departmanlar(DepartmanID),

    CONSTRAINT CK_Pozisyonlar_MinimumMaas
        CHECK (MinimumMaas IS NULL OR MinimumMaas >= 0),

    CONSTRAINT CK_Pozisyonlar_MaksimumMaas
        CHECK (MaksimumMaas IS NULL OR MaksimumMaas >= 0),

    CONSTRAINT CK_Pozisyonlar_MaasAraligi
        CHECK (
            MinimumMaas IS NULL
            OR MaksimumMaas IS NULL
            OR MinimumMaas <= MaksimumMaas
        ),

    CONSTRAINT UQ_Pozisyonlar_Departman_Pozisyon
        UNIQUE (DepartmanID, PozisyonAdi),

    CONSTRAINT UQ_Pozisyonlar_ID_Departman
        UNIQUE (PozisyonID, DepartmanID)
);

CREATE TABLE Calisanlar
(
    CalisanID   INT IDENTITY(1,1) PRIMARY KEY,
    DepartmanID INT NOT NULL,
    PozisyonID  INT NOT NULL,

    Ad          NVARCHAR(50) NOT NULL,
    Soyad       NVARCHAR(50) NOT NULL,
    TCKimlikNo  CHAR(11) NOT NULL,
    Cinsiyet    NVARCHAR(20) NULL,
    DogumTarihi DATE NULL,

    Telefon NVARCHAR(20) NULL,
    Eposta  NVARCHAR(150) NULL,
    Adres   NVARCHAR(500) NULL,

    IseGirisTarihi   DATE NOT NULL,
    IstenCikisTarihi DATE NULL,
    Maas DECIMAL(12,2) NOT NULL,

    CalismaDurumu NVARCHAR(20) NOT NULL DEFAULT N'Aktif',
    KayitTarihi   DATETIME2 NOT NULL DEFAULT SYSDATETIME(),

    CONSTRAINT UQ_Calisanlar_TCKimlikNo
        UNIQUE (TCKimlikNo),

    CONSTRAINT FK_Calisanlar_Departmanlar
        FOREIGN KEY (DepartmanID)
        REFERENCES Departmanlar(DepartmanID),

    CONSTRAINT FK_Calisanlar_Pozisyonlar
        FOREIGN KEY (PozisyonID, DepartmanID)
        REFERENCES Pozisyonlar(PozisyonID, DepartmanID),

    CONSTRAINT CK_Calisanlar_Maas
        CHECK (Maas >= 0),

    CONSTRAINT CK_Calisanlar_TCKimlikNo
        CHECK (
            TCKimlikNo NOT LIKE '%[^0-9]%'
            AND LEFT(TCKimlikNo, 1) <> '0'
        ),

    CONSTRAINT CK_Calisanlar_CalismaDurumu
        CHECK (
            CalismaDurumu IN
            (N'Aktif', N'Pasif', N'İzinli', N'Ayrıldı')
        ),

    CONSTRAINT CK_Calisanlar_CikisTarihi
        CHECK (
            IstenCikisTarihi IS NULL
            OR IstenCikisTarihi >= IseGirisTarihi
        ),

    CONSTRAINT CK_Calisanlar_DogumTarihi
        CHECK (
            DogumTarihi IS NULL
            OR DogumTarihi < IseGirisTarihi
        )
);

CREATE TABLE Kullanicilar
(
    KullaniciID  INT IDENTITY(1,1) PRIMARY KEY,
    CalisanID    INT NULL,
    KullaniciAdi NVARCHAR(50) NOT NULL,
    SifreHash    NVARCHAR(255) NOT NULL,
    Rol          NVARCHAR(30) NOT NULL DEFAULT N'Calisan',
    Durum        BIT NOT NULL DEFAULT 1,
    SonGirisTarihi  DATETIME2 NULL,
    OlusturmaTarihi DATETIME2 NOT NULL DEFAULT SYSDATETIME(),

    CONSTRAINT UQ_Kullanicilar_KullaniciAdi
        UNIQUE (KullaniciAdi),

    CONSTRAINT UQ_Kullanicilar_CalisanID
        UNIQUE (CalisanID),

    CONSTRAINT FK_Kullanicilar_Calisanlar
        FOREIGN KEY (CalisanID)
        REFERENCES Calisanlar(CalisanID),

    CONSTRAINT CK_Kullanicilar_Rol
        CHECK (
            Rol IN
            (N'Admin', N'IKPersoneli',N'Calisan')
        )
);