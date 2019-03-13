jQuery(document).ready(function($) {

  // Accordion Toggle
  var iconOpen = 'icon-minus', iconClose = 'icon-plus';

  $(document).on('show.bs.collapse hide.bs.collapse', '.accordion', function(e) {
    var $target = $(e.target)
    $target.siblings('.accordion-heading')
      .find('em').toggleClass(iconOpen + ' ' + iconClose);
    if (e.type == 'show')
      $target.prev('.accordion-heading').find('.accordion-toggle').addClass('active');
    if (e.type == 'hide')
      $(this).find('.accordion-toggle').not($target).removeClass('active');
  });

  // DM Top
  $(window).scroll(function() {
    if ($(this).scrollTop() > 1) {
      $('.dmtop').css({
        bottom: "25px"
      });
    } else {
      $('.dmtop').css({
        bottom: "-100px"
      });
    }
  });

  $('.dmtop').click(function() {
    $('html, body').animate({
      scrollTop: '0px'
    }, 800);
    return false;
  });

  // DM Menu
  $('#nav').affix({
    offset: {
      top: $('#nav').offset().top
    }
  });

  // Menu
  $(".panel a").click(function(e) {
    e.preventDefault();
    var style = $(this).attr("class");
    $(".jetmenu").removeAttr("class").addClass("jetmenu").addClass(style);
  });
  $().jetmenu();

  // Facts
  function count($this) {
    var current = parseInt($this.html(), 10);
    current = current + 1; /* Where 50 is increment */

    $this.html(++current);
    if (current > $this.data('count')) {
      $this.html($this.data('count'));
    } else {
      setTimeout(function() {
        count($this)
      }, 50);
    }
  }

  $(".stat-count").each(function() {
    $(this).data('count', parseInt($(this).html(), 10));
    $(this).html('0');
    count($(this));
  });

  // Tooltip
  $('.social_buttons, .client').tooltip({
    selector: "a[data-toggle=tooltip]"
  })

  $('.social_buttons, .client').tooltip();

  // prettyPhoto
  $(document).ready(function() {
    $('a[data-gal]').each(function() {
      $(this).attr('rel', $(this).data('gal'));
    });
    $("a[data-rel^='prettyPhoto']").prettyPhoto({
      animationSpeed: 'slow',
      theme: 'light_square',
      slideshow: false,
      overlay_gallery: false,
      social_tools: false,
      deeplinking: false
    });
  });

  // Hover and Carousel
  $('.owl-carousel > .item ').each(function() {
    $(this).hoverdir();
  });
  $("#owl-demo").owlCarousel({
    items: 5,
    autoPlay: 3000, //Set AutoPlay to 3 seconds
    stopOnHover: true,
    lazyLoad: true,
    transitionStyle: "fade",
    navigation: true,
    pagination: false,
  });

  // tooltip demo
  $("[data-toggle=tooltip]").tooltip();

  // popover demo
  $("[data-toggle=popover]").popover();

  // Chart Effects;
	$('.chart').easyPieChart({
		easing: 'easeOutBounce',
		size : 180,
		animate : 2000,
		lineWidth : 10,
		lineCap : 'square',
		lineWidth : 18,
		barColor : '#3498db',
		trackColor : '#f9f9f9',
		scaleColor : false,
		onStep: function(from, to, percent) {
		$(this.el).find('.percent').text(Math.round(percent)+'%');
		}
	});

  // Popular Items Carousel
  $(document).ready(function() {
    $("#popularitems").owlCarousel({
      items: 3,
      lazyLoad: true,
      navigation: false
    });
  });

  // Hover and Carousel on Home #1
  $('.owl-carousel > .item ').each(function() {
    $(this).hoverdir();
  });

  $("#owl-related").owlCarousel({
    items: 3,
    autoPlay: 3000, //Set AutoPlay to 3 seconds
    stopOnHover: true,
    lazyLoad: true,
    transitionStyle: "fade",
    navigation: true,
    pagination: false,
  });

  // Portfolio
  var $container = $('.portfolio'),
    $items = $container.find('.market-item'),
    portfolioLayout = 'fitRows';

  if ($container.hasClass('portfolio-centered')) {
    portfolioLayout = 'masonry';
  }

  $container.isotope({
    filter: '*',
    animationEngine: 'best-available',
    layoutMode: portfolioLayout,
    animationOptions: {
      duration: 750,
      easing: 'linear',
      queue: false
    },
    masonry: {}
  }, refreshWaypoints());

  function refreshWaypoints() {
    setTimeout(function() {}, 1000);
  }

  $('nav.portfolio-filter ul a').on('click', function() {
    var selector = $(this).attr('data-filter');
    $container.isotope({
      filter: selector
    }, refreshWaypoints());
    $('nav.portfolio-filter ul a').removeClass('active');
    $(this).addClass('active');
    return false;
  });

  function getColumnNumber() {
    var winWidth = $(window).width(),
      columnNumber = 2;
  }

  function setColumns() {
    var winWidth = $(window).width(),
      columnNumber = getColumnNumber(),
      itemWidth = Math.floor(winWidth / columnNumber);

    $container.find('.market-item').each(function() {
      $(this).css({
        width: itemWidth + 'px'
      });
    });
  }

  function setPortfolio() {
    setColumns();
    $container.isotope('reLayout');
  }

  $container.imagesLoaded(function() {
    setPortfolio();
  });

  $(window).on('resize', function() {
    setPortfolio();
  });

});


