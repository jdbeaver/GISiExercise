__author__ = 'jbeaver'

from PyQt4 import QtCore, QtGui, uic
from mapfunctions import *

class NormLonGUI(QtGui.QMainWindow):
    def __init__(self, *args):

        QtGui.QMainWindow.__init__(self)
        self.ui = uic.loadUi("normlon.ui")
        self.ui.show()
        self.connect(self.ui.normlonButton, QtCore.SIGNAL("clicked()"), self.normlonbutton_clicked)
        self.connect(self.ui.longitudelineEdit, QtCore.SIGNAL("returnPressed()"), self.normlonbutton_clicked)

    def normlonbutton_clicked(self):
        mf = MapFunctions()
        lon_input = self.ui.longitudelineEdit.text()
        if self.checkinput(lon_input):
            #print mf.norm_longitude(self.ui.longitudeValue.Value)
            norm_lon_value = mf.norm_longitude_mod(float(lon_input))
            self.ui.outputLabel.setText('The normalized longitude is: ' + str(norm_lon_value))

    def checkinput(self, lon_input):
        try:
            isinstance(float(lon_input), (int, float))
        except ValueError:
            self.ui.outputLabel.setText('Enter a valid number...')
            return False
        return True

if __name__ == '__main__':
    import sys

    app = QtGui.QApplication(sys.argv)
    win = NormLonGUI()
    sys.exit(app.exec_())

