# Treasure Garden

## Anggota Tim dan Peran
| Nama | NIM | Peranan dalam Proyek |
|------|-----|----------------------|
| Laili Nur Fadhillah Rohminatin | G64190024 | Game Designer |
| Yusuf Pradnya Darpita | G64190049 | Game Artist |
| Andra Setiyo Wicaksono | G64190081 | Game Programmer |

## Deskripsi Singkat Produk
Produk yang akan kami kembangkan adalah berupa game dengan 3D effects, dimana nama produk kami adalah Treasure Garden. Berlatar belakang seorang tabib muda, yang harus mencari berbagai tanaman herbal untuk kebutuhan penyakit yang diderita pasiennya. Tabib tersebut menggunakan mini map untuk menemukan lokasi dari tanaman herbal yang dibutuhkan, dan dianggap sukses serta dapat keluar dari kebun tersebut jika dia berhasil mendapatkan jenis tanaman herbal yang ditentukan sebelum waktu habis.

## Game Rules
- Pemain dapat berjalan ke depan, mundur, berlari, memutar badan ke kanan dan ke kiri, serta mengambil tanaman herbal.
- Setiap kali bermain, pemain harus mencari 5 tanaman herbal yang akan di random setiap sesi.
- Setiap sesi memiliki waktu maksimal 10 menit, tabib harus mencari kelima tanaman sebelum waktu habis.

## Proses Pengembangan Produk

  Proses yang kami lakukan dalam mengembangkan produk adalah pembagian tugas dan diskusi singkat tentang ide dan gambaran besar saat pertama kali meet kelompok, dimana Laili sebagai Game Designer (mendesain scene, font 2D, story, main menu (play, quit), dan ending scene), Yusuf sebagai Game Artist (menerapkan karakter, movement karakter, serta map dan lightening, dan sounds), serta Andra sebagai Game Programmer yang mengatur segala jenis kode program untuk mendukung jalannya produk tersebut.
  
  Pada minggu selanjutnya, kami mencari tema serta membuat deskripsi produk dan game rules, serta menentukan judul dari produk tersebut, yaitu Treasure Garden. Kami mengembangkan produk Game berbasis 3D objects. Setelahnya, merupakan pembuatan karakter dan pembuatan map yang dilakukan oleh Game Artist. Pada minggu setelahnya, kami mulai mengembangkan dan menambahkan lagi untuk aset-aset seperti tumbuhan, terrain, ground, dan movement. Setelahnya, kami mengembangkan penempatan scene dan mulai membuat codingan untuk produk game kami. Kami memiliki jadwal rutin untuk meet kelompok setiap satu minggu sekali, yaitu setiap hari Rabu pukul 15.30 sampai selesai berdiskusi, namun terkadang bisa dua sampai tiga minggu sekali.
  
  Berikut adalah lampiran dari jadwal diskusi kelompok yang kami lakukan setiap minggu :
