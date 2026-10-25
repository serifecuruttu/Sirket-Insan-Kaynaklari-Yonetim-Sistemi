INSERT INTO Departmanlar (DepartmanAdi, Aciklama)
VALUES
(N'Yazılım Geliştirme', N'Web, mobil ve masaüstü yazılım geliştirme'),
(N'Kalite ve Test', N'Yazılım testleri ve kalite güvencesi'),
(N'Proje Yönetimi', N'Projelerin planlanması ve koordinasyonu'),
(N'İnsan Kaynakları', N'İşe alım ve çalışan yönetimi'),
(N'Satış ve Pazarlama', N'Satış, müşteri ilişkileri ve pazarlama'),
(N'Finans ve İdari İşler', N'Muhasebe, bütçe ve idari operasyonlar'),
(N'Bilgi Teknolojileri', N'Sistem, ağ ve teknik destek'),
(N'Ürün ve Tasarım', N'Ürün tasarımı ve kullanıcı deneyimi');

INSERT INTO Pozisyonlar
    (DepartmanID, PozisyonAdi, Aciklama, MinimumMaas, MaksimumMaas)
VALUES
(1, N'Yazılım Müdürü', N'Yazılım ekibinin yönetimi', 85000, 130000),
(1, N'Kıdemli Backend Geliştirici', N'Backend mimarisi ve geliştirme', 80000, 120000),
(1, N'Backend Geliştirici', N'Sunucu taraflı uygulama geliştirme', 70000, 95000),
(1, N'Frontend Geliştirici', N'Web arayüzü geliştirme', 70000, 95000),
(1, N'Mobil Uygulama Geliştirici', N'Mobil uygulama geliştirme', 75000, 90000),
(1, N'Full Stack Geliştirici', N'Ön ve arka uç geliştirme', 65000, 95000),
(2, N'Yazılım Test Müdürü', N'Test ekibinin yönetimi', 65000, 95000),
(2, N'Test Uzmanı', N'Manuel yazılım testleri', 55000, 75000),
(2, N'Otomasyon Test Mühendisi', N'Otomasyon testlerinin geliştirilmesi', 82000, 115000),
(3, N'Proje Yöneticisi', N'Proje planlama ve yönetimi', 60000, 90000),
(3, N'Scrum Master', N'Çevik süreçlerin yürütülmesi', 50000, 75000),
(4, N'İK Müdürü', N'İnsan kaynakları süreçlerinin yönetimi', 60000, 85000),
(4, N'İK Uzmanı', N'Özlük ve çalışan işlemleri', 55000, 80000),
(4, N'İşe Alım Uzmanı', N'Aday bulma ve işe alım süreçleri', 55000, 72000),
(5, N'Satış Müdürü', N'Satış ekibinin yönetimi', 60000, 90000),
(5, N'Pazarlama Uzmanı', N'Pazarlama ve kampanya çalışmaları', 48000, 60000),
(6, N'Muhasebe Uzmanı', N'Muhasebe ve mali kayıtlar', 45000, 60000),
(6, N'Finans Uzmanı', N'Bütçe ve finansal analiz', 40000, 60000),
(7, N'Sistem ve Ağ Uzmanı', N'Sistem ve ağ yönetimi', 40000, 60000),
(8, N'UI/UX Tasarımcı', N'Kullanıcı arayüzü ve deneyimi tasarımı', 45000, 65000);


INSERT INTO Calisanlar
(
    DepartmanID, PozisyonID, Ad, Soyad, TCKimlikNo,
    Cinsiyet, DogumTarihi, Telefon, Eposta, Adres,
    IseGirisTarihi, Maas, CalismaDurumu
)
VALUES
(1,1,N'Ahmet',N'Yılmaz','10000000001',N'Erkek','1985-03-12',N'05000000001',N'ahmetylmz@gmail.com',N'Kayseri', '2020-01-06',85000,N'Aktif'),
(1,2,N'Ayşe',N'Kaya','10000000002',N'Kadın','1992-07-21',N'05000000002',N'ayse.ky12@gmail.com',N'Ankara', '2021-04-12',75000,N'Aktif'),
(1,3,N'Mehmet',N'Demir','10000000003',N'Erkek','1994-11-08',N'05000000003',N'mehmetdemir123@gmail.com',N'İstanbul', '2022-02-14',50000,N'Aktif'),
(1,4,N'Fatma',N'Şahin','10000000004',N'Kadın','1996-05-19',N'05000000004',N'fatmasahin@gmail.com',N'Sivas', '2023-03-01',100000,N'Aktif'),
(1,5,N'Mustafa',N'Çelik','10000000005',N'Erkek','1993-09-25',N'05000000005',N'mustafaclk@gmail.com',N'Ankara', '2022-06-20',60000,N'Aktif'),
(1,6,N'Zeynep',N'Yıldız','10000000006',N'Kadın','1997-01-17',N'05000000006',N'zeynep.yildiz@gmail.com',N'İstanbul', '2024-01-08',55000,N'Aktif'),
(1,3,N'Emre',N'Yıldırım','10000000007',N'Erkek','1995-04-11',N'05000000007',N'emreyildirim0@gmail.com',N'Kayseri', '2023-07-10',60000,N'Aktif'),
(1,4,N'Elif',N'Öztürk','10000000008',N'Kadın','1998-12-03',N'05000000008',N'elfozturk@gmail.com',N'Ankara', '2024-05-13',68000,N'Aktif'),

