4. COURSE — KURS MA’LUMOTLARI
Course classini yarating. Kurs nomi va darslar sonini faqat o‘qiladigan public propertylarda ko‘rsating. Quyidagi uchta constructor overloadini yozing:

Course() — "C# asoslari" nomli, 12 darsli kurs yaratsin.
Course(string title) — berilgan nom bilan 12 darsli kurs yaratsin.
Course(string title, int lessonCount) — nom va darslar sonini o‘rnatsin.
Birinchi ikki constructor boshlang‘ich qiymatlarni uchinchi constructorga this(...) orqali uzatsin. Uchinchi constructor bo‘sh yoki faqat probellardan iborat nom uchun ArgumentException, 0 yoki manfiy darslar soni uchun ArgumentOutOfRangeException chiqarsin. Constructor objectni yaroqsiz holatda yaratmasin.

string GetInfo() methodi kursni Title — LessonCount ta dars shaklida qaytarsin. Uchta overload orqali quyidagi kurslarni yarating va ma’lumotlarini chiqaring:

Constructor chaqiruvi	Kutilgan natija
new Course()	C# asoslari — 12 ta dars
new Course("OOP")	OOP — 12 ta dars
new Course("LINQ", 8)	LINQ — 8 ta dars
new Course("   ")	ArgumentException
new Course("OOP", 0)	ArgumentOutOfRangeException
Yaroqsiz argumentlarni tekshirish uchun oxirgi ikki constructor chaqiruvini alohida ishga tushiring. Title va LessonCount propertylariga object yaratilgandan keyin qiymat yozib ko‘ring: ular faqat o‘qiladigan bo‘lishi kerak.