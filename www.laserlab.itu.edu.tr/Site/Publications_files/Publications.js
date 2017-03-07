// Created by iWeb 3.0.4 local-build-20160830

setTransparentGifURL('Media/transparent.gif');function applyEffects()
{var registry=IWCreateEffectRegistry();registry.registerEffects({shadow_0:new IWShadow({blurRadius:10,offset:new IWPoint(4.2426,4.2426),color:'#434343',opacity:0.750000}),reflection_0:new IWReflection({opacity:0.50,offset:2.00}),stroke_0:new IWEmptyStroke()});registry.applyEffects();}
function hostedOnDM()
{return false;}
function onPageLoad()
{loadMozillaCSS('Publications_files/PublicationsMoz.css')
adjustLineHeightIfTooBig('id1');adjustFontSizeIfTooBig('id1');adjustLineHeightIfTooBig('id2');adjustFontSizeIfTooBig('id2');adjustLineHeightIfTooBig('id3');adjustFontSizeIfTooBig('id3');adjustLineHeightIfTooBig('id4');adjustFontSizeIfTooBig('id4');adjustLineHeightIfTooBig('id5');adjustFontSizeIfTooBig('id5');fixupAllIEPNGBGs();Widget.onload();fixAllIEPNGs('Media/transparent.gif');IMpreload('Publications_files','shapeimage_2','0');IMpreload('Publications_files','shapeimage_2','1');IMpreload('Publications_files','shapeimage_2','2');IMpreload('Publications_files','shapeimage_2','3');IMpreload('Publications_files','shapeimage_2','4');IMpreload('Publications_files','shapeimage_2','5');IMpreload('Publications_files','shapeimage_2','6');IMpreload('Publications_files','shapeimage_2','7');applyEffects()}
function onPageUnload()
{Widget.onunload();}