(2,7,N'Burak',N'Aydın','10000000009',N'Erkek','1987-02-09',N'05000000009',N'burak.aydin@gmail.com',N'İstanbul', '2020-09-07',78000,N'Aktif'),
(2,8,N'Merve',N'Arslan','10000000010',N'Kadın','1995-06-14',N'05000000010',N'merve.arslan@gmail.com',N'Kayseri', '2022-11-21',43000,N'Aktif'),
(2,9,N'Can',N'Doğan','10000000011',N'Erkek','1992-08-27',N'05000000011',N'can.dogan@gmail.com',N'Manisa', '2021-02-15',55000,N'Aktif'),
(2,8,N'Ece',N'Kılıç','10000000012',N'Kadın','1998-10-06',N'05000000012',N'ece.kilic@gmail.com',N'Trabzon', '2024-02-05',62000,N'Aktif'),
(2,9,N'Onur',N'Aslan','10000000013',N'Erkek','1991-12-19',N'05000000013',N'onur.aslan@gmail.com',N'Kayseri', '2021-08-16',53000,N'Aktif'),
(2,8,N'Derya',N'Çetin','10000000014',N'Kadın','1996-04-23',N'05000000014',N'derya.cetin@gmail.com',N'Ankara', '2023-10-02',44000,N'Aktif'),
(2,8,N'Kerem',N'Kara','10000000015',N'Erkek','1997-07-30',N'05000000015',N'kerem.kara@gmail.com',N'İstanbul', '2024-03-18',72000,N'Aktif'),

(3,10,N'Buse',N'Koç','10000000016',N'Kadın','1988-02-16',N'05000000016',N'buse.koc@gmail.com',N'Ankara', '2020-05-11',120000,N'Aktif'),
(3,11,N'Furkan',N'Kurt','10000000017',N'Erkek','1990-06-22',N'05000000017',N'furkan.kurt@gmail.com',N'Rize', '2021-07-19',100000,N'Aktif'),
(3,10,N'İrem',N'Özkan','10000000018',N'Kadın','1993-09-04',N'05000000018',N'irem.ozkan@gmail.com',N'İstanbul', '2022-01-10',850000,N'Aktif'),
(3,11,N'Murat',N'Şimşek','10000000019',N'Erkek','1991-03-28',N'05000000019',N'murat.simsek@gmail.com',N'Ankara', '2022-08-08',90000,N'Aktif'),
(3,10,N'Ceren',N'Polat','10000000020',N'Kadın','1989-11-13',N'05000000020',N'ceren.polat@gmail.com',N'Kayseri', '2020-11-02',84000,N'Aktif'),
(3,11,N'Kaan',N'Acar','10000000021',N'Erkek','1994-01-26',N'05000000021',N'kaan.acar@gmail.com',N'İstanbul', '2023-04-03',78000,N'Aktif'),

(4,12,N'Seda',N'Tekin','10000000022',N'Kadın','1986-05-08',N'05000000022',N'seda.tekin@gmail.com',N'Ankara', '2019-06-03',72000,N'Aktif'),
(4,13,N'Arda',N'Aksoy','10000000023',N'Erkek','1995-10-12',N'05000000023',N'arda.aksoy@gmail.com',N'Kayseri', '2022-04-18',45000,N'Aktif'),
(4,14,N'Esra',N'Taş','10000000024',N'Kadın','1993-02-20',N'05000000024',N'esra.tas@gmail.com',N'İstanbul', '2021-09-13',77000,N'Aktif'),
(4,13,N'Yusuf',N'Güneş','10000000025',N'Erkek','1997-08-15',N'05000000025',N'yusuf.gunes@gmail.com',N'Sivas', '2024-01-15',60000,N'Aktif'),
(4,14,N'Selin',N'Bulut','10000000026',N'Kadın','1996-12-29',N'05000000026',N'selin.bulut@gmail.com',N'Muğla', '2023-06-12',66000,N'Aktif'),
(4,13,N'Deniz',N'Keskin','10000000027',N'Erkek','1994-04-07',N'05000000027',N'deniz.keskin@gmail.com',N'İstanbul', '2022-10-17',54000,N'Aktif'),