![image](https://user-images.githubusercontent.com/78837351/146873938-a7024543-0db4-467d-9ac5-433c0285d41c.png)
  
  Produk kami sendiri adalah game 3D objects dengan berlatar belakang seorang tabib yang ingin meracik obat yang berupa beberapa tanaman herbal untuk pengobatan pasiennya. Tabib tersebut memiliki waktu sepuluh menit untuk mencari lima buah tanaman di dalam map yang telah disediakan. Tabib tersebut berhasil jika menemukan lima tanaman herbal tersebut sebelum waktu sepuluh menit berakhir. Tabib tersebut kalah dan tidak dapat menyelesaikan peracikan obat jika tidak dapat menemukan lima tanaman pada waktu yang ditentukan.
  
  Tutorial yang kami dapatkan berasal dari youtube dengan sumber berbagai video baik tutorial yang berbahasa Inggris maupun berbahasa Indonesia, internet, web official unity, dan source yang kami dapatkan dari asisten praktikum, dosen, github, serta beberapa sumber lain dari discord Grafika Komputer.
Untuk komunikasi, kelompok kami memiliki komunikasi yang cukup baik, dan pembagian tugas yang cukup jelas. Karena seperti yang kami katakan sebelumnya, kami secara rutin bertanya di grup dan mengadakan meet atau group call, dan saling membantu jika salah satu ada yang kesusahan.
Kami menggabungkan dan memodifikasi (mix) semua asset yang kami dapatkan secara gratis dari unity ke dalam proyek kami (karena tidak banyak asset unity free yang menggunakan 3D Objects). Untuk font, kami mengimport asset dari asset store dan text mesh Pro.


## Screenshot Produk

-main menu
![image](https://user-images.githubusercontent.com/78837351/146872968-ae8c3076-7ea2-42b9-8949-48c5df7748bf.png)

-story
![image](https://user-images.githubusercontent.com/78837351/146873043-9be76ec7-ed2f-49e7-99b3-5ee873d3fc80.png)

-game
![image](https://user-images.githubusercontent.com/78837351/146873147-f4b22968-bf76-42f3-97c4-dd6504aee3d9.png)

## Technology Stack yang Digunakan

![image](https://user-images.githubusercontent.com/78837351/146873181-feecd30d-4a9a-4153-9b87-1f952e9cc603.png)


## Teknik Grafika Komputer yang Digunakan
| Teknik | Deskripsi | Contoh Ilustrasi |
|--------|-----------|------------------|
| Objek 2D | Font yang digunakan untuk memberi petunjuk di awal game dan penunjuk tentang tanaman yang sudah dikumpulkan dan sisa waktu | ![image](https://user-images.githubusercontent.com/78837351/146873330-017a6b35-06cc-4eaa-a1b0-bf57c17b7fb4.png) |
| Objek 3D | Player, Tree, Ground, Mist, Plant | ![image](https://user-images.githubusercontent.com/78837351/146873392-b6d39862-1964-4353-b5ae-e5eb0dba12fc.png) |
| Transformasi | Translation yang digunakan untuk random posisi dari tanaman setiap kali game dimulai | ![image](https://user-images.githubusercontent.com/78837351/146873542-25d8faa2-40b2-4c02-b555-028d04cfe523.png) |
| Pencahayaan | Skybox digunakan untuk pencahayaan pada environment sehingga terlihat seperti langit, Directional Light digunakan untuk pencahayaan matahari secara langsung | ![image](https://user-images.githubusercontent.com/78837351/146873600-010452e9-d5c9-4b9c-924c-6da554488942.png) |
| Interaksi Mouse | Mouse Y, apabila user menggeser mouse searah sumbu Y maka sudut kamera akan berubah sesuai dengan pergeseran | ![image](https://user-images.githubusercontent.com/78837351/146873643-c51d9f35-fae7-4afe-a6ad-e65f73996e02.png) |
| Interaksi Keyboard | Up Arrow digunakan untuk menggerakan player ke depan, Down Arrow digunakan untuk menggerakan player ke belakang, Right Arrow digunakan untuk memutar perspektif ke kanan, Left Arrow digunakan untuk memutar perspektif ke kiri | ![image](https://user-images.githubusercontent.com/78837351/146873686-f3d6b171-d295-4753-8b64-30a564c30f7c.png) |
| Windowing | Game kali hanya bisa digunakan dengan menggunakan screen PC/laptop | ![image](https://user-images.githubusercontent.com/78837351/146873719-99c1e005-38df-407e-9cd3-128dd157ea5f.png) |
| Perspektif | Third Person dimana kamera akan mengikuti player kemanapun | ![image](https://user-images.githubusercontent.com/78837351/146873774-a93af898-c1e1-432c-b0d2-8667a0976104.png) |
| Fraktal | - | - |
| Tekstur | Ground yang digunakan untuk jalan setapak, Grass yang digunakan untuk menambahkan efek rumput pada terrain, Dirt yang digunakan untuk membuat efek jalanan yang kotor di hutan | ![image](https://user-images.githubusercontent.com/78837351/146874362-4daf68f8-b7dc-45bd-9563-14aaa1d63bb7.png) |

## Informasi Proyek
| Informasi | URL |
|-----------|-----|
| Github | https://github.com/andrawicaksonoipb/treasure-garden |
| Video Demo | https://drive.google.com/file/d/1lOKDT35d8NAkygoXVS8KuO1KVSUSvmhu/view?usp=sharing |

## Sumber Asset :
https://assetstore.unity.com/packages/2d/textures-materials/floors/outdoor-ground-textures-12555

https://assetstore.unity.com/packages/2d/textures-materials/nature/grass-flowers-pack-free-138810

https://assetstore.unity.com/packages/3d/vegetation/trees/conifers-botd-142076

https://assetstore.unity.com/packages/2d/textures-materials/nature/terrain-tools-sample-asset-pack-145808

https://assetstore.unity.com/packages/3d/environments/fantasy/angel-statue-27594

https://assetstore.unity.com/packages/3d/vegetation/plants/fantasy-plants-28858

https://assetstore.unity.com/packages/2d/fonts/free-pixel-font-thaleah-140059
