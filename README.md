# Buildly
Want to build a house or an apartment? Buildly can help you estimate the costs!

## Technology
This project is dependent on business logic rather than performance or a unified technology across the back-end and front-end. Additionally, the number of users is not expected to be very large. Typical users do not expect high performance, and the volume of data is low. It is important that the source code is easily understandable for non-professional software engineers. As a result, .NET/C# has been chosen over Node.js/JavaScript. For the same reasons mentioned earlier, Blazor Server has been chosen over a solution involving separate back-end and front-end. Blazor Server provides the comfort of ASP.NET MVC but is still perceived as a single-page application (SPA) by end users.

## Purpose
The primary objective of Buildly is to offer estimation services for the construction industry in Iran, with a particular focus on small residential buildings. Additionally, this product aims to showcase strong software engineering skills in the .NET and Blazor Server domains. It aspires to implement principles such as SOLID and other recognized best practices throughout the project.

## Contact
Just send an email to "afshar.mohebbi@gmail.com".

## بیلدلی چه کار می کند؟
ساخت و ساز در ایران کار رایجی است. هر کجا که باشید احتمالا خانه های کلنگی دور و بر خود را می بینید که تخریب شده و از اول ساخته می شوند. شهرها و شهرک های اطراف شهرهای بزرگ پر از پروژه های ساخت و ساز هستند. با این که شرکت های ساخت و ساز حضور پر رنگی در صنعت ساختمان دارند، اما، تعداد زیادی از ساختمان ها توسط سازنده ها و پیمانکاران محلی ساخته می شوند. هنوز هم در خیلی از مناطق این خود مالکین هستند که اقدام به ساخت زمین یا باسازی ملک قدیمی خود می کنند. یکی از اولین اقدامات یک پروژه ساخت و ساز، تخمین هزینه های ساخت با توجه به قیمت زمین، هزینه های اداری، میزان تراکم در دسترس، مصالح و دستمزد است. هدف بیلدلی دقیقا کمک  به انجام این محاسبات است. تمرکز بیلدلی بیشتر بر روی ساختمان های مسکونی با تعداد طبقات محدود است که عمدتا توسط سازندگان محلی و مالکان ساخته می شود. طبیعتا مخاطب اصلی این محصول کشور ایران است چون این محصول بر اساس قوانین شهرداری های ایران، سازمان های دولتی ایران، عرف ساخت و ساز در ایران و سلایق خاص ایرانی ها ساخته می شود.

## چرا بیلدلی؟
شاید بتوان با یک فایل اکسل هم میزان میلگرد و بتن ریزی و هزینه تاسیسات و نهایتا هزینه تمام شده یک پروژه ساخت و ساز را محاسبه کرد. اما فایل اکسل نمی تواند:
* محاسبات خیلی پیچیده را انجام دهد.
* کار با آن برای کسانی که مسلط به اکسل نیستند سخت است.
* به اشتراک گذاری آن می تواند سخت باشد
* برای کسانی که وقت و حوصله یک کارشناس IT را ندارند همیشه خطر از دست رفتن اطلاعات هست.
* نگه داشتن history برای یک فایل اکسل کار آسانی نیست. شما نمی توانید به راحتی ببینید پارامترهای یک پروژه در طول زمان چه تغییری پیدا کرده.
* با آن که اکسل امکان کار تیمی را هم فراهم می کند اما برای عموم کاربران در این حوزه کاری سخت است که بتوانند به شکل گروهی روی یک پروژه واحد کار کنند.

علاوه بر همه این مزیت ها، این امکان در آینده متصور است که:
* بتوان از طریق مکانیزم templating کار ایجاد پروژه ها را راحت تر کرد.
* با امکان استفاده از third party api اطلاعات تکمیلی مثل قیمت روز سیمان یا آهن را به طور اتوماتیک در پروژه اعمال کرد.
* بتوان بعضی از پروژه های مفید را به صورت پولی در اختیار دیگر کاربران قرار داد و کسب در آمد کرد.
* با استفاده از ایده gamification کار با آن را برای کاربران جذاب تر کرد.
* امروز که AI توانسته همه جا خودش را نشان دهد، شاید بتوان در بیلدلی هم برای اتومات کردن و راحت تر کردن کارها از آن استفاده کرد.

## رقبا
فایل های حرفه ای اکسل تنها رقبای بیلدلی نیستند. قاعدتا در صنعتی با قدمت صنعت ساختمان، راه حل ها و نرم افزارهای زیادی برای انجام چنین محاسباتی وجود داشته باشد. اصلا موضوع متره و برآورد برای همین منظور وجود دارد. اما مشکل این است که یک مهندس نرم افزار نوعی ممکن است دانش کافی راجع به نرم افزارهای حوزه مهندس عمران نداشته باشد.

## گام بعدی
برای گام های بعدی این ایده وجود دارد که بتوان با پارامترهای ورودی مشخص و با توجه به طرح تفصیلی هر شهر و هر روستا، بهنیه ترین پلان و مصالح را به دست آورد. این موضوع فقط بحث محاسبات و تخمین هزینه ها نیست، بلکه انجام محاسبات با پارامترهای مختلف و انتخاب بهترین حالت ممکن است. هر شهر و شهرداری یا روستا و منطقه ای قوانین خاص خود را برای ساخت ساز دارند. از جمله حداکثر تراکم، حداقل اندازه سقف، جانمایی پارکینگ و غیره و غیره. پیدا کم هزینه ترین یا بهینه ترین نقشه یا مصالح ممکن می تواند کمک زیادی به مالکان و سازندگان انجام بدهد.

## Instructions
```bash
# to add migrations
dotnet ef --startup-project ..\Buildly.UI\Buildly.UI.csproj migrations add Init

# to update the database
dotnet ef --startup-project ..\Buildly.UI\Buildly.UI.csproj database update
```