(5,15,N'Melis',N'Erdoğan','10000000028',N'Kadın','1987-07-05',N'05000000028',N'melis.erdogan@gmail.com',N'Ankara', '2020-03-09',76000,N'Aktif'),
(5,16,N'Oğuz',N'Avcı','10000000029',N'Erkek','1992-09-18',N'05000000029',N'oguz.avci@gmail.com',N'Kayseri', '2021-11-01',58000,N'Aktif'),
(5,15,N'Gizem',N'Yılmaz','10000000030',N'Kadın','1990-01-24',N'05000000030',N'gizem.yilmaz@gmail.com',N'Balıkesir', '2020-08-17',73000,N'Aktif'),
(5,16,N'Berk',N'Kaya','10000000031',N'Erkek','1996-06-09',N'05000000031',N'berk.kaya@gmail.com',N'Ankara', '2023-02-06',45000,N'Aktif'),
(5,16,N'Yağmur',N'Demir','10000000032',N'Kadın','1998-03-16',N'05000000032',N'yagmur.demir@gmail.com',N'Mersin', '2024-04-08',53000,N'Aktif'),
(5,15,N'Sena',N'Ünsal','10000000033',N'Erkek','1989-10-30',N'05000000033',N'senansl3@gmail.com',N'İstanbul', '2019-12-02',88000,N'Aktif'),
(5,16,N'İlayda',N'Çelik','10000000034',N'Kadın','1997-11-11',N'05000000034',N'ilayda.celik@gmail.com',N'Adana', '2023-09-04',76000,N'Aktif'),

(6,17,N'Eren',N'Yıldız','10000000035',N'Erkek','1991-04-14',N'05000000035',N'eren.yildiz@gmail.com','Kayseri', '2021-03-15',77000,N'Aktif'),
(6,18,N'Naz',N'Yıldırım','10000000036',N'Kadın','1993-08-02',N'05000000036',N'naz.yildirim@gmail.com',N'İstanbul', '2022-05-16',61000,N'Aktif'),
(6,17,N'Tolga',N'Öztürk','10000000037',N'Erkek','1988-12-07',N'05000000037',N'tolga.ozturk@gmail.com',N'İstanbul', '2020-07-06',50000,N'Aktif'),
(6,18,N'Damla',N'Aydın','10000000038',N'Kadın','1995-05-25',N'05000000038',N'damla.aydin@gmail.com',N'Kayseri', '2023-01-09',88000,N'Aktif'),
(6,17,N'Serkan',N'Arslan','10000000039',N'Erkek','1990-02-18',N'05000000039',N'serkan.arslan@gmail.com',N'Rize', '2021-10-11',66000,N'Aktif'),
(6,18,N'Aslı',N'Doğan','10000000040',N'Kadın','1994-07-13',N'05000000040',N'asli.dogan@gmail.com',N'Ankara', '2022-12-05',52000,N'Aktif'),

(7,19,N'Hakan',N'Kılıç','10000000041',N'Erkek','1987-09-22',N'05000000041',N'hakan.kilic@gmail.com',N'Sivas', '2020-02-10',56000,N'Aktif'),
(7,19,N'Pınar',N'Aslan','10000000042',N'Kadın','1992-01-31',N'05000000042',N'pinar.aslan@gmail.com',N'İstanbul', '2021-06-14',63000,N'Aktif'),
(7,19,N'Umut',N'Çetin','10000000043',N'Erkek','1996-10-03',N'05000000043',N'umut.cetin@gmail.com',N'Ankara', '2023-05-08',88000,N'Aktif'),
(7,19,N'Eylül',N'Kara','10000000044',N'Kadın','1998-04-27',N'05000000044',N'eylul.kara@gmail.com',N'Kayseri', '2024-02-19',45000,N'Aktif'),
(7,19,N'Barış',N'Koç','10000000045',N'Erkek','1991-06-17',N'05000000045',N'baris.koc@gmail.com',N'İstanbul', '2021-12-13',55000,N'Aktif'),

(8,20,N'Sıla',N'Kurt','10000000046',N'Kadın','1995-02-05',N'05000000046',N'sila.kurt@gmail.com',N'Ankara', '2022-07-04',50000,N'Aktif'),
(8,20,N'Kübra',N'Özkan','10000000047',N'Kadın','1993-06-26',N'05000000047',N'kubra.ozkan@gmail.com',N'Kayseri', '2021-05-17',52000,N'Aktif'),
(8,20,N'Bora',N'Şimşek','10000000048',N'Erkek','1997-09-09',N'05000000048',N'bora.simsek@gmail.com',N'İstanbul', '2023-08-21',77000,N'Aktif'),
(8,20,N'Nisa',N'Polat','10000000049',N'Kadın','1998-12-14',N'05000000049',N'nisa.polat@gmail.com',N'Ankara', '2024-06-03',45000,N'Aktif'),
(8,20,N'Tuna',N'Acar','10000000050',N'Erkek','1994-03-02',N'05000000050',N'tuna.acar@gmail.com',N'Kayseri', '2022-09-12',91000,N'Aktif');

INSERT INTO Kullanicilar
    (CalisanID, KullaniciAdi, SifreHash, Rol, Durum, IlkGirisMi)
VALUES
    (1, 'admin', 'GECICI', 'Admin', 1, 1);

    SELECT KullaniciID, CalisanID, KullaniciAdi, Rol, Durum, IlkGirisMi
FROM Kullanicilar;