$(document).ready(function(e){
  $('.search-panel .dropdown-menu').find('a').click(function(e) {
  e.preventDefault();
  var param = $(this).attr("href").replace("#","");
  var concept = $(this).text();
  $('.search-panel span#search_concept').text(concept);
  $('.input-group #search_param').val(param);
});
});
/*collapse sec */
var acc = document.getElementsByClassName("accordionn");
		var i;

		for (i = 0; i < acc.length; i++) {
		  acc[i].addEventListener("click", function() {
		    this.classList.toggle("active");
		    var panel = this.nextElementSibling;
		    if (panel.style.maxHeight){
		      panel.style.maxHeight = null;
		    } else {
		      panel.style.maxHeight = panel.scrollHeight + "px";
		    } 
		  });
        }
/*animated*/

(function (d, J, K) {
    function P(a, b, d, l, j, h, c, n, q) {
        var t = !1; c = !0 === c && !0 === n; b = b || {}; b.original || (b.original = {}, t = !0); b.properties = b.properties || {}; b.secondary = b.secondary || {}; n = b.meta; for (var k = b.original, x = b.properties, Q = b.secondary, D = r.length - 1; 0 <= D; D--) {
            var F = r[D] + "transition-property", y = r[D] + "transition-duration", e = r[D] + "transition-timing-function"; d = c ? r[D] + "transform" : d; t && (k[F] = a.css(F) || "", k[y] = a.css(y) || "", k[e] = a.css(e) || ""); Q[d] = c ? !0 === q || !0 === G && !1 !== q && L ? "translate3d(" + n.left + "px, " + n.top +
                "px, 0)" : "translate(" + n.left + "px," + n.top + "px)" : h; x[F] = (x[F] ? x[F] + "," : "") + d; x[y] = (x[y] ? x[y] + "," : "") + l + "ms"; x[e] = (x[e] ? x[e] + "," : "") + j
        } return b
    } function B(a) { for (var b in a) return !1; return !0 } function R(a) { a = a.toUpperCase(); var b = { LI: "list-item", TR: "table-row", TD: "table-cell", TH: "table-cell", CAPTION: "table-caption", COL: "table-column", COLGROUP: "table-column-group", TFOOT: "table-footer-group", THEAD: "table-header-group", TBODY: "table-row-group" }; return "string" == typeof b[a] ? b[a] : "block" } function H(a) {
        return parseFloat(a.replace(a.match(/\D+$/),
            ""))
    } function M(a) { var b = !0; a.each(function (a, d) { return b = b && d.ownerDocument }); return b } var S = "top right bottom left opacity height width".split(" "), I = ["top", "right", "bottom", "left"], r = ["-webkit-", "-moz-", "-o-", ""], T = ["avoidTransforms", "useTranslate3d", "leaveTransforms"], U = /^([+-]=)?([\d+-.]+)(.*)$/, V = /([A-Z])/g, W = { secondary: {}, meta: { top: 0, right: 0, bottom: 0, left: 0 } }, N = null, C = !1, z = (document.body || document.documentElement).style, O = void 0 !== z.WebkitTransition || void 0 !== z.MozTransition || void 0 !== z.OTransition ||
        void 0 !== z.transition, L = "WebKitCSSMatrix" in window && "m11" in new WebKitCSSMatrix, G = L; d.expr && d.expr.filters && (N = d.expr.filters.animated, d.expr.filters.animated = function (a) { return d(a).data("events") && d(a).data("events")["webkitTransitionEnd oTransitionEnd transitionend"] ? !0 : N.call(this, a) }); d.extend({ toggle3DByDefault: function () { return G = !G }, toggleDisabledByDefault: function () { return C = !C }, setDisabledByDefault: function (a) { return C = a } }); d.fn.translation = function () {
            if (!this[0]) return null; var a = window.getComputedStyle(this[0],
                null), d = { x: 0, y: 0 }; if (a) for (var p = r.length - 1; 0 <= p; p--) { var l = a.getPropertyValue(r[p] + "transform"); if (l && /matrix/i.test(l)) { a = l.replace(/^matrix\(/i, "").split(/, |\)$/g); d = { x: parseInt(a[4], 10), y: parseInt(a[5], 10) }; break } } return d
        }; d.fn.animate = function (a, b, p, l) {
            a = a || {}; var j = !("undefined" !== typeof a.bottom || "undefined" !== typeof a.right), h = d.speed(b, p, l), c = this, n = 0, q = function () { n--; 0 === n && "function" === typeof h.complete && h.complete.apply(c, arguments) }, t; if (!(t = !0 === ("undefined" !== typeof a.avoidCSSTransitions ?
                a.avoidCSSTransitions : C))) if (!(t = !O)) if (!(t = B(a))) { var k; a: { for (k in a) if (("width" == k || "height" == k) && ("show" == a[k] || "hide" == a[k] || "toggle" == a[k])) { k = !0; break a } k = !1 } t = k || 0 >= h.duration } return t ? J.apply(this, arguments) : this[!0 === h.queue ? "queue" : "each"](function () {
                    var b = d(this), c = d.extend({}, h), l = function (c) {
                        var g = b.data("jQe") || { original: {} }, f = {}; if (2 == c.eventPhase) {
                            if (!0 !== a.leaveTransforms) {
                                for (c = r.length - 1; 0 <= c; c--)f[r[c] + "transform"] = ""; if (j && "undefined" !== typeof g.meta) {
                                    c = 0; for (var e; e = I[c]; ++c)f[e] =
                                        g.meta[e + "_o"] + "px", d(this).css(e, f[e])
                                }
                            } b.unbind("webkitTransitionEnd oTransitionEnd transitionend").css(g.original).css(f).data("jQe", null); "hide" === a.opacity && b.css({ display: "none", opacity: "" }); q.call(this)
                        }
                    }, k = {
                        bounce: "cubic-bezier(0.0, 0.35, .5, 1.3)", linear: "linear", swing: "ease-in-out", easeInQuad: "cubic-bezier(0.550, 0.085, 0.680, 0.530)", easeInCubic: "cubic-bezier(0.550, 0.055, 0.675, 0.190)", easeInQuart: "cubic-bezier(0.895, 0.030, 0.685, 0.220)", easeInQuint: "cubic-bezier(0.755, 0.050, 0.855, 0.060)",
                        easeInSine: "cubic-bezier(0.470, 0.000, 0.745, 0.715)", easeInExpo: "cubic-bezier(0.950, 0.050, 0.795, 0.035)", easeInCirc: "cubic-bezier(0.600, 0.040, 0.980, 0.335)", easeInBack: "cubic-bezier(0.600, -0.280, 0.735, 0.045)", easeOutQuad: "cubic-bezier(0.250, 0.460, 0.450, 0.940)", easeOutCubic: "cubic-bezier(0.215, 0.610, 0.355, 1.000)", easeOutQuart: "cubic-bezier(0.165, 0.840, 0.440, 1.000)", easeOutQuint: "cubic-bezier(0.230, 1.000, 0.320, 1.000)", easeOutSine: "cubic-bezier(0.390, 0.575, 0.565, 1.000)", easeOutExpo: "cubic-bezier(0.190, 1.000, 0.220, 1.000)",
                        easeOutCirc: "cubic-bezier(0.075, 0.820, 0.165, 1.000)", easeOutBack: "cubic-bezier(0.175, 0.885, 0.320, 1.275)", easeInOutQuad: "cubic-bezier(0.455, 0.030, 0.515, 0.955)", easeInOutCubic: "cubic-bezier(0.645, 0.045, 0.355, 1.000)", easeInOutQuart: "cubic-bezier(0.770, 0.000, 0.175, 1.000)", easeInOutQuint: "cubic-bezier(0.860, 0.000, 0.070, 1.000)", easeInOutSine: "cubic-bezier(0.445, 0.050, 0.550, 0.950)", easeInOutExpo: "cubic-bezier(1.000, 0.000, 0.000, 1.000)", easeInOutCirc: "cubic-bezier(0.785, 0.135, 0.150, 0.860)",
                        easeInOutBack: "cubic-bezier(0.680, -0.550, 0.265, 1.550)"
                    }, y = {}, k = k[c.easing || "swing"] ? k[c.easing || "swing"] : c.easing || "swing", e; for (e in a) if (-1 === d.inArray(e, T)) {
                        var p = -1 < d.inArray(e, I), m; var g = b, w = a[e], u = e, s = p && !0 !== a.avoidTransforms; if ("d" == u) m = void 0; else if (M(g)) {
                            var f = U.exec(w); m = "auto" === g.css(u) ? 0 : g.css(u); m = "string" == typeof m ? H(m) : m; "string" == typeof w && H(w); var s = !0 === s ? 0 : m, t = g.is(":hidden"), v = g.translation(); "left" == u && (s = parseInt(m, 10) + v.x); "right" == u && (s = parseInt(m, 10) + v.x); "top" == u &&
                                (s = parseInt(m, 10) + v.y); "bottom" == u && (s = parseInt(m, 10) + v.y); !f && "show" == w ? (s = 1, t && g.css({ display: R(g.context.tagName), opacity: 0 })) : !f && "hide" == w && (s = 0); f ? (g = parseFloat(f[2]), f[1] && (g = ("-=" === f[1] ? -1 : 1) * g + parseInt(s, 10)), m = g) : m = s
                        } else m = void 0; f = e; g = m; w = b; if (M(w)) { u = -1 < d.inArray(f, S); if (("width" == f || "height" == f || "opacity" == f) && parseFloat(g) === parseFloat(w.css(f))) u = !1; f = u } else f = !1; if (f) {
                            var f = b, g = e, w = c.duration, u = k, p = p && !0 !== a.avoidTransforms, s = j, t = a.useTranslate3d, v = (v = f.data("jQe")) && !B(v) ? v : d.extend(!0,
                                {}, W), A = m; if (-1 < d.inArray(g, I)) { var E = v.meta, C = H(f.css(g)) || 0, z = g + "_o", A = m - C; E[g] = A; E[z] = "auto" == f.css(g) ? 0 + A : C + A || 0; v.meta = E; s && 0 === A && (A = 0 - E[z], E[g] = A, E[z] = 0) } f.data("jQe", P(f, v, g, w, u, A, p, s, t))
                        } else y[e] = a[e]
                    } b.unbind("webkitTransitionEnd oTransitionEnd transitionend"); if ((e = b.data("jQe")) && !B(e) && !B(e.secondary)) { n++; b.css(e.properties); var G = e.secondary; setTimeout(function () { b.bind("webkitTransitionEnd oTransitionEnd transitionend", l).css(G) }) } else c.queue = !1; B(y) || (n++ , J.apply(b, [y, {
                        duration: c.duration,
                        easing: d.easing[c.easing] ? c.easing : d.easing.swing ? "swing" : "linear", complete: q, queue: c.queue
                    }])); return !0
                })
        }; d.fn.animate.defaults = {}; d.fn.stop = function (a, b, p) {
            if (!O) return K.apply(this, [a, b]); a && this.queue([]); this.each(function () {
                var l = d(this), j = l.data("jQe"); if (j && !B(j)) {
                    var h, c = {}; if (b) {
                        if (c = j.secondary, !p && void 0 !== typeof j.meta.left_o || void 0 !== typeof j.meta.top_o) {
                        c.left = void 0 !== typeof j.meta.left_o ? j.meta.left_o : "auto"; c.top = void 0 !== typeof j.meta.top_o ? j.meta.top_o : "auto"; for (h = r.length -
                            1; 0 <= h; h--)c[r[h] + "transform"] = ""
                        }
                    } else if (!B(j.secondary)) { var n = window.getComputedStyle(l[0], null); if (n) for (var q in j.secondary) if (j.secondary.hasOwnProperty(q) && (q = q.replace(V, "-$1").toLowerCase(), c[q] = n.getPropertyValue(q), !p && /matrix/i.test(c[q]))) { h = c[q].replace(/^matrix\(/i, "").split(/, |\)$/g); c.left = parseFloat(h[4]) + parseFloat(l.css("left")) + "px" || "auto"; c.top = parseFloat(h[5]) + parseFloat(l.css("top")) + "px" || "auto"; for (h = r.length - 1; 0 <= h; h--)c[r[h] + "transform"] = "" } } l.unbind("webkitTransitionEnd oTransitionEnd transitionend");
                    l.css(j.original).css(c).data("jQe", null)
                } else K.apply(l, [a, b])
            }); return this
        }
})(jQuery, jQuery.fn.animate, jQuery.fn.stop);