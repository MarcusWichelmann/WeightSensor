# WeightSensor
![Screenshot](WeightSensorViewer.png)

Ein Projekt zur einfachen �bertragung der Messerte eines HX711-Gewichtssensors von einem Arduino an ein Anzeigeprogramm f�r Windows, Linux und (theoretisch auch) OSX.

[Weitere Informationen zum Gewichtssensor](https://www.dfrobot.com/wiki/index.php/Weight_Sensor_Module_V1)

## Arduino flashen
Um das Programm verwenden zu k�nnen muss zun�chst das beiligende "WeightSensorReader"-Programm auf den Arduino, an dem der Gewichtssensor angeschlossen ist, �bertragen werden.

Die beiliegende Projektdatei ist daf�r vorgesehen, dass dieser Upload-Prozess �ber die VisualStudio-IDE mit installiertem VisualMicro-Plugin erfolgt, alternativ kann die `WeightSensorReader.ino` aber auch einfach in der Arduino-IDE ge�ffnet werden um das Programm damit zu �bertragen.

## Programm installieren
### Windows
Im Verzeichnis `WeightSensorViewer/` findet sich eine `setup.exe`  welche das Programm samt aller erforderlichen Komponenten auf dem Computer installiert. Das Programm kann anschlie�end �ber das Startmen� oder �ber eine Desktopverkn�pfung gestartet werden.

### Linux
F�r Linux steht derzeit noch kein Installationsprogramm zur Verf�gung, daher muss das Programm manuell �ber die Konsole kompiliert werden. Zun�chst sollte mit folgenden Befehlen sichergestellt werden, dass die neueste Mono-Runtime auf dem Computer installiert ist.
```
sudo apt-get update
sudo apt-get install mono-complete
```
Anschlie�end kann das Programm im Verzeichnis `WeightSensorViewer/` wie folgt kompiliert werden:
```
mcs -pkg:dotnet *.cs
```
Sollten dabei Fehler auftreten, pr�fen Sie bitte die installierte Version der Mono-Runtime, da Teile des Programmcodes aktuelle Features von C# 6.0 verwenden.

Nach erfolgreichem Kompilieren erscheint im genannten Verzeichnis eine .exe-Datei, welche durch Doppelklick oder mit dem Befehl `./WeightSensorViewer.exe` das Programm startet.

## Erste Schritte
Nach Start des Programmes findet sich im oberen Teil des Programms eine Auswahlbox, mit der der Port ausgew�hlt werden kann, an dem der Arduino angeschlossen ist. Auf Linux-Sytemen lautet der Portname z.B. `/dev/ttyACM0`, auf Windows-Systemen muss einer der `COM`-Ports gew�hlt werden (welcher der richtige ist, l�sst sich durch Ausprobieren oder �ber den Ger�te-Manager herausfinden). Nach einem Klick auf "Verbinden" wird versucht eine Verbindung zu dem Arduino herzustellen. Der Verbindungsstatus wird dabei oben rechts im Fenster angezeigt.