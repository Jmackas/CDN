
/* Fade in Elements */
  $(window).scroll(function() {
    $(".title").each(function(i) {
      var bottom_of_object = $(this).offset().top + $(this).outerHeight();
      var bottom_of_window = $(window).scrollTop() + $(window).height();

      if (bottom_of_window > bottom_of_object) {
        $(this).animate({ opacity: "1" }, 500);
      }
    });
  });
});