![image](https://github.com/user-attachments/assets/044bd2b7-0e4e-4bac-9f21-eba39ca7dc85)<h1><strong>Xüsusi bəyan edilmiş interface-lər</strong></h1>

<p>C#-da bəzi interface-lər vardır ki, əvvəlcədən .Net altında özəl olaraq bəyan edilmiş və bizlərin xidmətinə verilmişdir. Bu interface sayəsində bir class və ya bir struct .Net kitabxanası tərəfindən bəyan edilmiş olan müəyyən davranışları həyata keçiriə bilirik. 
Məsələn, IClonable interface-i bir obyektin klonlana bildiyini ifadə edir.
Ya da İdisposable intetfacesi-ilə bir obyekti dispos edilə bilən edə bilirik. .Net arxitekturasında bu interface-i istifadə edən class-lar ya struct-larda using blokunu istifadə edə bilirik.
Bu və bu kimi əvvəlcədən özəl bəyan edilmiş olan interface-lər sayəsində class-lar və struct-lar üzərində C#-ın fərqli dil özəlliklərini istifadə edə bilər və dilin irəli səviyyə özəlliklərini işə sala bilərik.
Bizlər əsasən aşağıdakı interface-ləri istifadə edəcəyik</p>

<ul>
  <li>IComparer</li>
  <li>IComparable</li>
  <li>IClonable</li>
  <li>IEnumerator</li>
  <li>IEnumerable</li>
  <li>IClonable</li>
  <li>IDisposable</li>
  <li>INotifyPropertyChanged</li>
  <li>IEqutable</li>
</ul>
<hr/>

<h2><strong>IComparer Interface-i:</strong></h2>
IComparer interface-i iki obyekti qarşılaşdırmaq üçün istifadə edilən bir interface-dir.
Bu interface sayəsində xüsusilə sıralama işlərində və ya xüsusi qarşılaşdırma mətiqi gərəkdirən hallarda özəl davranışlar yaza bilərik. Bu interface-nin həm generic həm də non-generic forması mövcuddur. 
Sual versək ki, bu interface-i harada istifadə edəcəyik?
Bu interface-i istər iki obyektin dəyərlərini qarşılaşdırmaq üçün və ya bir collection içərisində sıralama eləmək üçün istifadə edə bilərik.
.Net arxitekturasında collection-larda sıralama məntiqi yeritmək istəyiriksə, yəni obyektləri öz aralarında müqayisə edərək qarşılaşdıraraq bir əməliyyat etmək istərsək, bu zaman IComparer interface-i bizə optimal bir həll verəcəkdir.

<hr/>
<div style = "width: 500px; margin:20px">
  <img  style="width: 500px" src = "https://github.com/user-attachments/assets/6a5612fa-65a2-406e-88e4-99d5b443c35e"/>
</div>
</hr>

Bu şəkildə 2 obyekt bəyan edirik. İndi bu 2 obyekti qarşılaşdıracağıqsa, bu obyektləri hansı özəlliklərinə görə qarşılaşdıracağımızın məsuliyyətini üzərinə götürən bir class yazmalıyıq.
</hr>

<div style = "width: 600px; margin: 20px;">
  <img style="width: 500px"  src = "https://github.com/user-attachments/assets/e2bb7db4-ab20-467d-b18c-02d9a712d46f"/>
</div>
</hr>
Buradakı məntiq budur ki, biz burada age dəyərinə görə qarşılaşdırma edirik. Buradakı Compare metodunun birinci parametrin dəyəri ikinci parametrin dəyərindən böyük olarsa, geriyə “1” dəyərini dönəcək. Bir birincə bərabər olarsa, “0”, birinci parametr ikinci parametrdən kiçik olarsa, “-1” dəyərini dönəcək. Bizlər <strong>AgeComparer</strong> class-ını hər yerdə istifadə edə bilərik.
</hr>


<div style = "width: 500px; margin: 20px; margin:20px">
  <img style="width: 500px"  src = "https://github.com/user-attachments/assets/1773a4bb-335b-493f-9fc1-c9f5179940c8"/>
</div>
</hr>

Birdən çox class-ımız olsa və bunlar arasında bir colleciton içərisində sıralama etmək istəsək. Bu zaman aşağıdakı kimi edə bilərik.

</hr>
<div style = "width: 500px; margin: 20px; margin:20px">
  <img style="width: 500px"  src = "https://github.com/user-attachments/assets/088cd701-23ec-4f6d-ac68-65ffe02c2e7d"/>
</div>
</hr>
<br>

<h2><strong>IComparable Interface-i:</strong></h2>

<p>
  Bu interface bir obyetkin başqa bir obyektlə qarşılaşdırıla biləcək olduğunu müəyyən etmək üçün istifadə edilir. IComparer iki obyektin qaşılaşdırılmasını 2 fərqli obyektə yükləyir,   
  IComparable interfeysi isə əlaqəli obyektin qarşılaşdırıla bilən olub olmadığını ifadə edir. Bu zaman əsas obyektin özü “IComparable” interfeysini implement edir. 
</p>
<div style = "width: 500px; margin: 20px; margin:20px">
  <img style="width: 500px" src ="https://github.com/user-attachments/assets/f87b9d20-9b2c-43d7-b665-4b7cc23b0ce5"/>
</div>
<br>
<hr>


<h2><strong>ICloneable Interface-i:</strong></h2>

<p>
  ICloneable interfeysi ilə bir obyektin kopyalana bilən (clone) olduğunu müəyyən etmək üçün istifadə edilən bir interfeysdir. Clone (Klonlamaq nə deməkdir?), yəni həmin obyektin   
  prototipini almaq deməkdir. Bu bir design pattern-dir Prototype design pattern-də istifadə edilir.
</p>
<p>
  <strong>
    Bir obyektin klonlanması o zaman mütləq lazım olar ki, obyekti yaradarkən constructor-ı çox parametrli obyektdirsə və bu obyekti dəfələrlə yaratmalıyıqsa, bu zaman constructor-un 
    tələb etdiyi dəyərləri təkrar-təkrar girməliyik. Belə bir halda mövcud obyektin klonlanması və lazımi property-lərin girilməsi practice cəhətdən daha əlverişlidir.
  </strong>
</p>

<div style = "width: 500px; margin: 20px; margin:20px">
  <img style="width: 500px" src ="https://github.com/user-attachments/assets/4af63593-53dd-4de8-858f-10e74fcd478c"/>
</div>
<p>
  C#-da bu interface çox da məsləhət görülmür, buna görə də Prototype design pattern istifadə edilməsi məsləhət görülür.
</p>
<br>
<hr>

##  INotifyPropertyChanged
<h2><strong>INotifyPropertyChanged Interface-i:</strong></h2>
<hr>
<p>
  InotifyPropertyChanged interfeysi bir class-ın property dəyərləri dəyişdirildikdə, bu dəyişiklikləri xaricə bildirmək üçün istifadə edilir.<br>
  Bu adətən user interfeysində avtomatik update eləmək məqsədilə istifadə edilən data binding hallarında istifadə olunur.
</p>

<div style = "width: 500px; margin: 20px; margin:20px">
  <img style="width: 500px" src ="https://github.com/user-attachments/assets/2e82a27a-3411-4faa-bc95-25e96e55e69e"/>
</div>
<p>
  Görüldüyü kimi bu interface içərisində property-nin dəyişməsini bildirən bir event olduğunu görə bilərik. 
</p>
  <div style = "width: 500px; margin: 20px; margin:20px">
    <img style="width: 500px" src ="https://github.com/user-attachments/assets/38319ff7-ced4-4975-8593-c9573a3f87b5"/>
  </div>
  <br>
  <hr>
  <div style = "width: 500px; margin: 20px; margin:20px">
    <img style="width: 500px" src ="https://github.com/user-attachments/assets/7f6de76f-72d2-4898-845b-d3f58f243a05"/>
  </div>
  <div style = "width: 500px; margin: 20px; margin:20px">
    <img style="width: 500px" src ="https://github.com/user-attachments/assets/0516c64b-9403-4ca6-919c-d67b5d31a212"/>
  </div>
  <br>
  <hr>
  
//#  IEqutable
<h2><strong>IEquatable Interface-i:</strong></h2>
<hr>
<p>
IEquatable interfeysi bir obyektin digər obyektlə bərabərlik nöqteyi-nəzərdən qarşılaşdırıla bilən olduğunu müəyyən etmək üçün istifadə edilir.
</p>
<p>
  Bu interfeys <strong>Equals</strong> metodunu istifadə edirik. İEquatable interfeysi özəlliklə collection class-ları kimi tiplərdə istifadə edildikdə performans cəhətdən daha effektiv bir bərabərlik kontrolu edir.
</p>
<div style = "width: 500px; margin: 20px; margin:20px">
  <img style="width: 500px" src ="https://github.com/user-attachments/assets/eae415d4-7c6d-4bcb-91ae-10a490952088"/>
</div>
<p>
  Belə hallar üçün Recordlar istifadə etmək daha uyğundur, çünki record-larda property-lər daha ön plandadır.
</p>
  <br>
  <hr>

  // # IEnumerable
<h2><strong>IEnumerable Interface-i:</strong></h2>
<hr>
<p>
  IEnumerable interfeysi bir obyektin üzərində foreach iterasiyası ilə gəzinməyə imkan verən bir interfeysdir. 
</p>
<p>
 <strong>
   Hansısa bir strukturun foreach ilə istifadə edilə bilməsi üçün, həmən strukturun class-ı IEnumerable interfeysindəin implement edilməlidir.
 </strong>
  Bu özəlliyi tətikləyən GetEnumerator() metodudur.
</p>

<div style = "width: 500px; margin: 20px; margin:20px">
  <img style="width: 500px" src ="https://github.com/user-attachments/assets/164a2c3d-99d9-4c3f-b309-e4e1ee6b2c52"/>
</div>
<p>
  Əslində burada bir iterasiya əməliyyatı etmək istəyiriksə, geriyə İEnumerator dönən bir GetEnumerator() metodu yazmağımız kifayyətdir.
</p>
<p>
  Həmçinin İEnumerable class-lara yaddaş üzərindən sorğulana bilən bir collection strukturu da qazandırır. Yəni bir başqa sözlə İEnumerable, yaddaş üzərindəki collection-larda sorğuların işə salınmasını 
  yerinə yetirir.
</p>
<br>
<hr>

// # IDisposabel
<h2><strong>IDisposeble Interface-i:</strong></h2>
<hr>
<p>
  IDisposeble interfeysi .Net-də yaddaş idarəsini kontrol etmək üçün istifadə edilən bir interfeysdir. Bu interface ilə, bir class-ın qaynaqlarını sərbəst buraxmasını, yəni dispose etməsini edə bilərik. Bunun üçün isə using keyword-ünü istifadə edə bilərik.
</p>
<p>
  Dispose anlayışı geniş bir anlayışdır. Bu əməliyyat obyektin yox edilməsindən bir öncəki addımdır.
</p>
<hr>
<div style = "width: 500px; margin: 20px; margin:20px">
  <img style="width: 500px" src ="https://github.com/user-attachments/assets/3f800d4e-11de-4e2c-9920-e0ef2f00196c"/>
</div>
<hr>
  <div style = "width: 500px; margin: 20px; margin:20px">
    <img style="width: 500px" src = "https://github.com/user-attachments/assets/84a3dc51-c607-43a7-99fb-600f30349470"/ >
  </div>

  <p>Burada artıq using keyword-ünü istifadə edə bilərik.</p>
