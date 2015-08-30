//------------------------------------------------------------------------------
// Saved By DarkDragonDX

function Build_SMLCabin(%client, %center, %team)
{
  if (%team $= "")
   %team = 1;
%offset = VectorSub(GetWords(%center, 0, 1) SPC GetWord(%center, 2), "51.6009 63.784 0");

%building = new (StaticShape) () {datablock = DeployedSpine;Position = VectorAdd("58.9785 62.1428 4.314", %offset);Scale = "1.12496 0.166666 16";Type = "Cabin";team = %team;};addToDeployGroup(%obj);
%building.setRotation("0.338275 0.782451 0.522819 3.58617");
%building = new (StaticShape) () {datablock = DeployedSpine;Position = VectorAdd("48.8582 60.862 4.064", %offset);Scale = "0.125 0.166666 8.128";Type = "Cabin";team = %team;};addToDeployGroup(%obj);
%building.setRotation("-0.36845 0.929648 1.17841e-06 3.14159");
%building = new (StaticShape) () {datablock = DeployedSpine;Position = VectorAdd("57.426 63.4285 4.064", %offset);Scale = "0.125 0.166666 8.128";Type = "Cabin";team = %team;};addToDeployGroup(%obj);
%building.setRotation("0.396826 0.917894 1.16351e-06 3.14159");
%building = new (StaticShape) () {datablock = DeployedSpine;Position = VectorAdd("60.1665 60.5145 4.064", %offset);Scale = "0.125 0.166666 8.128";Type = "Cabin";team = %team;};addToDeployGroup(%obj);
%building.setRotation("0.917893 -0.396827 -5.03014e-07 3.14159");
%building = new (StaticShape) () {datablock = DeployedSpine;Position = VectorAdd("51.6009 63.784 4.314", %offset);Scale = "0.125 2.83332 24.9998";Type = "Cabin";team = %team;};addToDeployGroup(%obj);
%building.setRotation("-0.368847 -0.853174 0.368845 1.72893");
%building = new (StaticShape) () {datablock = DeployedSpine;Position = VectorAdd("57.079 52.12 4.064", %offset);Scale = "0.125 0.166666 8.128";Type = "Cabin";team = %team;};addToDeployGroup(%obj);
%building.setRotation("-0.36845 0.929648 1.17841e-06 3.14159");
%building = new (StaticShape) () {datablock = DeployedSpine;Position = VectorAdd("62.907 57.6005 4.064", %offset);Scale = "0.125 0.166666 8.128";Type = "Cabin";team = %team;};addToDeployGroup(%obj);
%building.setRotation("0.917893 -0.396827 -5.03014e-07 3.14159");
%building = new (StaticShape) () {datablock = DeployedSpine;Position = VectorAdd("54.686 66.3425 4.064", %offset);Scale = "0.125 0.166666 8.128";Type = "Cabin";team = %team;};addToDeployGroup(%obj);
%building.setRotation("0.917893 -0.396827 -5.03014e-07 3.14159");
%building = new (StaticShape) () {datablock = DeployedSpine;Position = VectorAdd("54.6861 66.3421 4.564", %offset);Scale = "0.125 0.166666 8";Type = "Cabin";team = %team;};addToDeployGroup(%obj);
%building.setRotation("0 0 1 0.816115");
%building = new (StaticShape) () {datablock = DeployedSpine;Position = VectorAdd("48.8582 60.8617 4.564", %offset);Scale = "0.125 0.166666 8";Type = "Cabin";team = %team;};addToDeployGroup(%obj);
%building.setRotation("0 0 1 0.816115");
%building = new (StaticShape) () {datablock = DeployedSpine;Position = VectorAdd("57.0788 52.1199 4.564", %offset);Scale = "0.125 0.166666 8";Type = "Cabin";team = %team;};addToDeployGroup(%obj);
%building.setRotation("0 0 1 0.816115");
%building = new (StaticShape) () {datablock = DeployedSpine;Position = VectorAdd("62.9065 57.6005 8.564", %offset);Scale = "0.125 0.166666 8";Type = "Cabin";team = %team;};addToDeployGroup(%obj);
%building.setRotation("0.917893 -0.396827 -5.03014e-07 3.14159");
%building = new (StaticShape) () {datablock = DeployedSpine;Position = VectorAdd("49.0402 61.0331 6.564", %offset);Scale = "1 0.166666 14.9999";Type = "Cabin";team = %team;};addToDeployGroup(%obj);
%building.setRotation("0.680876 0.269853 0.680873 2.61444");
%building = new (StaticShape) () {datablock = DeployedSpine;Position = VectorAdd("51.9435 63.4198 8.314", %offset);Scale = "0.125 2.8333 22.9998";Type = "Cabin";team = %team;};addToDeployGroup(%obj);
%building.setRotation("0.676216 -0.292345 0.676214 3.71043");
%building = new (StaticShape) () {datablock = DeployedSpine;Position = VectorAdd("50.5057 56.9202 4.623", %offset);Scale = "0.125 0.166666 9.246";Type = "Cabin";team = %team;};addToDeployGroup(%obj);
%building.setRotation("-0.36845 0.929648 1.17841e-06 3.14159");
%building = new (StaticShape) () {datablock = DeployedSpine;Position = VectorAdd("62.7248 57.429 6.564", %offset);Scale = "1 0.166666 14.9999";Type = "Cabin";team = %team;};addToDeployGroup(%obj);
%building.setRotation("-0.345729 0.872321 -0.345728 1.70698");
%building = new (StaticShape) () {datablock = DeployedSpine;Position = VectorAdd("57.38 63.4774 4.564", %offset);Scale = "0.125 0.166666 7";Type = "Cabin";team = %team;};addToDeployGroup(%obj);
%building.setRotation("0 0 1 0.816115");
%building = new (StaticShape) () {datablock = DeployedSpine;Position = VectorAdd("60.1619 60.5191 4.564", %offset);Scale = "0.125 0.166666 7";Type = "Cabin";team = %team;};addToDeployGroup(%obj);
%building.setRotation("0 0 1 0.816115");
%building = new (StaticShape) () {datablock = DeployedSpine;Position = VectorAdd("57.2087 63.6593 7.564", %offset);Scale = "0.25 0.166666 6.8647";Type = "Cabin";team = %team;};addToDeployGroup(%obj);
%building.setRotation("-0.676214 0.292342 0.676218 3.71043");
%building = new (StaticShape) () {datablock = DeployedSpine;Position = VectorAdd("57.2087 63.6593 5.064", %offset);Scale = "0.25 0.166666 6.8647";Type = "Cabin";team = %team;};addToDeployGroup(%obj);
%building.setRotation("0.368848 0.853172 0.368847 1.72893");
%building = new (StaticShape) () {datablock = DeployedSpine;Position = VectorAdd("62.7351 57.7822 7.564", %offset);Scale = "0.25 0.166666 7.01328";Type = "Cabin";team = %team;};addToDeployGroup(%obj);
%building.setRotation("-0.676214 0.292342 0.676218 3.71043");
%building = new (StaticShape) () {datablock = DeployedSpine;Position = VectorAdd("62.735 57.7823 5.064", %offset);Scale = "0.25 0.166666 7.0127";Type = "Cabin";team = %team;};addToDeployGroup(%obj);
%building.setRotation("0.368848 0.853172 0.368847 1.72893");
%building = new (StaticShape) () {datablock = DeployedSpine;Position = VectorAdd("51.4163 57.7765 4.873", %offset);Scale = "0.125 0.166666 3";Type = "Cabin";team = %team;};addToDeployGroup(%obj);
%building.setRotation("-0.853172 0.368847 0.368848 1.72893");
%building = new (StaticShape) () {datablock = DeployedSpine;Position = VectorAdd("54.1564 54.8626 4.814", %offset);Scale = "0.125 0.166666 3";Type = "Cabin";team = %team;};addToDeployGroup(%obj);
%building.setRotation("0.292345 0.676216 -0.676215 2.57276");
%building = new (StaticShape) () {datablock = DeployedSpine;Position = VectorAdd("53.2458 54.0063 4.564", %offset);Scale = "0.125 0.166666 9.128";Type = "Cabin";team = %team;};addToDeployGroup(%obj);
%building.setRotation("-0.36845 0.929648 1.17841e-06 3.14159");
%building = new (StaticShape) () {datablock = DeployedSpine;Position = VectorAdd("50.3995 59.2225 8.064", %offset);Scale = "0.999965 0.166666 7";Type = "Cabin";team = %team;};addToDeployGroup(%obj);
%building.setRotation("0.917891 -0.396833 -5.03022e-07 3.14159");
%building = new (StaticShape) () {datablock = DeployedSpine;Position = VectorAdd("51.7697 57.7658 7.235", %offset);Scale = "0.414252 0.166666 6.9997";Type = "Cabin";team = %team;};addToDeployGroup(%obj);
%building.setRotation("0.676217 -0.292344 0.676214 3.71043");
%building = new (StaticShape) () {datablock = DeployedSpine;Position = VectorAdd("55.5375 53.759 4.564", %offset);Scale = "1.00004 0.166666 7";Type = "Cabin";team = %team;};addToDeployGroup(%obj);
%building.setRotation("0 0 1 3.95771");
%building = new (StaticShape) () {datablock = DeployedSpine;Position = VectorAdd("53.2458 54.0063 5.064", %offset);Scale = "0.125 0.166666 16.1189";Type = "Cabin";team = %team;};addToDeployGroup(%obj);
%building.setRotation("0 0 1 2.38691");
%building = new (StaticShape) () {datablock = DeployedSpine;Position = VectorAdd("50.5057 56.9202 5.123", %offset);Scale = "0.125 0.166666 16";Type = "Cabin";team = %team;};addToDeployGroup(%obj);
%building.setRotation("0 0 1 2.38691");
%building = new (StaticShape) () {datablock = DeployedSpine;Position = VectorAdd("50.677 56.7381 12.873", %offset);Scale = "0.125 0.166666 6.9997";Type = "Cabin";team = %team;};addToDeployGroup(%obj);
%building.setRotation("0.676217 -0.292344 0.676214 3.71043");
%building = new (StaticShape) () {datablock = DeployedSpine;Position = VectorAdd("53.4279 54.1776 12.873", %offset);Scale = "0.125 0.166666 3";Type = "Cabin";team = %team;};addToDeployGroup(%obj);
%building.setRotation("0.680875 0.269854 0.680873 2.61444");
%building = new (StaticShape) () {datablock = DeployedSpine;Position = VectorAdd("50.6878 57.0915 12.873", %offset);Scale = "0.125 0.166666 3";Type = "Cabin";team = %team;};addToDeployGroup(%obj);
%building.setRotation("0.680875 0.269854 0.680873 2.61444");
%building = new (StaticShape) () {datablock = DeployedSpine;Position = VectorAdd("54.1672 55.216 12.873", %offset);Scale = "0.125 0.166666 6.9997";Type = "Cabin";team = %team;};addToDeployGroup(%obj);
%building.setRotation("0.872319 0.345729 -0.345733 1.70697");
%building = new (StaticShape) () {datablock = DeployedSpine;Position = VectorAdd("52.9685 56.491 12.623", %offset);Scale = "0.125 1.49999 8.118";Type = "Cabin";team = %team;};addToDeployGroup(%obj);
%building.setRotation("0.929647 0.368452 4.67046e-07 3.14159");
%building = new (StaticShape) () {datablock = DeployedSpine;Position = VectorAdd("53.7922 54.5202 5.064", %offset);Scale = "0.125 0.333393 15.1179";Type = "Cabin";team = %team;};addToDeployGroup(%obj);
%building.setRotation("2.94032e-07 3.06284e-06 1 3.95771");
%building = new (StaticShape) () {datablock = DeployedSpine;Position = VectorAdd("51.0521 57.4341 5.123", %offset);Scale = "0.125 0.33337 15";Type = "Cabin";team = %team;};addToDeployGroup(%obj);
%building.setRotation("2.94032e-07 3.06284e-06 1 3.95771");
%building = new (StaticShape) () {datablock = DeployedSpine;Position = VectorAdd("53.0743 54.1882 8.593", %offset);Scale = "0.125 2.68633 6.9997";Type = "Cabin";team = %team;};addToDeployGroup(%obj);
%building.setRotation("-0.269854 0.680875 0.680873 2.61444");
%building = new (StaticShape) () {datablock = DeployedSpine;Position = VectorAdd("53.4279 54.1776 4.314", %offset);Scale = "0.125 0.166666 2.00008";Type = "Cabin";team = %team;};addToDeployGroup(%obj);
%building.setRotation("0.345728 -0.872321 -0.345728 1.70698");
%building = new (StaticShape) () {datablock = DeployedSpine;Position = VectorAdd("53.4371 54.5293 4.314", %offset);Scale = "0.125 0.501492 6.9997";Type = "Cabin";team = %team;};addToDeployGroup(%obj);
%building.setRotation("-0.676214 0.292343 0.676218 3.71043");
%building = new (StaticShape) () {datablock = DeployedSpine;Position = VectorAdd("50.6878 57.0915 4.373", %offset);Scale = "0.125 0.166666 1.99979";Type = "Cabin";team = %team;};addToDeployGroup(%obj);
%building.setRotation("0.345728 -0.872321 -0.345728 1.70698");
}
