
		$(window).on('load', function() { // makes sure the whole site is loaded 
            $('#status').fadeOut(); // will first fade out the loading animation 
            $('#preloader').delay(350).fadeOut('slow'); // will fade out the white DIV that covers the website. 
            $('body').delay(350).css({'overflow':'visible'});
        });
		
$(window).scroll(function() {
if ($(this).scrollTop() > 1){  
    $('#header').addClass("fixed");
  }
  else{
    $('#header').removeClass("fixed");
  }
});

jQuery("li.search").click(function() {
            jQuery("#header .search-box").is(":visible") ? jQuery("#header .search-box").fadeOut(300) : (jQuery(".search-box").fadeIn(300), jQuery("#header .search-box form input").focus(), jQuery("div.quick-cart-box").is(":visible") && jQuery("div.quick-cart-box").fadeOut(300))
        }), 0 != jQuery("#header li.search").size() && (jQuery("#header .search-box, #header li.search").on("click", function(e) {
            e.stopPropagation()
        }), jQuery("body").on("click", function() {
            jQuery(".search-box").is(":visible") && jQuery("#header .search-box").fadeOut(300)
        })), jQuery(document).bind("click", function() {
            jQuery(".search-box").is(":visible") && jQuery("#header .search-box").fadeOut(300)
        }), jQuery("#closeSearch").bind("click", function(e) {
            e.preventDefault(), jQuery("#header .search-box").fadeOut(300)
        }), jQuery("button#page-menu-mobile").bind("click", function() {
            jQuery(this).next("ul").slideToggle(150)
        }), jQuery("li.quick-cart>a").click(function(e) {
            e.preventDefault();
            var t = jQuery("div.quick-cart-box");
            t.is(":visible") ? t.fadeOut(300) : (t.fadeIn(300), jQuery(".search-box").is(":visible") && jQuery(".search-box").fadeOut(300))
        }), 0 != jQuery("li.quick-cart>a").size() && (jQuery("li.quick-cart").on("click", function(e) {
            e.stopPropagation()
        }), jQuery("body").on("click", function() {
            jQuery("div.quick-cart-box").is(":visible") && jQuery("div.quick-cart-box").fadeOut(300)
        }));
		
		// DEMO Swticher Base
	jQuery('.demo_changer .demo-icon').click(function(){

		if(jQuery('.demo_changer').hasClass("active")){
			jQuery('.demo_changer').animate({"left":"-350px"},function(){
				jQuery('.demo_changer').toggleClass("active");
			});						
		}else{
			jQuery('.demo_changer').animate({"left":"0px"},function(){
				jQuery('.demo_changer').toggleClass("active");
			});			
		} 
	});
	$('.boxed_switch').click(function(){
		if(this.value=="boxed")
		{
			$('body').addClass('boxed');
		}
		else
		{
			$('body').removeClass('boxed');
		}
		$(window).resize();
	});
	
 /* jQuery(document).ready(function( $ ) {
        jquery('.counter').counterUp({
            delay: 10,
            time: 100
        });
    });
  */
  
  

