INSERT INTO Izinler
(CalisanID, IzinTuru, BaslangicTarihi, BitisTarihi,
 Aciklama, Durum, TalepTarihi, OnaylayanKullaniciID)
VALUES
(1, N'Yıllık İzin', '2026-11-02', '2026-11-04',
 N'Aile ziyareti', N'Beklemede', '2026-10-23', NULL),
(2, N'Mazeret İzni', '2026-11-05', '2026-11-05',
 N'Kişisel işler', N'Onaylandı', '2026-10-22', 1),
(3, N'Yıllık İzin', '2026-11-10', '2026-11-12',
 N'Tatil planı', N'Beklemede', '2026-10-23', NULL);


INSERT INTO Pozisyonlar
(DepartmanID, PozisyonAdi, Aciklama,
 MinimumMaas, MaksimumMaas, Durum)
VALUES
(1, N'Yapay Zekâ Mühendisi',
 N'Yapay zekâ ve makine öğrenmesi modelleri geliştirme.',
 70000, 100000, 1),

(1, N'Veri Analisti',
 N'Veri analizi, raporlama ve veri görselleştirme.',
 55000, 70000, 1),

(1, N'Siber Güvenlik Uzmanı',
 N'Sistem güvenliği ve güvenlik açıklarını analiz etme.',
 75000, 90000, 1),

(1, N'DevOps Mühendisi',
 N'Yazılım dağıtımı, otomasyon ve bulut süreçlerini yönetme.',
 85000, 115000, 1);

 INSERT INTO IsIlanlari
(PozisyonID, IlanBasligi,IlanAciklamasi, YayinTarihi,
    SonBasvuruTarihi, CalismaSekli, Konum)
VALUES
( 21,
    N'Yapay Zekâ Mühendisi İş İlanı',
    N'Yapay zekâ ve makine öğrenmesi modelleri geliştirecek ekip arkadaşı aranıyor.',
    '2026-10-20','2026-11-20',
    N'Hibrit',N'Kayseri'),
(22,
    N'Veri Analisti İş İlanı',
    N'Veri analizi, raporlama ve veri görselleştirme süreçlerinde görev alacak aday aranıyor.',
    '2026-10-21','2026-11-25',
    N'Uzaktan',N'Kayseri'),
(23,
    N'Siber Güvenlik Uzmanı İş İlanı',
    N'Sistem güvenliğini sağlayacak ve güvenlik açıklarını analiz edecek aday aranıyor.',
    '2026-10-22','2026-11-28',
    N'Ofisten', N'Kayseri'),
(24,
    N'DevOps Mühendisi İş İlanı',
    N'Yazılım dağıtımı ve otomasyon süreçlerinde görev alacak aday aranıyor.',
    '2026-10-23','2026-11-30',
    N'Hibrit',N'Kayseri');

INSERT INTO IsBasvurulari
(IsIlaniID,Ad,Soyad,Eposta,Telefon,BasvuruTarihi,
Kaynak,Durum,DegerlendirmeNotu)
VALUES
(1,
    N'Ada',N'Yalçın',
    N'ada.ylmz@gmail.com',
    N'05550000001',
    '2026-10-23',
    N'Kariyer Sitesi',
    N'Yeni',
    N'Başvuru incelenecek.'),
(2,
    N'Zeynep',N'Kaya',
    N'zeynep.kaya@gmail.com',
    N'05550000002',
    '2026-10-22',
    N'LinkedIn',
    N'Ön Değerlendirme',
    N'Ön değerlendirme bekliyor.'),
(3,
    N'Mert',N'Üstün',
    N'mert.demir@gmail.com',
    N'05550000003',
    '2026-10-21',
    N'Kariyer Sitesi',
    N'Olumlu',
    N'Teknik görüşmeye davet edilebilir.'),
(4,
    N'Suna',N'Şahin',
    N'elif.sahin@gmail.com',
    N'05550000004',
    '2026-10-20',
    N'Şirket Web Sitesi',
    N'Mülakat',
    N'Başvuru değerlendirme sırasında.');

    INSERT INTO DevamKayitlari
(CalisanID, Tarih, GirisSaati, CikisSaati, Durum, Aciklama)
VALUES
(1, '2026-10-23', '08:30', '17:30',
 N'Geldi', N'Normal çalışma günü'),

(2, '2026-10-23', '08:45', '17:30',
 N'Geç Geldi', N'15 dakika geç giriş yaptı'),

(3, '2026-10-23', '08:30', '17:00',
 N'Geldi', N'Normal çalışma günü'),

(4, '2026-10-23', NULL, NULL,
 N'İzinli', N'İzin kaydı mevcut'),

(5, '2026-10-22', '08:30', '17:30',
 N'Uzaktan', N'Normal uzaktan çalışma günü'),

(6, '2026-10-22', '08:40', '17:30',
 N'Geç Geldi', N'10 dakika geç giriş yaptı');

 INSERT INTO PerformansDegerlendirmeleri
(CalisanID,DegerlendirenKullaniciID,DegerlendirmeTarihi,
    IsKalitesi,TakimCalismasi,Iletisim,HedefGerceklesme,GenelPuan,Yorum)
VALUES
(1, 1, '2026-10-23', 5, 5, 4, 5, 4.75,
 N'Başarılı bir performans sergiledi.'),

(2, 1, '2026-10-22', 4, 5, 4, 4, 4.25,
 N'Takım çalışması güçlü.'),

(3, 1, '2026-10-21', 4, 4, 5, 4, 4.25,
 N'İletişim becerileri başarılı.'),

(4, 1, '2026-10-20', 3, 4, 4, 3, 3.50,
 N'Gelişime açık alanları bulunuyor.');
 
