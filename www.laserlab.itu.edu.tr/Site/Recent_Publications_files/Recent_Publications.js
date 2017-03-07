// Created by iWeb 3.0.4 local-build-20160830

setTransparentGifURL('Media/transparent.gif');function applyEffects()
{var registry=IWCreateEffectRegistry();registry.registerEffects({stroke_0:new IWEmptyStroke(),reflection_0:new IWReflection({opacity:0.50,offset:2.00}),shadow_0:new IWShadow({blurRadius:10,offset:new IWPoint(4.2426,4.2426),color:'#434343',opacity:0.750000})});registry.applyEffects();}
function hostedOnDM()
{return false;}
function onPageLoad()
{loadMozillaCSS('Recent_Publications_files/Recent_PublicationsMoz.css')
adjustLineHeightIfTooBig('id1');adjustFontSizeIfTooBig('id1');adjustLineHeightIfTooBig('id2');adjustFontSizeIfTooBig('id2');adjustLineHeightIfTooBig('id3');adjustFontSizeIfTooBig('id3');fixupAllIEPNGBGs();fixAllIEPNGs('Media/transparent.gif');Widget.onload();IMpreload('Recent_Publications_files','shapeimage_2','0');IMpreload('Recent_Publications_files','shapeimage_3','0');IMpreload('Recent_Publications_files','shapeimage_3','1');IMpreload('Recent_Publications_files','shapeimage_3','2');IMpreload('Recent_Publications_files','shapeimage_3','3');IMpreload('Recent_Publications_files','shapeimage_3','4');IMpreload('Recent_Publications_files','shapeimage_3','5');IMpreload('Recent_Publications_files','shapeimage_3','6');IMpreload('Recent_Publications_files','shapeimage_3','7');applyEffects()}
function onPageUnload()
{Widget.onunload();}
