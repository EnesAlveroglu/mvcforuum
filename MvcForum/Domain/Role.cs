using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace MvcForum.Domain;

public class Role : IdentityRole<Guid> //(üyelik sistemi) iki tane entity'si(varlık) var bunlardan birisi Role üyelik sistemi bunla ile ilgili her şeyi IdentityRole classı yapıyor. Ondan miras alıyoruz.IdentityRole classını kullanabilmek için Microsoft.AspNetCore.Identity paketini nugetten indiriyoruz.Microsoftun son iki versiyonun da ismini doğru yazarsak pakaeti kendisi buluyor.Doğru yazdıktan sonra ctrl+(nokta) ya basıyoruz ve paketi kendisi buluyor(using Microsoft.AspNetCore.Identity). Guid(benzersiz ıd) kullanıcağımız için <Guid> şeklinde yanına ekledik. yeni bir action tanmladığımızda şu roldeki adamlar bu actionu çalıştırabilir diyicez.(rolü masa gibi düşünün.) Masa başında oturanlar bu roldeki kişiler. Bu kişiler o masanın yetkilerini kullanır. bir kişi birden fazla rolde olabilir. bir rolde birden fazla kişi olabilir.

{

}